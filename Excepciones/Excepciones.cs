namespace Utilidades.Excepciones
{
    public class SolicitudHttpException : Exception
    {
        public SolicitudHttpException(string mensaje) : base(mensaje) { }
    }

    public class PermisoNoAutorizadoException : Exception
    {
        public PermisoNoAutorizadoException(string mensaje) : base(mensaje) { }
    }
}
