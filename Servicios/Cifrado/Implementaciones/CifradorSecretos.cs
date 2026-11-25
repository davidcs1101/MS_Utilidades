using System.Security.Cryptography;
using System.Text;
using Utilidades.Servicios.Cifrado.Interfaces;

namespace Utilidades.Servicios.Cifrado.Implementaciones
{
    /// <summary>
    /// AES-256-GCM. Formato del valor cifrado: v1:{idClave}:{base64(nonce | texto cifrado | etiqueta)}.
    /// Cada cifrado usa un nonce aleatorio, y la etiqueta de autenticación detecta cualquier alteración del valor.
    /// Las claves se validan al primer uso (no al construir), para no impedir herramientas como las migraciones
    /// de EF cuando la clave no está disponible.
    /// </summary>
    public class CifradorSecretos : ICifradorSecretos
    {
        private const string Version = "v1";
        private const char Separador = ':';
        private const int TamanoClaveBytes = 32;
        private const int TamanoNonceBytes = 12;
        private const int TamanoEtiquetaBytes = 16;

        private readonly CifradoSecretosSettings _settings;
        private readonly Lazy<Dictionary<string, byte[]>> _claves;

        public CifradorSecretos(CifradoSecretosSettings settings)
        {
            _settings = settings;
            _claves = new Lazy<Dictionary<string, byte[]>>(CargarClaves);
        }

        public bool EstaCifrado(string valor)
        {
            return valor.StartsWith(Version + Separador, StringComparison.Ordinal);
        }

        public string Cifrar(string textoClaro)
        {
            ArgumentNullException.ThrowIfNull(textoClaro);

            var claves = _claves.Value;
            var idClave = _settings.ClaveActiva!;
            var clave = claves[idClave];

            var plano = Encoding.UTF8.GetBytes(textoClaro);
            var nonce = RandomNumberGenerator.GetBytes(TamanoNonceBytes);
            var cifrado = new byte[plano.Length];
            var etiqueta = new byte[TamanoEtiquetaBytes];

            using var aes = new AesGcm(clave, TamanoEtiquetaBytes);
            aes.Encrypt(nonce, plano, cifrado, etiqueta);

            var carga = new byte[TamanoNonceBytes + cifrado.Length + TamanoEtiquetaBytes];
            Buffer.BlockCopy(nonce, 0, carga, 0, TamanoNonceBytes);
            Buffer.BlockCopy(cifrado, 0, carga, TamanoNonceBytes, cifrado.Length);
            Buffer.BlockCopy(etiqueta, 0, carga, TamanoNonceBytes + cifrado.Length, TamanoEtiquetaBytes);

            return string.Concat(Version, Separador, idClave, Separador, Convert.ToBase64String(carga));
        }

        public string Descifrar(string valor)
        {
            ArgumentNullException.ThrowIfNull(valor);

            if (!EstaCifrado(valor))
            {
                if (_settings.PermitirTextoClaroHeredado)
                    return valor;

                throw new CryptographicException(
                    "El valor almacenado no está cifrado y no se permite texto claro heredado.");
            }

            var partes = valor.Split(Separador, 3);
            if (partes.Length != 3)
                throw new CryptographicException("El valor cifrado tiene un formato inválido.");

            if (!_claves.Value.TryGetValue(partes[1], out var clave))
                throw new CryptographicException($"No existe la clave de cifrado '{partes[1]}' en la configuración.");

            byte[] carga;
            try
            {
                carga = Convert.FromBase64String(partes[2]);
            }
            catch (FormatException)
            {
                throw new CryptographicException("El valor cifrado tiene un formato inválido.");
            }

            if (carga.Length < TamanoNonceBytes + TamanoEtiquetaBytes)
                throw new CryptographicException("El valor cifrado tiene un formato inválido.");

            var nonce = carga.AsSpan(0, TamanoNonceBytes);
            var cifrado = carga.AsSpan(TamanoNonceBytes, carga.Length - TamanoNonceBytes - TamanoEtiquetaBytes);
            var etiqueta = carga.AsSpan(carga.Length - TamanoEtiquetaBytes, TamanoEtiquetaBytes);
            var plano = new byte[cifrado.Length];

            using var aes = new AesGcm(clave, TamanoEtiquetaBytes);
            aes.Decrypt(nonce, cifrado, etiqueta, plano);

            return Encoding.UTF8.GetString(plano);
        }

        private Dictionary<string, byte[]> CargarClaves()
        {
            if (_settings.Claves is null || _settings.Claves.Count == 0)
                throw new InvalidOperationException(
                    "No hay claves de cifrado configuradas. Defina la sección 'Cifrado:Claves'.");

            var claves = new Dictionary<string, byte[]>(StringComparer.Ordinal);
            foreach (var (id, valorBase64) in _settings.Claves)
            {
                byte[] clave;
                try
                {
                    clave = Convert.FromBase64String(valorBase64);
                }
                catch (FormatException)
                {
                    throw new InvalidOperationException($"La clave de cifrado '{id}' no es base64 válido.");
                }

                if (clave.Length != TamanoClaveBytes)
                    throw new InvalidOperationException(
                        $"La clave de cifrado '{id}' debe tener {TamanoClaveBytes} bytes (tiene {clave.Length}).");

                claves[id] = clave;
            }

            if (string.IsNullOrWhiteSpace(_settings.ClaveActiva) || !claves.ContainsKey(_settings.ClaveActiva))
                throw new InvalidOperationException(
                    "La clave activa de cifrado ('Cifrado:ClaveActiva') no existe entre las claves configuradas.");

            return claves;
        }
    }
}
