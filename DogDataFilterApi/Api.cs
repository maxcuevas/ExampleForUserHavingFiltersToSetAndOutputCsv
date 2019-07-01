﻿using DogDataFilterApi.Models;
using DogDataFilterToCsv.Models;
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
            dataTableFactory = new DataTableFactory(new CsvWithDataVersionPropertyValueService());
            csvDataProvider = new CsvDataProvider();
            csvDataToCsvTransformer = new CsvDataToCsvTransformer(new CsvWithDataVersionPropertyValueService());
        }

        public DataTable getDataTable(TableVersion.Value tableVersion, string searchName, Tail tail, Ear ear, Nose nose,
                             DateAndTime dateAndTime)
        {
            return dataTableFactory.getDataTable(
                tableVersion,
                getCsvData(tableVersion, searchName, tail, ear, nose, dateAndTime),
                csvDataProvider.getCsvColumnNames(tableVersion));
        }

        public void generateCsv(TableVersion.Value tableVersion, string fileName, string searchName, Tail tail, Ear ear, Nose nose,
                             DateAndTime dateAndTime)
        {
            csvDataToCsvTransformer.writeDataToCsv(
                tableVersion,
                getCsvData(tableVersion, searchName, tail, ear, nose, dateAndTime),
                fileName,
                csvDataProvider.getCsvColumnNames(tableVersion));
        }


        private IList<IVersionAgnostic> getCsvData(TableVersion.Value tableVersion, string searchName, Tail tail, Ear ear, Nose nose,
                             DateAndTime dateAndTime)
        {
            return csvDataProvider.getCsvData(tableVersion, searchName, tail, ear, nose,
                             dateAndTime);
        }
    }
}
