using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using OfficeOpenXml;

namespace ExcelImport
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=0000;Database=postgres";

            var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            List<ImportModel> models = new List<ImportModel>();
            Dictionary<string, string> jsons = new Dictionary<string, string>();
            var excelDoc = GetExcelFile();

            foreach (var worksheet in excelDoc.Workbook.Worksheets.Where(x => x.Name != "Balance" && x.Name != "Stanje")
            )
            {
                string json = string.Empty;
                for (int i = 1; i < worksheet.Dimension.End.Row; i++)
                    json = JsonConvert.SerializeObject(GetDataFromSheet(worksheet));

                jsons.Add(worksheet.Name, json);
            }

            foreach (var json in jsons)
            {
                using (var cmd = new NpgsqlCommand("CALL ImportData_Insert(@p1,@p2)", conn))
                {
                    cmd.Parameters.AddWithValue("p1", NpgsqlDbType.Varchar, json.Key);
                    cmd.Parameters.AddWithValue("p2", NpgsqlDbType.Json, json.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private static ExcelPackage GetExcelFile()
        {
            return new ExcelPackage(new FileInfo(@"C:\Users\tonism\Downloads\Stanje_tekuci.xlsx"));
        }

        private static List<ImportModel> GetDataFromSheet(ExcelWorksheet worksheet)
        {
            List<ImportModel> list = new List<ImportModel>();
            for (int i = 2; i < worksheet.Dimension.End.Row; i++)
            {
                if (worksheet.Cells[i, 1].Value == null)
                    break;
                
                ImportModel model = new ImportModel();
                model.ExpenseDate = worksheet.Cells[i, 1].Value.ToString();
                model.Amount = worksheet.Cells[i, 2].Value == null ? 0 : (double)worksheet.Cells[i, 2].Value;
                model.Account = "Edisa";
                list.Add(model);

                model = new ImportModel();
                model.ExpenseDate = worksheet.Cells[i, 1].Value.ToString();
                model.Amount = worksheet.Cells[i, 3].Value == null ? 0 : (double)worksheet.Cells[i, 3].Value;
                model.Account = "Toni";
                list.Add(model);

            }

            return list;
        }
    }
}
