using Refit;
namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSDatosComunesBackgroundServicio
    {
        [Get("/listasDetalles/listar")]
        Task<HttpResponseMessage> ListarListasDetalleAsync();

        [Post("/listasDetalles/listarPorCodigosConstante")]
        Task<HttpResponseMessage> ListarListasDetallePorCodigosConstanteAsync(List<string> codigosConstante);

        [Get("/listasDetalles/listarPorCodigoLista")]
        Task<HttpResponseMessage> ListarListasDetallePorCodigoListaAsync([Query] string codigoLista);

        [Get("/listasDetalles/listarPorCodigoConstante")]
        Task<HttpResponseMessage> ListarListasDetallePorCodigoConstanteAsync([Query] string codigoConstante);


        [Get("/geografia/listar")]
        Task<HttpResponseMessage> ListarGeografiaAsync();
    }
}
