using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IAchServicio
    {
        [Post("/psewebapinf/api/GetBankListNF")]
        Task<HttpResponseMessage> ConsultarBancosAsync(
            [AliasAs("apikey")] string apiKey,
            [Header("Authorization")] string authorization,
            [Body] HttpContent contenidoCifrado);
    }
}
