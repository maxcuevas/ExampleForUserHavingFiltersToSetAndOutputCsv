using DogDataFilterToCsv.DataAccessLayer;
using DogDataFilterToCsv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDataFilterToCsv
{
    class CsvDataProvider
    {
        public IList<string> getCsvColumnNames()
        {
            return typeof(csvWithData).GetProperties()
                .Select(x => x.Name)
                .ToList();
        }

        public IList<csvWithData> getCsvData(string searchName, string ageLessThanThis, string ageGreaterThanThis)
        {
            var dbContext = new Model1();
            var builder = new Builder();
            var csvData = dbContext.csvWithDatas.AsQueryable();
            csvData = builder.addNameFilter(csvData, searchName);
            csvData = builder.addAgeLessThanFilter(csvData, ageLessThanThis, ageGreaterThanThis);
            return csvData.ToList();
        }
    }
}
