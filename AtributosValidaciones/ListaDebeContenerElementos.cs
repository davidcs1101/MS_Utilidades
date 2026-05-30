using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace Utilidades.AtributosValidaciones
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ListaDebeContenerElementos : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? valor,
            ValidationContext validationContext)
        {
            if (valor == null)
                return new ValidationResult(ErrorMessage ?? $"{validationContext.DisplayName} es obligatorio.");

            if (valor is not IEnumerable lista)
                return new ValidationResult("El atributo solo puede aplicarse a colecciones.");

            var enumerador = lista.GetEnumerator();

            if (!enumerador.MoveNext())
            {
                return new ValidationResult(ErrorMessage ??
                    $"{validationContext.DisplayName} debe contener al menos un elemento.");
            }

            return ValidationResult.Success;
        }
    }
}