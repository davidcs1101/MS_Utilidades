namespace Utilidades.Dtos
{
    public class UbicacionCompletaDto
    {
        public Pais Pais { get; set; } = new();
    }

    public class Pais
    {
        public int PaisId { get; set; }
        public string CodigoPais { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
        public string IndicativoPais { get; set; } = null!;
        public bool EstadoPais { get; set; }
        public List<Departamento> Departamentos { get; set; } = new();
    }

    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string CodigoDepartamento { get; set; } = null!;
        public string NombreDepartamento { get; set; } = null!;
        public string IndicativoDepartamento { get; set; } = null!;
        public bool EstadoDepartamento { get; set; }
        public List<Municipio> Municipios { get; set; } = new();
    }

    public class Municipio
    {
        public int MunicipioId { get; set; }
        public string CodigoMunicipio { get; set; } = null!;
        public string NombreMunicipio { get; set; } = null!;
        public bool EstadoMunicipio { get; set; }
    }
}
