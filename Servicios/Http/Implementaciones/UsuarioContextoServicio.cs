using Microsoft.AspNetCore.Http;
using Utilidades.Seguridad;
using Utilidades.Servicios.Http.Interfaces;

namespace Utilidades.Servicios.Http.Implementaciones
{
    public class UsuarioContextoServicio : IUsuarioContextoServicio
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsuarioContextoServicio(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Int32 ObtenerUsuarioIdToken()
        {
            // Obtener el 'UsuarioId' desde el token JWT en el contexto HTTP
            var usuarioIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(Claims.UsuarioId)?.Value;

            if (string.IsNullOrEmpty(usuarioIdClaim))
                throw new UnauthorizedAccessException(Textos.Generales.MENSAJE_TOKEN_SIN_USUARIOID);

            return Convert.ToInt32(usuarioIdClaim);
        }

        public string ObtenerCodigoGrupo()
        {
            // Obtener el 'CodigoGrupo' desde el token JWT en el contexto HTTP
            var codigoGrupoClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(Claims.CodigoGrupo)?.Value;
            if (string.IsNullOrEmpty(codigoGrupoClaim))
                throw new UnauthorizedAccessException(Textos.Generales.MENSAJE_TOKEN_SIN_GRUPO);

            return codigoGrupoClaim;
        }
    }
}
