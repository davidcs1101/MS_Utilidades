namespace Utilidades.Servicios.Cifrado.Interfaces
{
    /// <summary>
    /// Cifrado reversible de secretos (llaves, claves, tokens) para guardarlos cifrados en base de datos.
    /// No es un hash: el valor original se recupera con <see cref="Descifrar"/>.
    /// </summary>
    public interface ICifradorSecretos
    {
        /// <summary>
        /// Cifra el texto con la clave activa. El resultado incluye el identificador de la clave usada,
        /// lo que permite rotarla sin perder la capacidad de descifrar los valores anteriores.
        /// </summary>
        string Cifrar(string textoClaro);

        /// <summary>
        /// Descifra un valor producido por <see cref="Cifrar"/>. Si el valor no tiene formato cifrado y la
        /// configuración permite texto claro heredado, lo devuelve tal cual (transición de datos existentes).
        /// </summary>
        string Descifrar(string valor);

        /// <summary>
        /// Indica si el valor tiene el formato de un valor cifrado por este servicio.
        /// </summary>
        bool EstaCifrado(string valor);
    }
}
