namespace Utilidades.Dtos.Empresas
{
    public class EmpresaDto : BaseAuditoriaDto
    {
        public int Id { get; set; }

        public string TipoIdentificacion { get; set; } = null!;

        public string Identificacion { get; set; } = null!;

        public Int16 DigitoVerificador { get; set; }

        public string Nombre { get; set; } = null!;

        public string PersonaContacto { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Telefono { get; set; } = null!;
        public Int16 CantidadSedes { get; set; }

        public bool EsAseguradora { get; set; } = false;

        public bool EstaVerificada { get; set; } = false;

        public string? CodigoSalud { get; set; }
    }
}
