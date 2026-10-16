using Refit;
using Utilidades.Dtos.Correos;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSEnvioCorreosBackgroundServicio
    {
        [Post("/correos/enviarCorreoEmpresa")]
        Task<HttpResponseMessage> EnviarCorreoEmpresaAsync([Body] CorreoEmpresaCreacionRequest datoCorreoRequest);
    }
}
