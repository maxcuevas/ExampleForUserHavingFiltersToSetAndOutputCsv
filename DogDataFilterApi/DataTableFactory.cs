using DogDataFilterApi.Models;
using DogDataFilterToCsv.Models;
using DogDataFilterToCsv.Models.Generated;
using System.Collections.Generic;
using System.Data;

namespace DogDataFilterApi
{
    class DataTableFactory
    {
        CsvWithDataVersionPropertyValueService csvWithDataVersionPropertyValueService;

        public DataTableFactory(CsvWithDataVersionPropertyValueService csvWithDataVersionPropertyValueService)
        {
            this.csvWithDataVersionPropertyValueService = csvWithDataVersionPropertyValueService;
        }

        public DataTable getDataTable(TableVersion.Value tableVersion, IList<IVersionAgnostic> csvDataList, IList<string> csvColumnNames)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(getDataColumns(csvColumnNames));
            for (int rowCount = 0; rowCount < csvDataList.Count; rowCount++)
            {
                dataTable.Rows.Add(getRow(tableVersion, csvDataList[rowCount], csvColumnNames, dataTable));
            }
            return dataTable;
        }

        private DataRow getRow(TableVersion.Value tableVersion, IVersionAgnostic csvData, IList<string> csvColumnNames, DataTable dataTable)
        {
            var dataRow = dataTable.NewRow();
            if (tableVersion == TableVersion.Value.Version1)
            {
               return getVersion1Row(csvData, csvColumnNames, dataRow);
            }

            return getVersion2Row(csvData, csvColumnNames, dataRow);
        }

        private DataRow getVersion2Row(IVersionAgnostic csvData, IList<string> csvColumnNames, DataRow dataRow)
        {
            for (int columnCount = 0; columnCount < csvColumnNames.Count; columnCount++)
            {
                dataRow[csvColumnNames[columnCount]] = csvWithDataVersionPropertyValueService.version2(csvData, csvColumnNames[columnCount]); 
            }
            return dataRow;
        }

        private DataRow getVersion1Row(IVersionAgnostic csvData, IList<string> csvColumnNames, DataRow dataRow)
        {
            for (int columnCount = 0; columnCount < csvColumnNames.Count; columnCount++)
            {
                dataRow[csvColumnNames[columnCount]] = csvWithDataVersionPropertyValueService.version1(csvData, csvColumnNames[columnCount]);
            }
            return dataRow;
        }

        private DataColumn[] getDataColumns(IList<string> csvColumnNames)
        {
            var dataColumns = new List<DataColumn>();

            foreach (var columnName in csvColumnNames)
            {
                dataColumns.Add(new DataColumn(columnName));
            }

            return dataColumns.ToArray();
        }
    }
}
