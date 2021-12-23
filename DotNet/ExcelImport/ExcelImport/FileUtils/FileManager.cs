using System.IO;
using System.Threading;
using Microsoft.Extensions.Configuration;

namespace ExcelImport.FileUtils
{
    public class FileManager : IFileManager
    {
        private readonly IConfiguration _configuration;

        public FileManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public FileInfo GetFile()
        {
            string location = _configuration.GetValue<string>("DocumentLocation");
            if (!File.Exists(location))
                throw new FileNotFoundException("File not exists at given location", nameof(location));

            return new FileInfo(location);
        }
    }
}
