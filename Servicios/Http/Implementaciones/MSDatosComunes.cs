using Utilidades.Dtos;
using Utilidades.Servicios.Http.Interfaces;
using Utilidades.Servicios.Http.Interfaces.Contextos;
namespace Utilidades.Servicios.Http.Implementaciones
{
    public class MSDatosComunes : IMSDatosComunes
    {
        private readonly IMSDatosComunesBackgroundServicio _msDatosComunesBackgroundServicio;
        private readonly IServicioEjecutorHttp _servicioComun;

        public MSDatosComunes(IMSDatosComunesBackgroundServicio msDatosComunesBackgroundServicio, IServicioEjecutorHttp servicioComun)
        {
            _msDatosComunesBackgroundServicio = msDatosComunesBackgroundServicio;
            _servicioComun = servicioComun;
        }

        public async Task<List<ListaDetalleDto?>> ListarListasDetallePorCodigosConstanteAsync(List<string> codigosConstante)
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<List<ListaDetalleDto?>>(
                funcionEjecutar: () => _msDatosComunesBackgroundServicio.ListarListasDetallePorCodigosConstanteAsync(codigosConstante));
        }

        public async Task<List<ListaDetalleDto?>> ListarListasDetallePorCodigosListaAsync(List<string> codigosLista)
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<List<ListaDetalleDto?>>(
                funcionEjecutar: () => _msDatosComunesBackgroundServicio.ListarListasDetallePorCodigosListaAsync(codigosLista));
        }

        public async Task<List<UbicacionCompletaDto?>> ListarGeografiaAsync()
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<List<UbicacionCompletaDto?>>(
                funcionEjecutar: _msDatosComunesBackgroundServicio.ListarGeografiaAsync);
        }

    }
}
