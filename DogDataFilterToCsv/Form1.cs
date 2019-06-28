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
                getCsvData(csvDataProvider),
                csvDataProvider.getCsvColumnNames());

            TableRowCountTextBox.Text = "Row Count: " + dataGridView1.RowCount.ToString();
        }

        private IList<csvWithData> getCsvData(CsvDataProvider csvDataProvider)
        {
            return csvDataProvider.getCsvData(searchNameTextBox.Text,
                            TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text,
                             TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text,
                             EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text,
                             EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text,
                             NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text,
                             NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text);
        }

        private void generateCsvFileButton_Click(object sender, EventArgs e)
        {
            var csvDataProvider = new CsvDataProvider();
            var csvDataToCsvTransformer = new CsvDataToCsvTransformer();
            csvDataToCsvTransformer.writeDataToCsv(
                getCsvData(csvDataProvider),
                fileNameTextBox.Text,
                csvDataProvider.getCsvColumnNames());
        }
        
    }
}
