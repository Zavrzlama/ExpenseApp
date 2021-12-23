using ExcelImport.Models;
using System.Collections.Generic;

namespace ExcelImport.ExcellUtils
{
    public interface IDocumentData
    {
        IList<ImportModel> GetData();
    }
}
