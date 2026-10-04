namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IUsuarioContextoServicio
    {
        int ObtenerUsuarioIdToken();
        string ObtenerCodigoGrupo();
        int ObtenerEmpresaIdToken();
        int ValidarEmpresaIdToken(int empresaIdBody);
    }
}
