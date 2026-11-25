namespace Utilidades.Helpers
{
    public static class EnmascaradoHelper
    {
        private const int CaracteresVisibles = 4;
        private const int LongitudMinimaParaMostrarExtremos = 16;
        private const string Mascara = "********";

        /// <summary>
        /// Devuelve el valor con solo el inicio y el final visibles (por ejemplo abcd********wxyz), para poder
        /// reconocerlo sin exponerlo. La máscara tiene longitud fija para no revelar el tamaño real del valor.
        /// Si el valor es corto, mostrar sus extremos revelaría una parte demasiado grande y se oculta por completo.
        /// Devuelve null si no hay valor.
        /// </summary>
        public static string? Enmascarar(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return null;

            if (valor.Length < LongitudMinimaParaMostrarExtremos)
                return Mascara;

            return valor[..CaracteresVisibles] + Mascara + valor[^CaracteresVisibles..];
        }
    }
}
