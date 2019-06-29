using DogDataFilterApi.Models;
using System;
using System.Drawing;
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
            getDataGridViewData();
        }

        private void getDataGridViewData()
        {
            var dogDataFilterApi = new DogDataFilterApi.Api();
            dataGridView1.DataSource = dogDataFilterApi.getDataTable(searchNameTextBox.Text,
                            getTailData(),
                            getEarData(),
                            getNoseData(),
                            getDateAndTimeData());
            TableRowCountTextBox.Text = "Row Count: " + dataGridView1.RowCount.ToString();
        }

        private void generateCsvFileButton_Click(object sender, EventArgs e)
        {
            var dogDataFilterApi = new DogDataFilterApi.Api();
            dogDataFilterApi.generateCsv(fileNameTextBox.Text,
                searchNameTextBox.Text,
                getTailData(),
                getEarData(),
                getNoseData(),
                getDateAndTimeData());
        }

        private DateAndTime getDateAndTimeData()
        {
            return new DogDataFilterApi.Models.DateAndTime(DateLessThanThisDatePicker.Value, DateGreaterThanThisDatePicker.Value);
        }

        private Ear getEarData()
        {
            return new DogDataFilterApi.Models.Ear(EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text,
                             EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text);
        }

        private Tail getTailData()
        {
            return new DogDataFilterApi.Models.Tail(TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text,
                             TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text);
        }

        private Nose getNoseData()
        {
            return new DogDataFilterApi.Models.Nose(NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text,
                             NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text);
        }

        private void TailHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(TailHighLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(TailHighLessThanThisTextBox.BackColor));
        }

        private void TailLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(TailLowLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(TailLowLessThanThisTextBox.BackColor));
        }

        private void EarHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarHighLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(EarHighLessThanThisTextBox.BackColor));
        }

        private void EarLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarLowLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(EarLowLessThanThisTextBox.BackColor));
        }

        private void NoseHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseHighLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(NoseHighLessThanThisTextBox.BackColor));
        }

        private void NoseLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseLowLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(NoseLowLessThanThisTextBox.BackColor));
        }

        private void TailHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(TailHighGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(TailHighGreaterThanThisTextBox.BackColor));
        }

        private Color getTextBoxBackGroundColor(string text)
        {
            return !Int32.TryParse(text, out int value)
                  && !String.IsNullOrEmpty(text) ?
              Color.Red :
              Color.White;
        }

        private void TailLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(TailLowGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(TailLowGreaterThanThisTextBox.BackColor));
        }

        private void EarHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarHighGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(EarHighGreaterThanThisTextBox.BackColor));
        }

        private void EarLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarLowGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(EarLowGreaterThanThisTextBox.BackColor));
        }

        private void NoseHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseHighGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(NoseHighGreaterThanThisTextBox.BackColor));
        }

        private void NoseLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseLowGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled(NoseLowGreaterThanThisTextBox.BackColor));
        }

        private void refreshDataGridViewData(bool refresh)
        {
            if (refresh)
            {
                getDataGridViewData();
            }
        }

        private bool isButtonEnabled(Color color)
        {
            bool isEnabled = color == Color.Red ? false : true;
            generateCsvFileButton.Enabled = isEnabled;
            ShowDataButton.Enabled = isEnabled;
            return isEnabled;
        }

        private void searchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            refreshDataGridViewData(true);
        }

        private void DateGreaterThanThisDatePicker_ValueChanged(object sender, EventArgs e)
        {
            refreshDataGridViewData(true);
        }
    }
}
