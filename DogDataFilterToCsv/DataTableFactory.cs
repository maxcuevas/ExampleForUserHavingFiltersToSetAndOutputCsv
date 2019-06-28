using DogDataFilterToCsv.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDataFilterToCsv
{
    class DataTableFactory
    {
        public DataTable getDataTable(IList<csvWithData> csvDataList, IList<string> csvColumnNames)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(getDataColumns(csvColumnNames));

            foreach (var csvRow in csvDataList)
            {
                var dataRow = dataTable.NewRow();

                dataRow["id"] = csvRow.id;
                dataRow["name"] = csvRow.name;
                dataRow["tail_high"] = csvRow.tail_high;
                dataRow["tail_low"] = csvRow.tail_low;
                dataRow["ear_high"] = csvRow.ear_high;
                dataRow["ear_low"] = csvRow.ear_low;
                dataRow["nose_high"] = csvRow.nose_high;
                dataRow["nose_low"] = csvRow.nose_low;
                dataRow["time_stamp"] = csvRow.time_stamp;

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
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
