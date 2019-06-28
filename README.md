# ExampleForUserHavingFiltersToSetAndOutputCsv

This project uses EntityFrameWork, and an MSSQL database.

The data and table that should exist in the database is created from the [csv file](./DogDataFilterToCsv/csvWithData.txt) provided in this repository.

The server name:(localdb)\mssqllocaldb
The database name:createdFromCSV

The connection string can be found in the [App.Config](/DogDataFilterToCsv/App.config) file.

The data from the csv, AKA flat file, can be imported into a MSSQL database through SSMS.


-------------------

This is a simple desktop application that can filter the data in a sql table based on the following:
- Dog's name
- Dog's age less than a certain age
- Dog's age greater than a certain age

The tool can show the proposed rows of data based on the filters the user has provided via a table view on the tool.
As well as create a nameable csv file with the column names as the first row, and the filtered rows followed.

