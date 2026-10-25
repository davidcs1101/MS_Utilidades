using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IWompiServicio
    {
        [Post("/payment_links")]
        Task<HttpResponseMessage> CrearLinkAsync([Header("Authorization")] string authorization,[Body] object request);
    }
}
