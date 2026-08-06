namespace Utilidades.Helpers
{
    public static class QueryPaginacionHelper
    {
        public static IQueryable<T> Aplicar<T>(IQueryable<T> query, int pagina, int registrosPorPagina)
        {
            if (pagina <= 0)
                pagina = 1;

            if (registrosPorPagina <= 0)
                registrosPorPagina = 20;

            return query
                .Skip((pagina - 1) * registrosPorPagina)
                .Take(registrosPorPagina);
        }
    }
}
