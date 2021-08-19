using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace ExpensesApp.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationErrors { get; set; }

        public ValidationException(ValidationResult validationResult)
        {
            ValidationErrors = new List<string>();

            foreach (var error in validationResult.Errors)
                ValidationErrors.Add(error.ErrorMessage);
        }
    }
}
