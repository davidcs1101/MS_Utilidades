using Utilidades.Dtos;
using Utilidades.Servicios.Responses.Interfaces;

namespace Utilidades.Servicios.Responses.Implementaciones
{
    public class ApiResponse : IApiResponse
    {
        public ApiResponseDto<T> CrearRespuesta<T>(bool correcto, string mensaje, T? data = default)
        {
            return new ApiResponseDto<T>
            {
                Correcto = correcto,
                Mensaje = mensaje,
                Data = data  // Si data es nulo o no se pasa, se usa default(T)
            };
        }
    }
}
