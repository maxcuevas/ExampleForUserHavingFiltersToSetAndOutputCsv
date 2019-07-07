using DogDataFilterApi;
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
            var dogDataFilterApi = new Api();
            dataGridView1.DataSource = dogDataFilterApi.getDataTable(getTableVersionSelected(), searchNameTextBox.Text,
                            getTailData(),
                            getEarData(),
                            getNoseData(),
                            getDateAndTimeData(),
                            getLatitudeData(),
                            getLongitudeData());
            TableRowCountTextBox.Text = "Row Count: " + dataGridView1.RowCount.ToString();
        }

        private GeoLocationData getLongitudeData()
        {
            return new GeoLocationData(longitudeTextBox.Text, distanceFromLongitudeTextBox.Text);
        }

        private GeoLocationData getLatitudeData()
        {
            return new GeoLocationData(latitudeTextBox.Text, distanceFromLatitudeTextBox.Text);
        }

        private TableVersion.Value getTableVersionSelected()
        {
            return version1RadioButton.Checked ? TableVersion.Value.Version1 : TableVersion.Value.Version2;
        }

        private void generateCsvFileButton_Click(object sender, EventArgs e)
        {
            var dogDataFilterApi = new Api();
            const string versionString = "_Version";
            const string extension = ".csv";

            dogDataFilterApi.generateCsv(TableVersion.Value.Version1, fileNameTextBox.Text + versionString + "1" + extension,
                searchNameTextBox.Text,
                getTailData(),
                getEarData(),
                getNoseData(),
                getDateAndTimeData(),
                getLatitudeData(),
                getLongitudeData());

            dogDataFilterApi.generateCsv(TableVersion.Value.Version2, fileNameTextBox.Text + versionString + "2" + extension,
                searchNameTextBox.Text,
                getTailData(),
                getEarData(),
                getNoseData(),
                getDateAndTimeData(),
                getLatitudeData(),
                getLongitudeData());
        }

        private DateAndTime getDateAndTimeData()
        {
            return new DateAndTime(DateLessThanThisDatePicker.Value, DateGreaterThanThisDatePicker.Value);
        }

        private Ear getEarData()
        {
            return new Ear(EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text,
                             EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text);
        }

        private Tail getTailData()
        {
            return new Tail(TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text,
                             TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text);
        }

        private Nose getNoseData()
        {
            return new Nose(NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text,
                             NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text);
        }

        private void TailHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailHighLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void TailLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailLowLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void EarHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarHighLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void EarLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarLowLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void NoseHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseHighLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void NoseLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseLowLessThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void TailHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailHighGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private Color getTextBoxBackGroundColorForInt(string text)
        {
            return !Int32.TryParse(text, out int value)
                  && !String.IsNullOrEmpty(text) ?
              Color.Red :
              Color.White;
        }

        private Color getTextBoxBackGroundColorForDouble(string text)
        {
            return !Double.TryParse(text, out double value)
                  && !String.IsNullOrEmpty(text) ?
              Color.Red :
              Color.White;
        }

        private void TailLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailLowGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void EarHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarHighGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void EarLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarLowGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void NoseHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseHighGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void NoseLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseLowGreaterThanThisTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void refreshDataGridViewData(bool refresh)
        {
            if (refresh)
            {
                getDataGridViewData();
            }
        }

        private bool isButtonEnabled()
        {
            bool isEnabled = doAllTextBoxesHaveValidData();
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

        private void version2RadioButton_Click(object sender, EventArgs e)
        {
            refreshDataGridViewData(true);
        }

        private void version1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            refreshDataGridViewData(true);
        }

        private void latitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            latitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(latitudeTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void longitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            longitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(longitudeTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void distanceFromLatitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            distanceFromLatitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(distanceFromLatitudeTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private void distanceFromLongitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            distanceFromLongitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(distanceFromLongitudeTextBox.Text);
            refreshDataGridViewData(isButtonEnabled());
        }

        private bool isValidTextBoxColor(Color color)
        {
            return color == Color.Red ? false : true;
        }

        private bool doAllTextBoxesHaveValidData()
        {
            bool isTrue = isValidTextBoxColor(searchNameTextBox.BackColor);
            isTrue &= isValidTextBoxColor(TailHighGreaterThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(TailHighLessThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(TailLowGreaterThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(TailLowLessThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(EarHighGreaterThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(EarHighLessThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(EarLowGreaterThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(EarLowLessThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(NoseHighGreaterThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(NoseHighLessThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(NoseLowGreaterThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(NoseLowLessThanThisTextBox.BackColor);
            isTrue &= isValidTextBoxColor(latitudeTextBox.BackColor);
            isTrue &= isValidTextBoxColor(distanceFromLatitudeTextBox.BackColor);
            isTrue &= isValidTextBoxColor(longitudeTextBox.BackColor);
            isTrue &= isValidTextBoxColor(distanceFromLongitudeTextBox.BackColor);

            return isTrue;
        }
    }
}
