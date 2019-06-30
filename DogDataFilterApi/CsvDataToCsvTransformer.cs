using DogDataFilterApi.Models;
using DogDataFilterToCsv.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DogDataFilterApi
{
    class CsvDataToCsvTransformer
    {
        public void writeDataToCsv(TableVersion.Value tableVersion, IList<IVersionAgnostic> csvDataList, string fileName, IList<string> columnNames)
        {
            var streamWriter = new StreamWriter(fileName);
            streamWriter.Write(getCsv(tableVersion,csvDataList, columnNames));
            streamWriter.Close();
        }

        public string getCsv(TableVersion.Value tableVersion,IList<IVersionAgnostic> csvDataList, IList<string> columnNames)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Join(",", columnNames));

            foreach (var item in csvDataList)
            {
                stringBuilder.AppendLine(getCsvRow(tableVersion,item,columnNames));
            }

            return stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private string getCsvRow(TableVersion.Value tableVersion, IVersionAgnostic csvData, IList<string> csvColumnNames)
        {
            if (tableVersion == TableVersion.Value.Version1)
            {
                var csvDataList = new List<string>();
                for (int columnCount = 0; columnCount < csvColumnNames.Count; columnCount++)
                {
                    csvDataList.Add(new csvWithDataVersion1().GetType().GetProperty(csvColumnNames[columnCount]).GetValue((csvWithDataVersion1)csvData, null).ToString());
                }
                return String.Join(",", csvDataList);
            }
            else
            {
                var csvDataList = new List<string>();
                for (int columnCount = 0; columnCount < csvColumnNames.Count; columnCount++)
                {
                    csvDataList.Add(new csvWithDataVersion2().GetType().GetProperty(csvColumnNames[columnCount]).GetValue((csvWithDataVersion2)csvData, null).ToString());
                }
                return String.Join(",", csvDataList);
            }

        }

    }
}
