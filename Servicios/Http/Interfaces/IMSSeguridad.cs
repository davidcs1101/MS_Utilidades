using Utilidades.Dtos;
using Utilidades.Dtos.Seguridad;

namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IMSSeguridad
    {
        Task<List<UsuarioDto>?> ListarUsuarios(IdsListadoDto idsListadoDto);

        Task<List<AutorizacionDto>> ListarCatalogoAutorizacion();
    }
}
