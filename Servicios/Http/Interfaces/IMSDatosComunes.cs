using Utilidades.Dtos;
namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IMSDatosComunes
    {
        Task<List<ListaDetalleDto?>> ListarListasDetallePorCodigosConstanteAsync(List<string> codigosConstante);
        Task<List<ListaDetalleDto?>> ListarListasDetallePorCodigosListaAsync(List<string> codigosLista);
        Task<List<UbicacionCompletaDto?>> ListarGeografiaAsync();
    }
}
