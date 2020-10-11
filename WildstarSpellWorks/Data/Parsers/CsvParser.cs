using CsvHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace WildstarSpellWorks.Data.Parsers
{
    public sealed class CSVParser<T>: IDisposable
        where T: class
    {
        private string _FilePath;

        public CSVParser(string filePath)
        {
            _FilePath = filePath;
        }

        public List<T> Parse()
        {
            using(StreamReader sr = new StreamReader(_FilePath)) 
            using(CsvReader csvReader = new CsvReader(sr, CultureInfo.InvariantCulture)) 
            {
                return csvReader.GetRecords<T>().ToList();
            }
        }

        public void Dispose()
        {
            
        }
    }
}
