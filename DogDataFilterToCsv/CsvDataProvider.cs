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

        public IList<csvWithData> getCsvData(string searchName, 
            string tailHighLessThanThis, string tailHighGreaterThanThis, 
            string tailLowLessThanThis, string tailLowGreaterThanThis,
            string earHighLessThanThis, string earHighGreaterThanThis,
            string earLowLessThanThis, string earLowGreaterThanThis,
            string noseHighLessThanThis, string noseHighGreaterThanThis,
            string noseLowLessThanThis, string noseLowGreaterThanThis)
        {
            var dbContext = new Model1();
            var builder = new Builder();
            var csvData = dbContext.csvWithDatas.AsQueryable();
            csvData = builder.addNameFilter(csvData, searchName);
            csvData = builder.tailHighFilter(csvData, tailHighLessThanThis, tailHighGreaterThanThis);
            csvData = builder.tailLowFilter(csvData, tailLowLessThanThis, tailLowGreaterThanThis);
            csvData = builder.earHighFilter(csvData, earHighLessThanThis, earHighGreaterThanThis);
            csvData = builder.earLowFilter(csvData, earLowLessThanThis, earLowGreaterThanThis);
            csvData = builder.noseHighFilter(csvData, noseHighLessThanThis, noseHighGreaterThanThis);
            csvData = builder.noseLowFilter(csvData, noseLowLessThanThis, noseLowGreaterThanThis);
            return csvData.ToList();
        }
    }
}
