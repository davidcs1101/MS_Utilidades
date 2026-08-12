namespace Utilidades.Dtos
{
    public class PaginacionResponse<T>
    {
        public List<T> Registros { get; set; } = [];
        public int TotalRegistros { get; set; }
        public int Pagina { get; set; }
        public int RegistrosPorPagina { get; set; }

        public int TotalPaginas => (int)Math.Ceiling((double)TotalRegistros / RegistrosPorPagina);
    }
}
