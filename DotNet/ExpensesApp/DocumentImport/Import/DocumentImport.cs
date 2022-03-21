using ExpensesApp.Application.Models;
using ExpensesImport.DocumentUtils;
using System;
using System.Collections.Generic;

namespace ExpensesImport.Import
{
    public class DocumentImport : IDocumentImport
    {
        public IList<ImportModel> ImportExpenses(string fileExtension, byte[] file)
        {
            if (string.IsNullOrEmpty(fileExtension))
                throw new ArgumentNullException("Parameter fileExtension is required");

            if (file.Length == 0)
                throw new ArgumentNullException("Document is required");

            var document = GetDocument(fileExtension);

            if (document == null)
                throw new ArgumentException("Unsupported document format");

            return document.GetData(file);
        }

        private IDocument GetDocument(string fileExtension)
        {
            if (fileExtension.Equals("csv"))
                return new CSVDocument();

            if (fileExtension.Equals("xlsx"))
                return new ExcelDocument();

            return null;
        }
    }
}
