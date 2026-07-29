namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IRespuestaHttpValidador
    {
        Task ValidarRespuesta(HttpResponseMessage respuesta, string mensaje);
    }
}
