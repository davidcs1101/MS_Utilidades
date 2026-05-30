using System.ComponentModel.DataAnnotations;
namespace Utilidades.AtributosValidaciones
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ListaCorreosValidos : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? valor,ValidationContext validationContext)
        {
            if (valor == null)
                return ValidationResult.Success;

            if (valor is not IEnumerable<string> correos)
                return new ValidationResult("El atributo solo puede aplicarse a listas de correos.");

            var validadorCorreo = new EmailAddressAttribute();
            foreach (var correo in correos)
            {
                if (string.IsNullOrWhiteSpace(correo))
                    return new ValidationResult("No se permiten correos vacíos.");

                if (!validadorCorreo.IsValid(correo))
                    return new ValidationResult(
                        $"{ErrorMessage ?? Textos.Generales.VALIDA_CORREO_NO_VALIDO}: {correo}");
            }

            return ValidationResult.Success;
        }
    }
}