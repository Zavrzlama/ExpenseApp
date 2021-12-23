using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
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
            var builder = new ConfigurationBuilder();
            CreateBuilder(builder);

            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {

            });
            
        }


        private static void CreateBuilder(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).AddEnvironmentVariables();
        }

        /*private static ExcelPackage GetExcelFile()
        {
            return new ExcelPackage(new FileInfo(@"C:\Users\tonism\Downloads\Stanje_tekuci.xlsx"));
        }*/

        /*private static List<ImportModel> GetDataFromSheet(ExcelWorksheet worksheet)
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
        }*/
    }
}
