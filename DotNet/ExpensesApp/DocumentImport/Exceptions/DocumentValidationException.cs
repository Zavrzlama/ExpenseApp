using System;

namespace DocumentImport.Exceptions
{
    public class DocumentValidationException : Exception
    {
        public DocumentValidationException(string message) : base(message)
        {

        }
    }
}
