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

    }
}
