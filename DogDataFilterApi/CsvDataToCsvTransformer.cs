using DogDataFilterApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DogDataFilterApi
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
            var csvDataList = new List<string>
            {
                csvData.id.ToString(),
                csvData.name.ToString(),
                csvData.tail_high.ToString(),
                csvData.tail_low.ToString(),
                csvData.ear_high.ToString(),
                csvData.ear_low.ToString(),
                csvData.nose_high.ToString(),
                csvData.nose_low.ToString(),
                csvData.time_stamp.ToString()
            };
            return String.Join(",", csvDataList);
        }

    }
}
