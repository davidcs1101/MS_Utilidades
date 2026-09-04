using Refit;
using Utilidades.Dtos.Correos;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSEnvioCorreosBackgroundServicio
    {
        [Post("/correos/enviarCorreo")]
        Task<HttpResponseMessage> EnviarCorreoAsync([Body] CorreoCreacionRequest datoCorreoRequest);
    }
}
