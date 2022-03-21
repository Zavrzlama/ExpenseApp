using ExpensesApp.Application.Models;
using System.Collections.Generic;
using System.IO;

namespace ExpensesImport.DocumentUtils
{
    public class CSVDocument : IDocument
    {

        public IList<ImportModel> GetData(byte[] file)
        {
            var stream = new MemoryStream(file);
            var data = ReadRows(stream);

            return data;
        }

        private IList<ImportModel> ReadRows(Stream stream)
        {
            var importData = new List<ImportModel>();
            var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var model = GetModelFromRow(reader.ReadLine());
                importData.Add(model);
            }
            return importData;
        }

        private ImportModel GetModelFromRow(string row)
        {
            string[] data = row.Split(';');
            return new ImportModel()
            {
                ExpenseDate = data[0],
                Description = data[1],
                Amount = double.Parse(data[2]),
                Account = data[3]
            };
        }
    }
}
