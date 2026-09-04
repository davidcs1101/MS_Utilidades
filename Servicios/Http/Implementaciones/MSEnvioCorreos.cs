using Utilidades.Dtos.Correos;
using Utilidades.Servicios.Http.Interfaces;
using Utilidades.Servicios.Http.Interfaces.Contextos;

namespace Utilidades.Servicios.Http.Implementaciones
{
    public class MSEnvioCorreos : IMSEnvioCorreos
    {
        private readonly IMSEnvioCorreosBackgroundServicio _msEnvioCorreosBackgroundServicio;
        private readonly IServicioEjecutorHttp _servicioComun;

        public MSEnvioCorreos(IMSEnvioCorreosBackgroundServicio msEnvioCorreosBackgroundServicio,  IServicioEjecutorHttp servicioComun)
        {
            _msEnvioCorreosBackgroundServicio = msEnvioCorreosBackgroundServicio;
            _servicioComun = servicioComun;
        }

        public async Task<string> EnviarAsync(CorreoCreacionRequest datoCorreoRequest) 
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<CorreoCreacionRequest, string>(
                funcionEjecutar: _msEnvioCorreosBackgroundServicio.EnviarCorreoAsync,
                request: datoCorreoRequest);
        }
    }
}
