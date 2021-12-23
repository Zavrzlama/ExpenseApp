using System.Collections.Generic;
using System.IO;
using ExcelImport.FileUtils;
using ExcelImport.Models;
using OfficeOpenXml;

namespace ExcelImport.ExcellUtils
{
    public class ExcellDocument : IDocumentData{
        private readonly IFileManager _fileManager;

        public ExcellDocument(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public IList<ImportModel> GetData()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var excelDocument = GetExcel(_fileManager.GetFile());
            var data = GetDataFromSheet(excelDocument.Workbook.Worksheets[0]);

            return data;
        }
        /// <summary>
        /// Get excel file from specified location
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns>ExcelPackage</returns>
        private ExcelPackage GetExcel(FileInfo fileInfo)
        {
            return new ExcelPackage(fileInfo);
        }

        /// <summary>
        /// Get data from sheet looping through sheet rows
        /// </summary>
        /// <param name="excelWorksheet"></param>
        /// <returns></returns>
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
