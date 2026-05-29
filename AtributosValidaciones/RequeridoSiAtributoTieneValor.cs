using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Utilidades.AtributosValidaciones
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class AtributoRequeridoSiTieneValor : ValidationAttribute
    {
        private readonly string _propiedadDependiente;

        public AtributoRequeridoSiTieneValor(string propiedadDependiente)
        {
            _propiedadDependiente = propiedadDependiente;
        }

        protected override ValidationResult? IsValid(object? valor,ValidationContext contextoValidacion)
        {
            var propiedad = contextoValidacion.ObjectType
                .GetProperty(_propiedadDependiente);

            if (propiedad == null)
                return new ValidationResult(
                    $"No existe la propiedad {_propiedadDependiente}");

            var valorDependiente = propiedad.GetValue(contextoValidacion.ObjectInstance);

            bool dependienteTieneValor =
                valorDependiente != null &&
                !(valorDependiente is string strDependiente &&
                  string.IsNullOrWhiteSpace(strDependiente));

            bool valorActualVacio =
                valor == null ||
                (valor is string str &&
                 string.IsNullOrWhiteSpace(str));

            if (dependienteTieneValor && valorActualVacio)
                return new ValidationResult(ErrorMessage ?? 
                    $"{contextoValidacion.DisplayName} es obligatorio.");

            return ValidationResult.Success;
        }
    }
}