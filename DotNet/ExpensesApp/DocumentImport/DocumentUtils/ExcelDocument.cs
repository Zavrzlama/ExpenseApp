using ExpensesApp.Application.Models;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace ExpensesImport.DocumentUtils
{
    public class ExcelDocument : IDocument
    {

        public IList<ImportModel> GetData(byte[] file)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var stream = new MemoryStream(file);
            var excelDocument = GetExcel(stream);
            var data = GetDataFromSheet(excelDocument.Workbook.Worksheets[0]);

            return data;
        }

        private ExcelPackage GetExcel(Stream stream)
        {
            return new ExcelPackage(stream);
        }

        public List<ImportModel> GetDataFromSheet(ExcelWorksheet excelWorksheet)
        {
            var list = new List<ImportModel>();

            for (int i = 2; i < excelWorksheet.Dimension.End.Row; i++)
            {
                var model = GetModelFromRow(excelWorksheet, i);
                list.Add(model);
            }

            return list;
        }

        private ImportModel GetModelFromRow(ExcelWorksheet excelWorksheet, int row)
        {
            var model = new ImportModel();
            model.Account = CellToString(excelWorksheet.Cells[row, 1]);
            model.ExpenseDate = CellToString(excelWorksheet.Cells[row, 2]);
            model.Amount = CellToDouble(excelWorksheet.Cells[row, 3]);
            model.Description = CellToString(excelWorksheet.Cells[row, 4]);

            return model;
        }

        private string CellToString(ExcelRange cell)
        {
            return cell.Value.ToString();
        }

        private double CellToDouble(ExcelRange cell)
        {
            if (cell.Value == null)
            {
                return 0;
            }
            return (double)cell.Value;
        }

    }
}
