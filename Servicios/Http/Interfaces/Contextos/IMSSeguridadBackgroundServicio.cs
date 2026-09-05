using Utilidades.Dtos.Seguridad;
using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSSeguridadBackgroundServicio
    {
        [Get("/permisos/listar")]
        Task<HttpResponseMessage> ListarPermisosAsync();

        [Get("/autorizacion/listarCatalogoAutorizacion")]
        Task<HttpResponseMessage> ListarCatalogoAutorizacionAsync();

        //[Headers("")]
        [Post("/usuarios/registrarConSede")]
        Task<HttpResponseMessage> RegistrarConSedeAsync([Body] UsuarioSedeCreacionRequest usuarioSedeCreacionRequest);
    }
}
