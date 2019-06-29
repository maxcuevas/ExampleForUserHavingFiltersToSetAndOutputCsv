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

        private void TailHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(TailHighLessThanThisTextBox.Text);
            setButtonEnableState(TailHighLessThanThisTextBox.BackColor);
        }

        private void TailLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(TailLowLessThanThisTextBox.Text);
            setButtonEnableState(TailLowLessThanThisTextBox.BackColor);
        }

        private void EarHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarHighLessThanThisTextBox.Text);
            setButtonEnableState(EarHighLessThanThisTextBox.BackColor);
        }

        private void EarLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarLowLessThanThisTextBox.Text);
            setButtonEnableState(EarLowLessThanThisTextBox.BackColor);
        }

        private void NoseHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseHighLessThanThisTextBox.Text);
            setButtonEnableState(NoseHighLessThanThisTextBox.BackColor);
        }

        private void NoseLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseLowLessThanThisTextBox.Text);
            setButtonEnableState(NoseLowLessThanThisTextBox.BackColor);
        }

        private void TailHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(TailHighGreaterThanThisTextBox.Text);
            setButtonEnableState(TailHighGreaterThanThisTextBox.BackColor);
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
            setButtonEnableState(TailLowGreaterThanThisTextBox.BackColor);
        }

        private void EarHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarHighGreaterThanThisTextBox.Text);
            setButtonEnableState(EarHighGreaterThanThisTextBox.BackColor);
        }

        private void EarLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(EarLowGreaterThanThisTextBox.Text);
            setButtonEnableState(EarLowGreaterThanThisTextBox.BackColor);
        }

        private void NoseHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseHighGreaterThanThisTextBox.Text);
            setButtonEnableState(NoseHighGreaterThanThisTextBox.BackColor);
        }

        private void NoseLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColor(NoseLowGreaterThanThisTextBox.Text);
            setButtonEnableState(NoseLowGreaterThanThisTextBox.BackColor);
        }

        private void setButtonEnableState(Color color)
        {
            generateCsvFileButton.Enabled = color == Color.Red ? false : true;
            ShowDataButton.Enabled = color == Color.Red ? false : true;
        }
    }
}
