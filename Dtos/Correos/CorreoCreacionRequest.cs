using System.ComponentModel.DataAnnotations;
using Utilidades.AtributosValidaciones;
namespace Utilidades.Dtos.Correos
{
    public class CorreoCreacionRequest
    {
        [ListaDebeContenerElementos(ErrorMessage = "Debe existir al menos un destinatario.")]
        [ListaCorreosValidos]
        public List<string> Destinatarios { get; set; } = new List<string>();

        [ListaCorreosValidos]
        public List<string> CC { get; set; } = new List<string>();

        [ListaCorreosValidos]
        public List<string> CCO { get; set; } = new List<string>();

        [EmailAddress(ErrorMessage = Textos.Generales.VALIDA_CORREO_NO_VALIDO)]
        public string? CorreoRespuesta { get; set; }
        public string Asunto { get; set; } = "";
        public string Cuerpo { get; set; } = "";

        [Required(ErrorMessage = Textos.Generales.VALIDA_CAMPO_OBLIGATORIO)]
        public bool EsCuerpoHtml { get; set; } = false;

        public List<CorreoAdjuntoRequest> ArchivosAdjuntos { get; set; } = new List<CorreoAdjuntoRequest>();

        [Required(ErrorMessage = Textos.Generales.VALIDA_CAMPO_OBLIGATORIO)]
        public int UsuarioCreadorId { get; set; }


        public AccionesRequest Acciones { get; set; } = new AccionesRequest();

    }
}
