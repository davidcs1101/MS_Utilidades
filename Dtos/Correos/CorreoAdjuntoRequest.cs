using System.ComponentModel.DataAnnotations;
namespace Utilidades.Dtos.Correos
{
    public class CorreoAdjuntoRequest
    {
        [Required(ErrorMessage = "El dato es obligatorio")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El dato es obligatorio")]
        public string Extension { get; set; } = null!;
        [Required(ErrorMessage = "El dato es obligatorio")]
        public string Contenido { get; set; } = null!;
    }
}
