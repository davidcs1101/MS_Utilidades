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

        public int ObtenerUsuarioIdToken()
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

        public int ObtenerEmpresaIdToken()
        {
            // Obtener el 'EmpresaId' desde el token JWT en el contexto HTTP
            var empresaIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("EmpresaId")?.Value;

            if (string.IsNullOrEmpty(empresaIdClaim))
                throw new UnauthorizedAccessException("No se encontró el 'EmpresaId' en el token JWT.");
            return Convert.ToInt32(empresaIdClaim);
        }

        /// <summary>
        /// Obtiene el 'EmpresaId' desde el token JWT y lo compara con el 'EmpresaId' proporcionado en el request.
        /// Si el 'EmpresaId' en el token es 1                                                -> entonces el usuario administrador es quien está haciendo el proceso.
        /// Si el 'EmpresaId' en el token es igual al 'EmpresaId' proporcionado en el request -> entonces el usuario pertenece a la empresa y puede hacer el proceso.
        /// </summary>
        /// <param name="empresaIdBody"></param>
        /// <returns></returns>
        /// <exception cref="UnauthorizedAccessException"></exception>
        public int ValidarEmpresaIdToken(int empresaIdBody)
        {
            var empresaIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst("EmpresaId")?.Value;

            if (string.IsNullOrWhiteSpace(empresaIdClaim))
                throw new UnauthorizedAccessException(
                    "No se encontró la 'EmpresaId' en el token JWT.");

            var empresaIdToken = Convert.ToInt32(empresaIdClaim);

            // EmpresaId del Usuario administrador/integración
            if (empresaIdToken == 1)
                return empresaIdBody;

            // EmpresaId del Usuario de empresa
            if (empresaIdToken == empresaIdBody)
                return empresaIdBody;

            throw new UnauthorizedAccessException(
                "El 'EmpresaId' en el token JWT no coincide con el 'EmpresaId' proporcionado en el request.");
        }
    }
}
