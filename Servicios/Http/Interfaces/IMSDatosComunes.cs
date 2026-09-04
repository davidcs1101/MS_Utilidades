using Utilidades.Dtos;
namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IMSDatosComunes
    {
        Task<List<ListaDetalleDto?>> ListarListasDetallePorCodigosConstanteAsync(List<string> codigosConstante);
    }
}
