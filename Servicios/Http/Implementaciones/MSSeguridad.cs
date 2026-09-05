using Utilidades;
using Utilidades.Dtos;
using Utilidades.Dtos.Seguridad;
using Utilidades.Servicios.Serializacion.Interfaces;
using Utilidades.Servicios.Http.Interfaces;
using Utilidades.Servicios.Http.Interfaces.Contextos;

namespace Utilidades.Servicios.Http.Implementaciones
{
    public class MSSeguridad : IMSSeguridad
    {
        private readonly IMSSeguridadContextoWebServicio _msSeguridadContextoWebServicio;
        private readonly ISerializadorJsonServicio _serializadorJsonServicio;
        
        private readonly IMSSeguridadBackgroundServicio _msSeguridadBackgroundServicio;
        private readonly IServicioEjecutorHttp _servicioComun;


        public MSSeguridad(IMSSeguridadContextoWebServicio msSeguridadContextoWebServicio, ISerializadorJsonServicio serializadorJsonServicio, IMSSeguridadBackgroundServicio msSeguridadBackgroundServicio, IServicioEjecutorHttp servicioComun)
        {
            _msSeguridadContextoWebServicio = msSeguridadContextoWebServicio;
            _serializadorJsonServicio = serializadorJsonServicio;
            _msSeguridadBackgroundServicio = msSeguridadBackgroundServicio;
            _servicioComun = servicioComun;
        }

        public async Task<List<AutorizacionDto>> ListarCatalogoAutorizacion()
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<List<AutorizacionDto>>(
                funcionEjecutar: _msSeguridadBackgroundServicio.ListarCatalogoAutorizacionAsync); 
        }

        public async Task<List<UsuarioDto>?> ListarUsuarios(IdsListadoDto idsListadoDto) 
        {
            var respuesta = await _msSeguridadContextoWebServicio.ObtenerNombresUsuariosPorIds(idsListadoDto);
            var contenidoJson = await respuesta.Content.ReadAsStringAsync();
            var resultado = _serializadorJsonServicio.Deserializar<ApiResponseDto<List<UsuarioDto>?>>(contenidoJson);
            if (resultado is null || !resultado.Correcto) {
                Logs.EscribirLog("e", "OJO CAMBIAR: NO FUE POSIBLE OBTENER LOS DATOS DEL MICROSERVICIO DE USUARIOS");
                return new List<UsuarioDto>();
            }

            return resultado.Data;
        }
    }
}
