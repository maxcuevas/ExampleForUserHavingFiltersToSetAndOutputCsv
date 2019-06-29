using System;
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
            var dogDataFilterApi = new DogDataFilterApi.Api();
            var noseData = new DogDataFilterApi.Models.Nose(NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text,
                             NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text);
            var tailData = new DogDataFilterApi.Models.Tail(TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text,
                             TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text);
            var earData = new DogDataFilterApi.Models.Ear(EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text,
                             EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text);
            var dateAndTimeData = new DogDataFilterApi.Models.DateAndTime(DateLessThanThisDatePicker.Value, DateGreaterThanThisDatePicker.Value);

            dataGridView1.DataSource = dogDataFilterApi.getDataTable(searchNameTextBox.Text,
                            tailData, earData, noseData, dateAndTimeData);

            TableRowCountTextBox.Text = "Row Count: " + dataGridView1.RowCount.ToString();
        }

        private void generateCsvFileButton_Click(object sender, EventArgs e)
        {
            var dogDataFilterApi = new DogDataFilterApi.Api();
            var noseData = new DogDataFilterApi.Models.Nose(NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text,
                             NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text);
            var tailData = new DogDataFilterApi.Models.Tail(TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text,
                             TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text);
            var earData = new DogDataFilterApi.Models.Ear(EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text,
                             EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text);
            var dateAndTimeData = new DogDataFilterApi.Models.DateAndTime(DateLessThanThisDatePicker.Value, DateGreaterThanThisDatePicker.Value);

            dogDataFilterApi.generateCsv(fileNameTextBox.Text, searchNameTextBox.Text, tailData, earData, noseData, dateAndTimeData);
        }

    }
}
