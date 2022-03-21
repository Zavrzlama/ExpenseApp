using DocumentImport.Exceptions;
using System;

namespace DocumentImport.DocumentValidator
{
    public static class DocumentFieldValidator
    {

        public static double ValidateNumberField(string field)
        {
            double number;
            if (double.TryParse(field, out number))
            {
                return number;
            }

            throw new DocumentValidationException("Invalid number");
        }

        public static string ValidateRequiredField(string field)
        {
            if (!string.IsNullOrEmpty(field))
            {
                return field;
            }

            throw new DocumentValidationException("Field is required");
        }

        public static DateTime ValidateDateField(string field)
        {
            DateTime date;

            if (DateTime.TryParse(field, out date))
            {
                return date;
            }

            throw new DocumentValidationException("Invalid date format");

        }
    }
}
