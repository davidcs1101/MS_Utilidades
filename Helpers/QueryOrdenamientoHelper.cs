using System.Linq.Expressions;
namespace Utilidades.Helpers
{
    public static class QueryOrdenamientoHelper
    {
        public static IQueryable<T> Aplicar<T>(
            IQueryable<T> query,
            string? campoOrden,
            bool descendente,
            IReadOnlyDictionary<string, Expression<Func<T, object>>> columnas)
        {
            if (columnas.Count == 0)
                return query;

            if (string.IsNullOrWhiteSpace(campoOrden))
            {
                var primera = columnas.First().Value;

                return descendente
                    ? query.OrderByDescending(primera)
                    : query.OrderBy(primera);
            }

            if (!columnas.TryGetValue(campoOrden, out var expresion))
            {
                expresion = columnas.First().Value;
            }

            return descendente
                ? query.OrderByDescending(expresion)
                : query.OrderBy(expresion);
        }
    }
}
