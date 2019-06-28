using DogDataFilterToCsv.DataAccessLayer;
using DogDataFilterToCsv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogDataFilterToCsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dataTableFactory = new DataTableFactory();
            var csvDataProvider = new CsvDataProvider();
            dataGridView1.DataSource = dataTableFactory.getDataTable(
                csvDataProvider.getCsvData(searchNameTextBox.Text,TailHighGreaterThanThisTextBox.Text, TailHighLessThanThisTextBox.Text), 
                csvDataProvider.getCsvColumnNames());
        }

        private void generateCsvFileButton_Click(object sender, EventArgs e)
        {
            var csvDataProvider = new CsvDataProvider();
            var csvDataToCsvTransformer = new CsvDataToCsvTransformer();
            csvDataToCsvTransformer.writeDataToCsv(
                csvDataProvider.getCsvData(searchNameTextBox.Text, TailHighGreaterThanThisTextBox.Text,TailHighLessThanThisTextBox.Text), 
                fileNameTextBox.Text, 
                csvDataProvider.getCsvColumnNames());
        }
    }
}
