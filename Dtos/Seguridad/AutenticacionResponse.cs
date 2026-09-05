namespace Utilidades.Dtos.Seguridad
{
    public class AutenticacionResponse
    {
        public string Token { get; set; } = null!;
        public DateTime FechaExpiracion { get; set; }
    }
}
