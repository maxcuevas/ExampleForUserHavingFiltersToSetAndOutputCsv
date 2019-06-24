using DogDataFilterToCsv.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDataFilterToCsv
{
    class CsvDataToCsvTransformer
    {
        public void writeDataToCsv(IList<csvWithData> csvDataList, string fileName, IList<string> columnNames)
        {
            var streamWriter = new StreamWriter(fileName);
            streamWriter.Write(getCsv(csvDataList, columnNames));
            streamWriter.Close();
        }

        public string getCsv(IList<csvWithData> csvDataList, IList<string> columnNames)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Join(",",columnNames));

            foreach (var item in csvDataList)
            {
                stringBuilder.AppendLine(getCsvRow(item));
            }

            return stringBuilder.ToString().TrimEnd(Environment.NewLine.ToCharArray());
        }

        private string getCsvRow(csvWithData csvData)
        {
            var csvDataList = new List<string>();
            csvDataList.Add(csvData.id.ToString());
            csvDataList.Add(csvData.name.ToString());
            csvDataList.Add(csvData.age.ToString());
            return String.Join(",", csvDataList);
        }

    }
}
