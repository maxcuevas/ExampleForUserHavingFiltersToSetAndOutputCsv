namespace DogDataFilterToCsv
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.ageLessThanThisTextBox = new System.Windows.Forms.TextBox();
            this.ageLessThanThisLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.generateCsvFileButton = new System.Windows.Forms.Button();
            this.ageGreaterThanLabel = new System.Windows.Forms.Label();
            this.ageGreaterThanTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Location = new System.Drawing.Point(58, 29);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(78, 13);
            this.searchNameLabel.TabIndex = 2;
            this.searchNameLabel.Text = "Search Name: ";
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(142, 26);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchNameTextBox.TabIndex = 3;
            // 
            // ageLessThanThisTextBox
            // 
            this.ageLessThanThisTextBox.Location = new System.Drawing.Point(362, 26);
            this.ageLessThanThisTextBox.Name = "ageLessThanThisTextBox";
            this.ageLessThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageLessThanThisTextBox.TabIndex = 4;
            // 
            // ageLessThanThisLabel
            // 
            this.ageLessThanThisLabel.AutoSize = true;
            this.ageLessThanThisLabel.Location = new System.Drawing.Point(248, 29);
            this.ageLessThanThisLabel.Name = "ageLessThanThisLabel";
            this.ageLessThanThisLabel.Size = new System.Drawing.Size(108, 13);
            this.ageLessThanThisLabel.TabIndex = 5;
            this.ageLessThanThisLabel.Text = "Age Less Than This: ";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(63, 397);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "File Name: ";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(129, 394);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameTextBox.TabIndex = 7;
            this.fileNameTextBox.Text = "CsvData.csv";
            // 
            // generateCsvFileButton
            // 
            this.generateCsvFileButton.Location = new System.Drawing.Point(235, 392);
            this.generateCsvFileButton.Name = "generateCsvFileButton";
            this.generateCsvFileButton.Size = new System.Drawing.Size(113, 23);
            this.generateCsvFileButton.TabIndex = 8;
            this.generateCsvFileButton.Text = "Generate Csv File";
            this.generateCsvFileButton.UseVisualStyleBackColor = true;
            this.generateCsvFileButton.Click += new System.EventHandler(this.generateCsvFileButton_Click);
            // 
            // ageGreaterThanLabel
            // 
            this.ageGreaterThanLabel.AutoSize = true;
            this.ageGreaterThanLabel.Location = new System.Drawing.Point(478, 29);
            this.ageGreaterThanLabel.Name = "ageGreaterThanLabel";
            this.ageGreaterThanLabel.Size = new System.Drawing.Size(121, 13);
            this.ageGreaterThanLabel.TabIndex = 9;
            this.ageGreaterThanLabel.Text = "Age Greater Than This: ";
            // 
            // agetGreaterThanTextBox
            // 
            this.ageGreaterThanTextBox.Location = new System.Drawing.Point(605, 26);
            this.ageGreaterThanTextBox.Name = "agetGreaterThanTextBox";
            this.ageGreaterThanTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageGreaterThanTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ageGreaterThanTextBox);
            this.Controls.Add(this.ageGreaterThanLabel);
            this.Controls.Add(this.generateCsvFileButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.ageLessThanThisLabel);
            this.Controls.Add(this.ageLessThanThisTextBox);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.searchNameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.TextBox ageLessThanThisTextBox;
        private System.Windows.Forms.Label ageLessThanThisLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button generateCsvFileButton;
        private System.Windows.Forms.Label ageGreaterThanLabel;
        private System.Windows.Forms.TextBox ageGreaterThanTextBox;
    }
}

