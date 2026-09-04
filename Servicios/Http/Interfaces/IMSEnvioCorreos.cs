using Utilidades.Dtos.Correos;
namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IMSEnvioCorreos
    {
        Task<string> EnviarAsync(CorreoCreacionRequest datoCorreoRequest);
    }
}
