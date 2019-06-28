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
            this.TailHighGreaterThanThisTextBox = new System.Windows.Forms.TextBox();
            this.TailHighGreaterThanThisLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.generateCsvFileButton = new System.Windows.Forms.Button();
            this.TailHighLessThanThisLabel = new System.Windows.Forms.Label();
            this.TailHighLessThanThisTextBox = new System.Windows.Forms.TextBox();
            this.TailLowLessThanThisTextBox = new System.Windows.Forms.TextBox();
            this.TailLowLessThanThisLabel = new System.Windows.Forms.Label();
            this.TailLowGreaterThanThisLabel = new System.Windows.Forms.Label();
            this.TailLowGreaterThanThisTextBox = new System.Windows.Forms.TextBox();
            this.EarHighLessThanThisTextBox = new System.Windows.Forms.TextBox();
            this.EarHighLessThanThisLabel = new System.Windows.Forms.Label();
            this.EarHighGreaterThanThisLabel = new System.Windows.Forms.Label();
            this.EarHighGreaterThanThisTextBox = new System.Windows.Forms.TextBox();
            this.EarLowLessThanThisTextBox = new System.Windows.Forms.TextBox();
            this.EarLowLessThanThisLabel = new System.Windows.Forms.Label();
            this.EarLowGreaterThanThisLabel = new System.Windows.Forms.Label();
            this.EarLowGreaterThanThisTextBox = new System.Windows.Forms.TextBox();
            this.NoseHighLessThanThisTextBox = new System.Windows.Forms.TextBox();
            this.NoseHighLessThanThisLabel = new System.Windows.Forms.Label();
            this.NoseHighGreaterThanThisLabel = new System.Windows.Forms.Label();
            this.NoseHighGreaterThanThisTextBox = new System.Windows.Forms.TextBox();
            this.NoseLowLessThanThisTextBox = new System.Windows.Forms.TextBox();
            this.NoseLowLessThanThisLabel = new System.Windows.Forms.Label();
            this.NoseLowGreaterThanThisLabel = new System.Windows.Forms.Label();
            this.NoseLowGreaterThanThisTextBox = new System.Windows.Forms.TextBox();
            this.DateLessThanThisLabel = new System.Windows.Forms.Label();
            this.DateGreaterThanThisLabel = new System.Windows.Forms.Label();
            this.DateGreaterThanThisDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLessThanThisDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TableRowCountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(536, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(669, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1130, 360);
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
            this.searchNameLabel.Location = new System.Drawing.Point(537, 9);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(78, 13);
            this.searchNameLabel.TabIndex = 2;
            this.searchNameLabel.Text = "Search Name: ";
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(621, 6);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchNameTextBox.TabIndex = 3;
            // 
            // TailHighGreaterThanThisTextBox
            // 
            this.TailHighGreaterThanThisTextBox.Location = new System.Drawing.Point(164, 32);
            this.TailHighGreaterThanThisTextBox.Name = "TailHighGreaterThanThisTextBox";
            this.TailHighGreaterThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.TailHighGreaterThanThisTextBox.TabIndex = 4;
            // 
            // TailHighGreaterThanThisLabel
            // 
            this.TailHighGreaterThanThisLabel.AutoSize = true;
            this.TailHighGreaterThanThisLabel.Location = new System.Drawing.Point(6, 35);
            this.TailHighGreaterThanThisLabel.Name = "TailHighGreaterThanThisLabel";
            this.TailHighGreaterThanThisLabel.Size = new System.Drawing.Size(144, 13);
            this.TailHighGreaterThanThisLabel.TabIndex = 5;
            this.TailHighGreaterThanThisLabel.Text = "Tail High Greater Than This: ";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(534, 365);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(60, 13);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "File Name: ";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileNameTextBox.Location = new System.Drawing.Point(600, 362);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameTextBox.TabIndex = 7;
            this.fileNameTextBox.Text = "CsvData.csv";
            // 
            // generateCsvFileButton
            // 
            this.generateCsvFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateCsvFileButton.Location = new System.Drawing.Point(706, 360);
            this.generateCsvFileButton.Name = "generateCsvFileButton";
            this.generateCsvFileButton.Size = new System.Drawing.Size(113, 23);
            this.generateCsvFileButton.TabIndex = 8;
            this.generateCsvFileButton.Text = "Generate Csv File";
            this.generateCsvFileButton.UseVisualStyleBackColor = true;
            this.generateCsvFileButton.Click += new System.EventHandler(this.generateCsvFileButton_Click);
            // 
            // TailHighLessThanThisLabel
            // 
            this.TailHighLessThanThisLabel.AutoSize = true;
            this.TailHighLessThanThisLabel.Location = new System.Drawing.Point(270, 35);
            this.TailHighLessThanThisLabel.Name = "TailHighLessThanThisLabel";
            this.TailHighLessThanThisLabel.Size = new System.Drawing.Size(131, 13);
            this.TailHighLessThanThisLabel.TabIndex = 9;
            this.TailHighLessThanThisLabel.Text = "Tail High Less Than This: ";
            // 
            // TailHighLessThanThisTextBox
            // 
            this.TailHighLessThanThisTextBox.Location = new System.Drawing.Point(415, 32);
            this.TailHighLessThanThisTextBox.Name = "TailHighLessThanThisTextBox";
            this.TailHighLessThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.TailHighLessThanThisTextBox.TabIndex = 10;
            // 
            // TailLowLessThanThisTextBox
            // 
            this.TailLowLessThanThisTextBox.Location = new System.Drawing.Point(415, 58);
            this.TailLowLessThanThisTextBox.Name = "TailLowLessThanThisTextBox";
            this.TailLowLessThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.TailLowLessThanThisTextBox.TabIndex = 14;
            // 
            // TailLowLessThanThisLabel
            // 
            this.TailLowLessThanThisLabel.AutoSize = true;
            this.TailLowLessThanThisLabel.Location = new System.Drawing.Point(270, 61);
            this.TailLowLessThanThisLabel.Name = "TailLowLessThanThisLabel";
            this.TailLowLessThanThisLabel.Size = new System.Drawing.Size(129, 13);
            this.TailLowLessThanThisLabel.TabIndex = 13;
            this.TailLowLessThanThisLabel.Text = "Tail Low Less Than This: ";
            // 
            // TailLowGreaterThanThisLabel
            // 
            this.TailLowGreaterThanThisLabel.AutoSize = true;
            this.TailLowGreaterThanThisLabel.Location = new System.Drawing.Point(6, 61);
            this.TailLowGreaterThanThisLabel.Name = "TailLowGreaterThanThisLabel";
            this.TailLowGreaterThanThisLabel.Size = new System.Drawing.Size(142, 13);
            this.TailLowGreaterThanThisLabel.TabIndex = 12;
            this.TailLowGreaterThanThisLabel.Text = "Tail Low Greater Than This: ";
            // 
            // TailLowGreaterThanThisTextBox
            // 
            this.TailLowGreaterThanThisTextBox.Location = new System.Drawing.Point(164, 58);
            this.TailLowGreaterThanThisTextBox.Name = "TailLowGreaterThanThisTextBox";
            this.TailLowGreaterThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.TailLowGreaterThanThisTextBox.TabIndex = 11;
            // 
            // EarHighLessThanThisTextBox
            // 
            this.EarHighLessThanThisTextBox.Location = new System.Drawing.Point(415, 84);
            this.EarHighLessThanThisTextBox.Name = "EarHighLessThanThisTextBox";
            this.EarHighLessThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.EarHighLessThanThisTextBox.TabIndex = 18;
            // 
            // EarHighLessThanThisLabel
            // 
            this.EarHighLessThanThisLabel.AutoSize = true;
            this.EarHighLessThanThisLabel.Location = new System.Drawing.Point(270, 87);
            this.EarHighLessThanThisLabel.Name = "EarHighLessThanThisLabel";
            this.EarHighLessThanThisLabel.Size = new System.Drawing.Size(130, 13);
            this.EarHighLessThanThisLabel.TabIndex = 17;
            this.EarHighLessThanThisLabel.Text = "Ear High Less Than This: ";
            // 
            // EarHighGreaterThanThisLabel
            // 
            this.EarHighGreaterThanThisLabel.AutoSize = true;
            this.EarHighGreaterThanThisLabel.Location = new System.Drawing.Point(6, 87);
            this.EarHighGreaterThanThisLabel.Name = "EarHighGreaterThanThisLabel";
            this.EarHighGreaterThanThisLabel.Size = new System.Drawing.Size(143, 13);
            this.EarHighGreaterThanThisLabel.TabIndex = 16;
            this.EarHighGreaterThanThisLabel.Text = "Ear High Greater Than This: ";
            // 
            // EarHighGreaterThanThisTextBox
            // 
            this.EarHighGreaterThanThisTextBox.Location = new System.Drawing.Point(164, 84);
            this.EarHighGreaterThanThisTextBox.Name = "EarHighGreaterThanThisTextBox";
            this.EarHighGreaterThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.EarHighGreaterThanThisTextBox.TabIndex = 15;
            // 
            // EarLowLessThanThisTextBox
            // 
            this.EarLowLessThanThisTextBox.Location = new System.Drawing.Point(415, 110);
            this.EarLowLessThanThisTextBox.Name = "EarLowLessThanThisTextBox";
            this.EarLowLessThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.EarLowLessThanThisTextBox.TabIndex = 22;
            // 
            // EarLowLessThanThisLabel
            // 
            this.EarLowLessThanThisLabel.AutoSize = true;
            this.EarLowLessThanThisLabel.Location = new System.Drawing.Point(270, 113);
            this.EarLowLessThanThisLabel.Name = "EarLowLessThanThisLabel";
            this.EarLowLessThanThisLabel.Size = new System.Drawing.Size(128, 13);
            this.EarLowLessThanThisLabel.TabIndex = 21;
            this.EarLowLessThanThisLabel.Text = "Ear Low Less Than This: ";
            // 
            // EarLowGreaterThanThisLabel
            // 
            this.EarLowGreaterThanThisLabel.AutoSize = true;
            this.EarLowGreaterThanThisLabel.Location = new System.Drawing.Point(6, 113);
            this.EarLowGreaterThanThisLabel.Name = "EarLowGreaterThanThisLabel";
            this.EarLowGreaterThanThisLabel.Size = new System.Drawing.Size(141, 13);
            this.EarLowGreaterThanThisLabel.TabIndex = 20;
            this.EarLowGreaterThanThisLabel.Text = "Ear Low Greater Than This: ";
            // 
            // EarLowGreaterThanThisTextBox
            // 
            this.EarLowGreaterThanThisTextBox.Location = new System.Drawing.Point(164, 110);
            this.EarLowGreaterThanThisTextBox.Name = "EarLowGreaterThanThisTextBox";
            this.EarLowGreaterThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.EarLowGreaterThanThisTextBox.TabIndex = 19;
            // 
            // NoseHighLessThanThisTextBox
            // 
            this.NoseHighLessThanThisTextBox.Location = new System.Drawing.Point(415, 136);
            this.NoseHighLessThanThisTextBox.Name = "NoseHighLessThanThisTextBox";
            this.NoseHighLessThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoseHighLessThanThisTextBox.TabIndex = 26;
            // 
            // NoseHighLessThanThisLabel
            // 
            this.NoseHighLessThanThisLabel.AutoSize = true;
            this.NoseHighLessThanThisLabel.Location = new System.Drawing.Point(270, 139);
            this.NoseHighLessThanThisLabel.Name = "NoseHighLessThanThisLabel";
            this.NoseHighLessThanThisLabel.Size = new System.Drawing.Size(139, 13);
            this.NoseHighLessThanThisLabel.TabIndex = 25;
            this.NoseHighLessThanThisLabel.Text = "Nose High Less Than This: ";
            // 
            // NoseHighGreaterThanThisLabel
            // 
            this.NoseHighGreaterThanThisLabel.AutoSize = true;
            this.NoseHighGreaterThanThisLabel.Location = new System.Drawing.Point(6, 139);
            this.NoseHighGreaterThanThisLabel.Name = "NoseHighGreaterThanThisLabel";
            this.NoseHighGreaterThanThisLabel.Size = new System.Drawing.Size(152, 13);
            this.NoseHighGreaterThanThisLabel.TabIndex = 24;
            this.NoseHighGreaterThanThisLabel.Text = "Nose High Greater Than This: ";
            // 
            // NoseHighGreaterThanThisTextBox
            // 
            this.NoseHighGreaterThanThisTextBox.Location = new System.Drawing.Point(164, 136);
            this.NoseHighGreaterThanThisTextBox.Name = "NoseHighGreaterThanThisTextBox";
            this.NoseHighGreaterThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoseHighGreaterThanThisTextBox.TabIndex = 23;
            // 
            // NoseLowLessThanThisTextBox
            // 
            this.NoseLowLessThanThisTextBox.Location = new System.Drawing.Point(415, 162);
            this.NoseLowLessThanThisTextBox.Name = "NoseLowLessThanThisTextBox";
            this.NoseLowLessThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoseLowLessThanThisTextBox.TabIndex = 30;
            // 
            // NoseLowLessThanThisLabel
            // 
            this.NoseLowLessThanThisLabel.AutoSize = true;
            this.NoseLowLessThanThisLabel.Location = new System.Drawing.Point(270, 165);
            this.NoseLowLessThanThisLabel.Name = "NoseLowLessThanThisLabel";
            this.NoseLowLessThanThisLabel.Size = new System.Drawing.Size(137, 13);
            this.NoseLowLessThanThisLabel.TabIndex = 29;
            this.NoseLowLessThanThisLabel.Text = "Nose Low Less Than This: ";
            // 
            // NoseLowGreaterThanThisLabel
            // 
            this.NoseLowGreaterThanThisLabel.AutoSize = true;
            this.NoseLowGreaterThanThisLabel.Location = new System.Drawing.Point(6, 165);
            this.NoseLowGreaterThanThisLabel.Name = "NoseLowGreaterThanThisLabel";
            this.NoseLowGreaterThanThisLabel.Size = new System.Drawing.Size(150, 13);
            this.NoseLowGreaterThanThisLabel.TabIndex = 28;
            this.NoseLowGreaterThanThisLabel.Text = "Nose Low Greater Than This: ";
            // 
            // NoseLowGreaterThanThisTextBox
            // 
            this.NoseLowGreaterThanThisTextBox.Location = new System.Drawing.Point(164, 162);
            this.NoseLowGreaterThanThisTextBox.Name = "NoseLowGreaterThanThisTextBox";
            this.NoseLowGreaterThanThisTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoseLowGreaterThanThisTextBox.TabIndex = 27;
            // 
            // DateLessThanThisLabel
            // 
            this.DateLessThanThisLabel.AutoSize = true;
            this.DateLessThanThisLabel.Location = new System.Drawing.Point(7, 247);
            this.DateLessThanThisLabel.Name = "DateLessThanThisLabel";
            this.DateLessThanThisLabel.Size = new System.Drawing.Size(112, 13);
            this.DateLessThanThisLabel.TabIndex = 33;
            this.DateLessThanThisLabel.Text = "Date Less Than This: ";
            // 
            // DateGreaterThanThisLabel
            // 
            this.DateGreaterThanThisLabel.AutoSize = true;
            this.DateGreaterThanThisLabel.Location = new System.Drawing.Point(7, 227);
            this.DateGreaterThanThisLabel.Name = "DateGreaterThanThisLabel";
            this.DateGreaterThanThisLabel.Size = new System.Drawing.Size(125, 13);
            this.DateGreaterThanThisLabel.TabIndex = 32;
            this.DateGreaterThanThisLabel.Text = "Date Greater Than This: ";
            // 
            // DateGreaterThanThisDatePicker
            // 
            this.DateGreaterThanThisDatePicker.Location = new System.Drawing.Point(138, 221);
            this.DateGreaterThanThisDatePicker.Name = "DateGreaterThanThisDatePicker";
            this.DateGreaterThanThisDatePicker.Size = new System.Drawing.Size(200, 20);
            this.DateGreaterThanThisDatePicker.TabIndex = 35;
            // 
            // DateLessThanThisDatePicker
            // 
            this.DateLessThanThisDatePicker.Location = new System.Drawing.Point(138, 247);
            this.DateLessThanThisDatePicker.Name = "DateLessThanThisDatePicker";
            this.DateLessThanThisDatePicker.Size = new System.Drawing.Size(200, 20);
            this.DateLessThanThisDatePicker.TabIndex = 36;
            // 
            // TableRowCountTextBox
            // 
            this.TableRowCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableRowCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableRowCountTextBox.Location = new System.Drawing.Point(1105, 13);
            this.TableRowCountTextBox.Name = "TableRowCountTextBox";
            this.TableRowCountTextBox.ReadOnly = true;
            this.TableRowCountTextBox.Size = new System.Drawing.Size(100, 13);
            this.TableRowCountTextBox.TabIndex = 37;
            this.TableRowCountTextBox.Text = "Row Count: 0";
            this.TableRowCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 396);
            this.Controls.Add(this.TableRowCountTextBox);
            this.Controls.Add(this.DateLessThanThisDatePicker);
            this.Controls.Add(this.DateGreaterThanThisDatePicker);
            this.Controls.Add(this.DateLessThanThisLabel);
            this.Controls.Add(this.DateGreaterThanThisLabel);
            this.Controls.Add(this.NoseLowLessThanThisTextBox);
            this.Controls.Add(this.NoseLowLessThanThisLabel);
            this.Controls.Add(this.NoseLowGreaterThanThisLabel);
            this.Controls.Add(this.NoseLowGreaterThanThisTextBox);
            this.Controls.Add(this.NoseHighLessThanThisTextBox);
            this.Controls.Add(this.NoseHighLessThanThisLabel);
            this.Controls.Add(this.NoseHighGreaterThanThisLabel);
            this.Controls.Add(this.NoseHighGreaterThanThisTextBox);
            this.Controls.Add(this.EarLowLessThanThisTextBox);
            this.Controls.Add(this.EarLowLessThanThisLabel);
            this.Controls.Add(this.EarLowGreaterThanThisLabel);
            this.Controls.Add(this.EarLowGreaterThanThisTextBox);
            this.Controls.Add(this.EarHighLessThanThisTextBox);
            this.Controls.Add(this.EarHighLessThanThisLabel);
            this.Controls.Add(this.EarHighGreaterThanThisLabel);
            this.Controls.Add(this.EarHighGreaterThanThisTextBox);
            this.Controls.Add(this.TailLowLessThanThisTextBox);
            this.Controls.Add(this.TailLowLessThanThisLabel);
            this.Controls.Add(this.TailLowGreaterThanThisLabel);
            this.Controls.Add(this.TailLowGreaterThanThisTextBox);
            this.Controls.Add(this.TailHighLessThanThisTextBox);
            this.Controls.Add(this.TailHighLessThanThisLabel);
            this.Controls.Add(this.generateCsvFileButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.TailHighGreaterThanThisLabel);
            this.Controls.Add(this.TailHighGreaterThanThisTextBox);
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
        private System.Windows.Forms.TextBox TailHighGreaterThanThisTextBox;
        private System.Windows.Forms.Label TailHighGreaterThanThisLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button generateCsvFileButton;
        private System.Windows.Forms.Label TailHighLessThanThisLabel;
        private System.Windows.Forms.TextBox TailHighLessThanThisTextBox;
        private System.Windows.Forms.TextBox TailLowLessThanThisTextBox;
        private System.Windows.Forms.Label TailLowLessThanThisLabel;
        private System.Windows.Forms.Label TailLowGreaterThanThisLabel;
        private System.Windows.Forms.TextBox TailLowGreaterThanThisTextBox;
        private System.Windows.Forms.TextBox EarHighLessThanThisTextBox;
        private System.Windows.Forms.Label EarHighLessThanThisLabel;
        private System.Windows.Forms.Label EarHighGreaterThanThisLabel;
        private System.Windows.Forms.TextBox EarHighGreaterThanThisTextBox;
        private System.Windows.Forms.TextBox EarLowLessThanThisTextBox;
        private System.Windows.Forms.Label EarLowLessThanThisLabel;
        private System.Windows.Forms.Label EarLowGreaterThanThisLabel;
        private System.Windows.Forms.TextBox EarLowGreaterThanThisTextBox;
        private System.Windows.Forms.TextBox NoseHighLessThanThisTextBox;
        private System.Windows.Forms.Label NoseHighLessThanThisLabel;
        private System.Windows.Forms.Label NoseHighGreaterThanThisLabel;
        private System.Windows.Forms.TextBox NoseHighGreaterThanThisTextBox;
        private System.Windows.Forms.TextBox NoseLowLessThanThisTextBox;
        private System.Windows.Forms.Label NoseLowLessThanThisLabel;
        private System.Windows.Forms.Label NoseLowGreaterThanThisLabel;
        private System.Windows.Forms.TextBox NoseLowGreaterThanThisTextBox;
        private System.Windows.Forms.Label DateLessThanThisLabel;
        private System.Windows.Forms.Label DateGreaterThanThisLabel;
        private System.Windows.Forms.DateTimePicker DateGreaterThanThisDatePicker;
        private System.Windows.Forms.DateTimePicker DateLessThanThisDatePicker;
        private System.Windows.Forms.TextBox TableRowCountTextBox;
    }
}

