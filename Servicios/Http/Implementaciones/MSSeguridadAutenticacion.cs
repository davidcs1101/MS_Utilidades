using Utilidades.Dtos.Seguridad;
using Utilidades.Servicios.Http.Interfaces;
using Utilidades.Servicios.Http.Interfaces.Contextos;

namespace Utilidades.Servicios.Http.Implementaciones
{
    public class MSSeguridadAutenticacion : IMSSeguridadAutenticacion
    {
        private readonly IMSSeguridadAutenticacionServicio _msSeguridadAutenticacionServicio;
        private readonly IServicioEjecutorHttp _servicioComun;

        public MSSeguridadAutenticacion(IServicioEjecutorHttp servicioComun, IMSSeguridadAutenticacionServicio msSeguridadAutenticacionServicio)
        {
            _msSeguridadAutenticacionServicio = msSeguridadAutenticacionServicio;
            _servicioComun = servicioComun;
        }

        public async Task<AutenticacionResponse> AutenticarUsuarioAsync(AutenticacionRequest autenticacionRequest)
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<AutenticacionRequest, AutenticacionResponse>(
                funcionEjecutar: _msSeguridadAutenticacionServicio.AutenticarUsuarioAsync,
                request: autenticacionRequest);
        }
    }
}
