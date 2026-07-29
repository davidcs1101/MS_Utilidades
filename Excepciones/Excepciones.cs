namespace Utilidades.Excepciones
{
    public class SolicitudHttpException : Exception
    {
        public SolicitudHttpException(string mensaje) : base(mensaje) { }
    }
}
