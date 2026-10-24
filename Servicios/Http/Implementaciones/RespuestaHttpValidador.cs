using System.Net.Http.Json;
using Utilidades.Dtos;
using Utilidades.Excepciones;
using Utilidades.Servicios.Http.Interfaces;

namespace Utilidades.Servicios.Http.Implementaciones
{
    public class RespuestaHttpValidador : IRespuestaHttpValidador
    {
        public async Task ValidarRespuesta(HttpResponseMessage respuesta, string mensaje)
        {
            var detalleError = "";
            if (!respuesta.IsSuccessStatusCode)
            {
                detalleError = $"{mensaje} {respuesta.ReasonPhrase}. ";
                try
                {
                    var error = await respuesta.Content.ReadFromJsonAsync<ApiResponseDto<string>>();
                    if (error is not null && !string.IsNullOrWhiteSpace(error.Mensaje))
                        detalleError += $"{error.Mensaje}. ";
                }
                catch (Exception e)
                {
                    detalleError += e.Message;
                }
                throw new SolicitudHttpException(detalleError);
            }
        }

        public async Task ValidarRespuestaExterna(HttpResponseMessage respuesta, string mensaje)
        {
            if (!respuesta.IsSuccessStatusCode)
            {
                var detalleError = $"{mensaje} {respuesta.ReasonPhrase}. ";
                var contenidoError = await respuesta.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(contenidoError))
                    detalleError += contenidoError;

                throw new SolicitudHttpException(detalleError);
            }
        }
    }
}
