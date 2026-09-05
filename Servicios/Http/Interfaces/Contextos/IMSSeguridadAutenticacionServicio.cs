using Utilidades.Dtos.Seguridad;
using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSSeguridadAutenticacionServicio
    {
        [Post("/autenticacion/autenticarUsuarioMsIntegracion")]
        Task<HttpResponseMessage> AutenticarUsuarioAsync([Body] AutenticacionRequest AutenticacionRequest);
    }
}
