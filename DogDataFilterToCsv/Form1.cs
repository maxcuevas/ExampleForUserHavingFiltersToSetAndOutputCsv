using DogDataFilterApi;
using System;
using System.Drawing;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            await refreshDataGridViewData(true);
        }

        private async Task getDataGridViewDataAsync()
        {
            var dogDataFilterApi = new Api();
            var dogDataFilterApiHelperFunctions = new DogDataFilterApiHelperFunctions();
            dataGridView1.DataSource = await Task.Run(() => dogDataFilterApi.getDataTable(dogDataFilterApiHelperFunctions.getTableVersionSelected(version1RadioButton.Checked), searchNameTextBox.Text,
                           dogDataFilterApiHelperFunctions.getTailData(TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text, TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text),
                           dogDataFilterApiHelperFunctions.getEarData(EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text, EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text),
                           dogDataFilterApiHelperFunctions.getNoseData(NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text, NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text),
                           dogDataFilterApiHelperFunctions.getDateAndTimeData(DateLessThanThisDatePicker.Value, DateGreaterThanThisDatePicker.Value),
                           dogDataFilterApiHelperFunctions.getLatitudeData(latitudeTextBox.Text, distanceFromLatitudeTextBox.Text),
                           dogDataFilterApiHelperFunctions.getLongitudeData(longitudeTextBox.Text, distanceFromLongitudeTextBox.Text)));
            TableRowCountTextBox.Text = "Row Count: " + dataGridView1.RowCount.ToString();
        }

        private void generateCsvFileButton_Click(object sender, EventArgs e)
        {
            var dogDataFilterApi = new Api();
            const string versionString = "_Version";
            const string extension = ".csv";

            var dofDataFilterApiHelperFunctions = new DogDataFilterApiHelperFunctions();

            dogDataFilterApi.generateCsv(TableVersion.Value.Version1, fileNameTextBox.Text + versionString + "1" + extension,
                searchNameTextBox.Text,
                dofDataFilterApiHelperFunctions.getTailData(TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text, TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text),
                dofDataFilterApiHelperFunctions.getEarData(EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text, EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text),
                dofDataFilterApiHelperFunctions.getNoseData(NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text, NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text),
                dofDataFilterApiHelperFunctions.getDateAndTimeData(DateLessThanThisDatePicker.Value, DateGreaterThanThisDatePicker.Value),
                dofDataFilterApiHelperFunctions.getLatitudeData(latitudeTextBox.Text, distanceFromLatitudeTextBox.Text),
                dofDataFilterApiHelperFunctions.getLongitudeData(longitudeTextBox.Text, distanceFromLongitudeTextBox.Text));

            dogDataFilterApi.generateCsv(TableVersion.Value.Version2, fileNameTextBox.Text + versionString + "2" + extension,
                searchNameTextBox.Text,
                dofDataFilterApiHelperFunctions.getTailData(TailHighLessThanThisTextBox.Text, TailHighGreaterThanThisTextBox.Text, TailLowLessThanThisTextBox.Text, TailLowGreaterThanThisTextBox.Text),
                dofDataFilterApiHelperFunctions.getEarData(EarHighLessThanThisTextBox.Text, EarHighGreaterThanThisTextBox.Text, EarLowLessThanThisTextBox.Text, EarLowGreaterThanThisTextBox.Text),
                dofDataFilterApiHelperFunctions.getNoseData(NoseHighLessThanThisTextBox.Text, NoseHighGreaterThanThisTextBox.Text, NoseLowLessThanThisTextBox.Text, NoseLowGreaterThanThisTextBox.Text),
                dofDataFilterApiHelperFunctions.getDateAndTimeData(DateLessThanThisDatePicker.Value, DateGreaterThanThisDatePicker.Value),
                dofDataFilterApiHelperFunctions.getLatitudeData(latitudeTextBox.Text, distanceFromLatitudeTextBox.Text),
                dofDataFilterApiHelperFunctions.getLongitudeData(longitudeTextBox.Text, distanceFromLongitudeTextBox.Text));
        }

        private async void TailHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailHighLessThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void TailLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailLowLessThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void EarHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarHighLessThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void EarLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarLowLessThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void NoseHighLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseHighLessThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void NoseLowLessThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowLessThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseLowLessThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void TailHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailHighGreaterThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
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

        private async void TailLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            TailLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(TailLowGreaterThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void EarHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarHighGreaterThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void EarLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            EarLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(EarLowGreaterThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void NoseHighGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseHighGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseHighGreaterThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void NoseLowGreaterThanThisTextBox_TextChanged(object sender, EventArgs e)
        {
            NoseLowGreaterThanThisTextBox.BackColor = getTextBoxBackGroundColorForInt(NoseLowGreaterThanThisTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async Task refreshDataGridViewData(bool refresh)
        {
            if (refresh)
            {
                await getDataGridViewDataAsync();
            }
        }

        private bool isButtonEnabled()
        {
            bool isEnabled = doAllTextBoxesHaveValidData();
            generateCsvFileButton.Enabled = isEnabled;
            ShowDataButton.Enabled = isEnabled;
            return isEnabled;
        }

        private async void searchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            await refreshDataGridViewData(true);
        }

        private async void DateGreaterThanThisDatePicker_ValueChanged(object sender, EventArgs e)
        {
            await refreshDataGridViewData(true);
        }

        private async void version2RadioButton_Click(object sender, EventArgs e)
        {
            await refreshDataGridViewData(true);
        }

        private async void version1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            await refreshDataGridViewData(true);
        }

        private async void latitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            latitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(latitudeTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void longitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            longitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(longitudeTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void distanceFromLatitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            distanceFromLatitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(distanceFromLatitudeTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
        }

        private async void distanceFromLongitudeTextBox_TextChanged(object sender, EventArgs e)
        {
            distanceFromLongitudeTextBox.BackColor = getTextBoxBackGroundColorForDouble(distanceFromLongitudeTextBox.Text);
            await refreshDataGridViewData(isButtonEnabled());
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
