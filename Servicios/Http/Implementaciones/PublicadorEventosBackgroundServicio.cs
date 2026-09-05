using System.Net.Http.Json;
using Utilidades.Dtos;
using Utilidades.Servicios.Http.Interfaces;

namespace Utilidades.Servicios.Http.Implementaciones
{
    public class PublicadorEventosBackgroundServicio : IPublicadorEventosBackgroundServicio
    {
        private readonly HttpClient _httpClient;
        private readonly IRespuestaHttpValidador _respuestaHttpValidador;

        public PublicadorEventosBackgroundServicio(HttpClient httpClient, IRespuestaHttpValidador respuestaHttpValidador)
        {
            _httpClient = httpClient;
            _respuestaHttpValidador = respuestaHttpValidador;
        }

        public async Task<HttpResponseMessage> PublicarActualizacion(string url, string tipoEvento)
        {
            var requestUrl = $"{url}";
            var evento = new ColaSolicitudCreacionRequest();
            evento.Tipo = tipoEvento;

            var respuesta = await _httpClient.PostAsJsonAsync(requestUrl, evento);
            await _respuestaHttpValidador.ValidarRespuesta(respuesta, Textos.Generales.MENSAJE_ERROR_CONSUMO_SERVICIO);

            return respuesta;
        }
    }
}
