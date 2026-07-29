using Utilidades.Dtos;
namespace Utilidades.Servicios.Responses.Interfaces
{
    public interface IApiResponse
    {
        ApiResponseDto<T> CrearRespuesta<T>(bool correcto, string mensaje, T? data = default);
    }
}
