using ExpensesApp.Application.Models;
using System.Collections.Generic;

namespace ExpensesImport.DocumentUtils
{
    public interface IDocument
    {
        IList<ImportModel> GetData(byte[] file);
    }
}
