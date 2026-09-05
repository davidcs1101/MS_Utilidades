using Utilidades.Dtos.Seguridad;

namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IMSSeguridadAutenticacion
    {
        Task<AutenticacionResponse> AutenticarUsuarioAsync(AutenticacionRequest autenticacionRequest);
    }
}
