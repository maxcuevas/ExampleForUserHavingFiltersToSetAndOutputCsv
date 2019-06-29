using DogDataFilterApi.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace DogDataFilterApi
{
    public class Api
    {
        DataTableFactory dataTableFactory;
        CsvDataProvider csvDataProvider;
        CsvDataToCsvTransformer csvDataToCsvTransformer;

        public Api()
        {
            dataTableFactory = new DataTableFactory();
            csvDataProvider = new CsvDataProvider();
            csvDataToCsvTransformer = new CsvDataToCsvTransformer();
        }

        public DataTable getDataTable(string searchName, Tail tail, Ear ear, Nose nose,
                             DateAndTime dateAndTime)
        {
            return dataTableFactory.getDataTable(
                getCsvData(searchName, tail, ear, nose, dateAndTime),
                csvDataProvider.getCsvColumnNames());
        }

        public void generateCsv(string fileName, string searchName, Tail tail, Ear ear, Nose nose,
                             DateAndTime dateAndTime)
        {
            csvDataToCsvTransformer.writeDataToCsv(
                getCsvData(searchName, tail, ear, nose, dateAndTime),
                fileName,
                csvDataProvider.getCsvColumnNames());
        }


        private IList<csvWithData> getCsvData(string searchName, Tail tail, Ear ear, Nose nose,
                             DateAndTime dateAndTime)
        {
            return csvDataProvider.getCsvData(searchName, tail, ear, nose,
                             dateAndTime);
        }
    }
}
