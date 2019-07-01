using DogDataFilterToCsv.Models;
using DogDataFilterToCsv.Models.Generated;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogDataFilterApi
{
    class CsvWithDataVersionPropertyValueService
    {
        public object version2(IVersionAgnostic csvData, string csvColumnName)
        {
            return new csvWithDataVersion2().GetType().GetProperty(csvColumnName).GetValue((csvWithDataVersion2)csvData, null);
        }

        public object version1(IVersionAgnostic csvData, string csvColumnName)
        {
            return new csvWithDataVersion1().GetType().GetProperty(csvColumnName).GetValue((csvWithDataVersion1)csvData, null);
        }
    }
}
