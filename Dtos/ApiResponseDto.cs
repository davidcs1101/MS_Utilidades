namespace Utilidades.Dtos
{
    public class ApiResponseDto<T>
    {
        public bool Correcto { get; set; }
        public string? Mensaje { get; set; }
        public T? Data { get; set; }
    }
}
