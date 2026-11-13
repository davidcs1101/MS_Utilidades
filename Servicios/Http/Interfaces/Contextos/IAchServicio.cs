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

        [Post("/psewebapinf/api/CreateTransactionPaymentNF")]
        Task<HttpResponseMessage> CrearTransaccionAsync(
            [AliasAs("apikey")] string apiKey,
            [Header("Authorization")] string authorization,
            [Body] HttpContent contenidoCifrado);

        [Post("/psewebapinf/api/GetTransactionInformationNF")]
        Task<HttpResponseMessage> ConsultarTransaccionAsync(
            [AliasAs("apikey")] string apiKey,
            [Header("Authorization")] string authorization,
            [Body] HttpContent contenidoCifrado);

        [Post("/psewebapinf/api/FinalizeTransactionPaymentNF")]
        Task<HttpResponseMessage> FinalizarTransaccionAsync(
            [AliasAs("apikey")] string apiKey,
            [Header("Authorization")] string authorization,
            [Body] HttpContent contenidoCifrado);
    }
}
