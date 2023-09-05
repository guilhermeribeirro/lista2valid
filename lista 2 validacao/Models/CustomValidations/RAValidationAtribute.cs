using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

namespace aplicativo_wb_co.Models.CustomValidations
{
    public class RACustomValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string ra = value.ToString();

                // Verifica se o RA começa com "RA" e tem 6 dígitos numéricos a seguir
                if (ra.Length == 8 && ra.StartsWith("RA", StringComparison.OrdinalIgnoreCase) && IsNumeric(ra.Substring(2)))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("O campo RA deve começar com 'RA' seguido de 6 dígitos numéricos.");
        }

        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }
    }
}