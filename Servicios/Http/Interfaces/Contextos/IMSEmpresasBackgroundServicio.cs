using Refit;
namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSEmpresasBackgroundServicio
    {
        [Get("/sedes/obtenerPorId")]
        Task<HttpResponseMessage> ObtenerSedePorIdAsync([Query] int id);

        [Get("/sedes/listar")]
        Task<HttpResponseMessage> ListarSedesAsync();

        [Get("/empresas/obtenerPorId")]
        Task<HttpResponseMessage> ObtenerEmpresaPorIdAsync([Query] int id);

        [Get("/empresas/listar")]
        Task<HttpResponseMessage> ListarEmpresasAsync();
    }
}
