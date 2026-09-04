using Utilidades.Dtos.Empresas;
namespace Utilidades.Servicios.Http.Interfaces
{
    public interface IMSEmpresas
    {
        Task<SedeDto> ObtenerSedePorId(int sedeId);
        Task<List<SedeDto?>> ListarSedesAsync();
        Task<EmpresaDto> ObtenerEmpresaPorId(int empresaId);
        Task<List<EmpresaDto?>> ListarEmpresasAsync();
    }
}
