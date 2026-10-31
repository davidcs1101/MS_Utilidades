using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IWompiServicio
    {
        [Post("/payment_links")]
        Task<HttpResponseMessage> CrearLinkAsync(
            [Header("Authorization")] string authorization, 
            [Body] object request);


        [Get("/transactions/{idTransaccion}")]
        Task<HttpResponseMessage> ConsultarTransaccionAsync(
            [AliasAs("idTransaccion")] string idTransaccion,
            [Header("Authorization")] string authorization);
    }
}
