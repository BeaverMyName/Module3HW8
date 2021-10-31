using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Module3FinalProject.Services.Abstractions;
using Module3FinalProject.Models;
using CsvHelper;
using CsvHelper.Configuration;

namespace Module3FinalProject.Services
{
    public class FileProcessor : IFileProcessor
    {
        private readonly CsvConfiguration _csvConfiguration;

        public FileProcessor()
        {
            _csvConfiguration = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Delimiter = ";"
            };
        }

        public async Task<IEnumerable<User>> ReadUserCollectionAsync(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new NullReferenceException("Path is null or empty!");
            }

            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, _csvConfiguration))
                {
                    return await csvReader.GetRecordsAsync<User>().ToListAsync();
                }
            }
        }

        public async Task<IEnumerable<Order>> ReadOrderCollectionAsync(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new NullReferenceException("Path is null or empty!");
            }

            using (var streamReader = new StreamReader(path))
            {
                using (var csvReader = new CsvReader(streamReader, _csvConfiguration))
                {
                    return await csvReader.GetRecordsAsync<Order>().ToListAsync();
                }
            }
        }

        public async Task WriteCollectionAsync(string path, IEnumerable collection)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new NullReferenceException("Path is null or empty!");
            }

            using (var streamWriter = new StreamWriter(path))
            {
                using (var csvWriter = new CsvWriter(streamWriter, _csvConfiguration))
                {
                    await csvWriter.WriteRecordsAsync(collection);
                }
            }
        }
    }
}
