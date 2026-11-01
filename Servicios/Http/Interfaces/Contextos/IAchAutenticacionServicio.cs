using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IAchAutenticacionServicio
    {
        [Post("/oauth/client_credential/accesstoken?grant_type=client_credentials")]
        Task<HttpResponseMessage> SolicitarTokenAsync(
            [Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, string> credenciales);
    }
}
