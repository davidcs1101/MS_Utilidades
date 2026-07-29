using System.ComponentModel.DataAnnotations;
namespace Utilidades.Dtos
{
    public class ColaSolicitudCreacionRequest
    {
        [Required(ErrorMessage = Textos.Generales.VALIDA_CAMPO_OBLIGATORIO)]
        [MaxLength(250, ErrorMessage = Textos.Generales.VALIDA_VALOR_EXCEDE_LONGITUD)]
        public string Tipo { get; set; } = "";
        public string Payload { get; set; } = "";
    }
}
