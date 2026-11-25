namespace Utilidades.Servicios.Cifrado
{
    /// <summary>
    /// Configuración del cifrado de secretos. Se enlaza con la sección "Cifrado" de la configuración.
    /// Las claves NO deben guardarse en el repositorio: en cada ambiente se cargan desde variables de entorno
    /// (por ejemplo Cifrado__Claves__k1) o desde un gestor de secretos.
    /// </summary>
    public class CifradoSecretosSettings
    {
        /// <summary>
        /// Identificador de la clave con la que se cifran los valores nuevos (debe existir en <see cref="Claves"/>).
        /// </summary>
        public string? ClaveActiva { get; set; }

        /// <summary>
        /// Claves disponibles: identificador -> clave de 32 bytes codificada en base64.
        /// Se conservan las claves anteriores mientras existan valores cifrados con ellas.
        /// </summary>
        public Dictionary<string, string> Claves { get; set; } = new();

        /// <summary>
        /// Mientras existan valores guardados en texto claro (anteriores al cifrado) debe estar en true:
        /// esos valores se leen tal cual. Cuando todos estén cifrados se pone en false y un valor sin cifrar falla.
        /// </summary>
        public bool PermitirTextoClaroHeredado { get; set; } = true;
    }
}
