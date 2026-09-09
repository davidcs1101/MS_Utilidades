namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IPublicadorEventosBackgroundServicio
    {
        Task<HttpResponseMessage> PublicarActualizacion(string url, string tipoEvento, string payload = "");
    }
}
