using Utilidades.Dtos.Seguridad;
using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSSeguridadBackgroundServicio
    {
        [Post("/autenticacion/autenticarUsuario")]
        Task<HttpResponseMessage> AutenticarUsuarioAsync([Body] AutenticacionRequest autenticacionRequest);

        [Get("/permisos/listar")]
        Task<HttpResponseMessage> ListarPermisosAsync();
    }
}
