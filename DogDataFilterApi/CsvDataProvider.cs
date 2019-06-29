using DogDataFilterApi;
using DogDataFilterApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogDataFilterApi
{
    class CsvDataProvider
    {
        public IList<string> getCsvColumnNames()
        {
            return typeof(csvWithData).GetProperties()
                .Select(x => x.Name)
                .ToList();
        }

        public IList<csvWithData> getCsvData(string searchName, Tail tail, Ear ear, Nose nose,
            DateAndTime dateAndTime)
        {
            var dbContext = new Model1();
            var builder = new Builder();
            var csvData = dbContext.csvWithDatas.AsQueryable();
            csvData = builder.addNameFilter(csvData, searchName);
            csvData = builder.tailHighFilter(csvData, tail.highData);
            csvData = builder.tailLowFilter(csvData, tail.lowData);
            csvData = builder.earHighFilter(csvData, ear.highData);
            csvData = builder.earLowFilter(csvData, ear.lowData);
            csvData = builder.noseHighFilter(csvData, nose.highData);
            csvData = builder.noseLowFilter(csvData, nose.lowData);
            csvData = builder.DateFilter(csvData, dateAndTime);
            return csvData.ToList();
        }
    }
}
