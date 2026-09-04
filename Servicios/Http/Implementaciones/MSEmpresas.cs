using Utilidades.Dtos.Empresas;
using Utilidades.Servicios.Http.Interfaces;
using Utilidades.Servicios.Http.Interfaces.Contextos;

namespace Utilidades.Servicios.Http.Implementaciones
{
    public class MSEmpresas : IMSEmpresas
    {
        private readonly IMSEmpresasBackgroundServicio _msEmpresasBackgroundServicio;
        private readonly IServicioEjecutorHttp _servicioComun;

        public MSEmpresas(IMSEmpresasBackgroundServicio msEmpresasBackgroundServicio, IServicioEjecutorHttp servicioComun)
        {
            _servicioComun = servicioComun;
            _msEmpresasBackgroundServicio = msEmpresasBackgroundServicio;
        }

        public async Task<SedeDto> ObtenerSedePorId(int sedeId)
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<int, SedeDto>(
                funcionEjecutar: _msEmpresasBackgroundServicio.ObtenerSedePorIdAsync,
                request: sedeId);
        }

        public async Task<List<SedeDto?>> ListarSedesAsync()
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<List<SedeDto?>>(
                funcionEjecutar: _msEmpresasBackgroundServicio.ListarSedesAsync);
        }


        public async Task<EmpresaDto> ObtenerEmpresaPorId(int empresaId)
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<int, EmpresaDto>(
                funcionEjecutar: _msEmpresasBackgroundServicio.ObtenerEmpresaPorIdAsync,
                request: empresaId);
        }
        public async Task<List<EmpresaDto?>> ListarEmpresasAsync()
        {
            return await _servicioComun.ObtenerRespuestaHttpAsync<List<EmpresaDto?>>(
                funcionEjecutar: _msEmpresasBackgroundServicio.ListarEmpresasAsync);
        }

    }
}
