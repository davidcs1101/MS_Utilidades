using System.ComponentModel.DataAnnotations;
namespace Utilidades.Dtos.Correos
{
    public class CorreoEmpresaCreacionRequest : CorreoCreacionRequest
    {
        [Required(ErrorMessage = Textos.Generales.VALIDA_CAMPO_OBLIGATORIO)]
        public int EmpresaId { get; set; }
        public string? CodigoConfiguracionEnvio { get; set; }
        public PlantillaRequest? Plantilla { get; set; }
    }
}
