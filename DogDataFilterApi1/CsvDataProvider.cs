using DogDataFilterApi;
using DogDataFilterApi.Models;
using DogDataFilterApi.Models.Generated;
using DogDataFilterToCsv.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogDataFilterApi
{
    class CsvDataProvider
    {
        public IList<string> getCsvColumnNames(TableVersion.Value tableVersion)
        {
            Type type;

            if (tableVersion == TableVersion.Value.Version1)
            {
                type = typeof(csvWithDataVersion1);
            }
            else
            {
                type = typeof(csvWithDataVersion2);
            }

            return type.
                    GetProperties().
                    Select(x => x.Name).
                    ToList();

        }

        public IList<IVersionAgnostic> getCsvData(TableVersion.Value tableVersion, string searchName, Tail tail, Ear ear, Nose nose,
            DateAndTime dateAndTime, GeoLocationData latitudeData, GeoLocationData longitudeData)
        {
            var dbContext = new Model1();
            var builder = new Builder();

            IQueryable<IVersionAgnostic> csvData = null;

            if (tableVersion == TableVersion.Value.Version1)
            {
                csvData = dbContext.csvWithDataVersion1.AsQueryable();
            }
            else
            {
                csvData = dbContext.csvWithDataVersion2.AsQueryable();
            }

            csvData = builder.addNameFilter(csvData, searchName);
            csvData = builder.tailHighFilter(csvData, tail.highData);
            csvData = builder.tailLowFilter(csvData, tail.lowData);
            csvData = builder.earHighFilter(csvData, ear.highData);
            csvData = builder.earLowFilter(csvData, ear.lowData);
            csvData = builder.noseHighFilter(csvData, nose.highData);
            csvData = builder.noseLowFilter(csvData, nose.lowData);
            csvData = builder.DateFilter(csvData, dateAndTime);
            csvData = builder.LatitudeFilter(csvData, latitudeData );
            csvData = builder.LongitudeFilter(csvData, longitudeData);
            return csvData.ToList();
        }
    }
}
