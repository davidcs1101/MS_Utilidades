using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Dtos
{
    public class PaginacionRequest
    {
        public int Pagina { get; set; } = 1;
        public int RegistrosPorPagina { get; set; } = 20;
        public string? CampoOrden { get; set; }
        public bool Descendente { get; set; }
    }
}
