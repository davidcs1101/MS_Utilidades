using Refit;
namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSDatosComunesBackgroundServicio
    {
        [Get("/listasDetalles/listar")]
        Task<HttpResponseMessage> ListarListasDetalleAsync();


        [Post("/listasDetalles/listarPorCodigosConstante")]
        Task<HttpResponseMessage> ListarListasDetallePorCodigosConstanteAsync(List<string> codigosConstante);
    }
}
