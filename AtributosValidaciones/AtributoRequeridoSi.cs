using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Utilidades.AtributosValidaciones
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class AtributoRequeridoSi: ValidationAttribute
    {
        private readonly string _propiedadDependiente;
        private readonly object _valorEvaluar;

        public AtributoRequeridoSi(string propiedadDependiente, object valorEvaluar)
        {
            _propiedadDependiente = propiedadDependiente;
            _valorEvaluar = valorEvaluar;
        }

        protected override ValidationResult? IsValid(object? valor, ValidationContext contextoValidacion)
        {
            PropertyInfo? propiedad = contextoValidacion.ObjectType.GetProperty(_propiedadDependiente);
            if (propiedad == null)
                return new ValidationResult($"No se encontró la propiedad '{_propiedadDependiente}'.");

            object? valorDependiente = propiedad.GetValue(contextoValidacion.ObjectInstance);

            if (object.Equals(valorDependiente, _valorEvaluar))
            {
                if (valor == null || (valor is string str && string.IsNullOrWhiteSpace(str)))
                    return new ValidationResult(ErrorMessage ?? $"{contextoValidacion.DisplayName} es obligatorio.");
            }

            return ValidationResult.Success;
        }
    }
}
