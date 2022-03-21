using ExpensesApp.Application.Models;
using System.Collections.Generic;

namespace ExpensesImport.Import
{
    public interface IDocumentImport
    {
        IList<ImportModel> ImportExpenses(string fileExtension, byte[] file);
    }
}
