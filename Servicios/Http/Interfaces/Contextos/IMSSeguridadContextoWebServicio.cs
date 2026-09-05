using Utilidades.Dtos;
using Refit;

namespace Utilidades.Servicios.Http.Interfaces.Contextos
{
    public interface IMSSeguridadContextoWebServicio
    {
        [Get("/usuarios/obtenerNombreUsuarioPorId")]
        Task<HttpResponseMessage> ObtenerNombreUsuarioPorIdAsync([Query] int id);

        [Post("/usuarios/listar")]
        Task<HttpResponseMessage> ObtenerNombresUsuariosPorIds([Body] IdsListadoDto usuarioIds);
    }
}
