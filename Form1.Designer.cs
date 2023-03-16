namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayTableUaTextBox = new System.Windows.Forms.TextBox();
            this.SelectFileUaButton = new System.Windows.Forms.Button();
            this.SortingPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SortingRuTableRadioButton = new System.Windows.Forms.RadioButton();
            this.SortingUaTableRadioButton = new System.Windows.Forms.RadioButton();
            this.SortingEnTableRadioButton = new System.Windows.Forms.RadioButton();
            this.ByStandartPercentRadioButton = new System.Windows.Forms.RadioButton();
            this.SortingByPanel = new System.Windows.Forms.Panel();
            this.SortInDescendingOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.SortByGrowthRadioButton = new System.Windows.Forms.RadioButton();
            this.ByCalculatetPercentRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectSortingLabel = new System.Windows.Forms.Label();
            this.ByAlphabetRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SelectFileRuButton = new System.Windows.Forms.Button();
            this.SaveTableUaButton = new System.Windows.Forms.Button();
            this.ImportTableUaButton = new System.Windows.Forms.Button();
            this.SaveTableRuButton = new System.Windows.Forms.Button();
            this.ImprotTableRuButoon = new System.Windows.Forms.Button();
            this.DisplayTableRuTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTableEnTextBox = new System.Windows.Forms.TextBox();
            this.ImportTableEnButton = new System.Windows.Forms.Button();
            this.SaveTableEnButton = new System.Windows.Forms.Button();
            this.SelectFileEnButton = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SortingPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SortingByPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayTableUaTextBox
            // 
            this.DisplayTableUaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayTableUaTextBox.Location = new System.Drawing.Point(6, 132);
            this.DisplayTableUaTextBox.Multiline = true;
            this.DisplayTableUaTextBox.Name = "DisplayTableUaTextBox";
            this.DisplayTableUaTextBox.ReadOnly = true;
            this.DisplayTableUaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayTableUaTextBox.Size = new System.Drawing.Size(281, 320);
            this.DisplayTableUaTextBox.TabIndex = 1;
            this.DisplayTableUaTextBox.WordWrap = false;
            // 
            // SelectFileUaButton
            // 
            this.SelectFileUaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFileUaButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectFileUaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectFileUaButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectFileUaButton.Location = new System.Drawing.Point(6, 6);
            this.SelectFileUaButton.Name = "SelectFileUaButton";
            this.SelectFileUaButton.Size = new System.Drawing.Size(281, 50);
            this.SelectFileUaButton.TabIndex = 2;
            this.SelectFileUaButton.Text = "SELECT UA.TXT";
            this.SelectFileUaButton.UseVisualStyleBackColor = false;
            this.SelectFileUaButton.Click += new System.EventHandler(this.SelectFileUaButton_Click);
            // 
            // SortingPanel
            // 
            this.SortingPanel.Controls.Add(this.panel1);
            this.SortingPanel.Controls.Add(this.ByStandartPercentRadioButton);
            this.SortingPanel.Controls.Add(this.SortingByPanel);
            this.SortingPanel.Controls.Add(this.ByCalculatetPercentRadioButton);
            this.SortingPanel.Controls.Add(this.SelectSortingLabel);
            this.SortingPanel.Controls.Add(this.ByAlphabetRadioButton);
            this.SortingPanel.Location = new System.Drawing.Point(12, 473);
            this.SortingPanel.Name = "SortingPanel";
            this.SortingPanel.Size = new System.Drawing.Size(882, 151);
            this.SortingPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SortingRuTableRadioButton);
            this.panel1.Controls.Add(this.SortingUaTableRadioButton);
            this.panel1.Controls.Add(this.SortingEnTableRadioButton);
            this.panel1.Location = new System.Drawing.Point(420, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 117);
            this.panel1.TabIndex = 13;
            // 
            // SortingRuTableRadioButton
            // 
            this.SortingRuTableRadioButton.AutoSize = true;
            this.SortingRuTableRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SortingRuTableRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortingRuTableRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortingRuTableRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SortingRuTableRadioButton.Location = new System.Drawing.Point(21, 50);
            this.SortingRuTableRadioButton.Name = "SortingRuTableRadioButton";
            this.SortingRuTableRadioButton.Size = new System.Drawing.Size(146, 24);
            this.SortingRuTableRadioButton.TabIndex = 12;
            this.SortingRuTableRadioButton.Text = "Sorting RU Table";
            this.SortingRuTableRadioButton.UseVisualStyleBackColor = false;
            // 
            // SortingUaTableRadioButton
            // 
            this.SortingUaTableRadioButton.AutoSize = true;
            this.SortingUaTableRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SortingUaTableRadioButton.Checked = true;
            this.SortingUaTableRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortingUaTableRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortingUaTableRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SortingUaTableRadioButton.Location = new System.Drawing.Point(21, 19);
            this.SortingUaTableRadioButton.Name = "SortingUaTableRadioButton";
            this.SortingUaTableRadioButton.Size = new System.Drawing.Size(147, 24);
            this.SortingUaTableRadioButton.TabIndex = 10;
            this.SortingUaTableRadioButton.TabStop = true;
            this.SortingUaTableRadioButton.Text = "Sorting UA Table";
            this.SortingUaTableRadioButton.UseVisualStyleBackColor = false;
            // 
            // SortingEnTableRadioButton
            // 
            this.SortingEnTableRadioButton.AutoSize = true;
            this.SortingEnTableRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SortingEnTableRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortingEnTableRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortingEnTableRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SortingEnTableRadioButton.Location = new System.Drawing.Point(21, 81);
            this.SortingEnTableRadioButton.Name = "SortingEnTableRadioButton";
            this.SortingEnTableRadioButton.Size = new System.Drawing.Size(145, 24);
            this.SortingEnTableRadioButton.TabIndex = 11;
            this.SortingEnTableRadioButton.Text = "Sorting EN Table";
            this.SortingEnTableRadioButton.UseVisualStyleBackColor = false;
            // 
            // ByStandartPercentRadioButton
            // 
            this.ByStandartPercentRadioButton.AutoSize = true;
            this.ByStandartPercentRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ByStandartPercentRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ByStandartPercentRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ByStandartPercentRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ByStandartPercentRadioButton.Location = new System.Drawing.Point(14, 107);
            this.ByStandartPercentRadioButton.Name = "ByStandartPercentRadioButton";
            this.ByStandartPercentRadioButton.Size = new System.Drawing.Size(191, 24);
            this.ByStandartPercentRadioButton.TabIndex = 9;
            this.ByStandartPercentRadioButton.TabStop = true;
            this.ByStandartPercentRadioButton.Text = "by standart percentage";
            this.ByStandartPercentRadioButton.UseVisualStyleBackColor = false;
            this.ByStandartPercentRadioButton.CheckedChanged += new System.EventHandler(this.ByStandartPercentRadioButton_CheckedChanged);
            // 
            // SortingByPanel
            // 
            this.SortingByPanel.Controls.Add(this.SortInDescendingOrderRadioButton);
            this.SortingByPanel.Controls.Add(this.SortByGrowthRadioButton);
            this.SortingByPanel.Location = new System.Drawing.Point(240, 45);
            this.SortingByPanel.Name = "SortingByPanel";
            this.SortingByPanel.Size = new System.Drawing.Size(147, 69);
            this.SortingByPanel.TabIndex = 8;
            // 
            // SortInDescendingOrderRadioButton
            // 
            this.SortInDescendingOrderRadioButton.AutoSize = true;
            this.SortInDescendingOrderRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SortInDescendingOrderRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortInDescendingOrderRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortInDescendingOrderRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SortInDescendingOrderRadioButton.Location = new System.Drawing.Point(11, 33);
            this.SortInDescendingOrderRadioButton.Name = "SortInDescendingOrderRadioButton";
            this.SortInDescendingOrderRadioButton.Size = new System.Drawing.Size(129, 24);
            this.SortInDescendingOrderRadioButton.TabIndex = 6;
            this.SortInDescendingOrderRadioButton.TabStop = true;
            this.SortInDescendingOrderRadioButton.Text = "by descending";
            this.SortInDescendingOrderRadioButton.UseVisualStyleBackColor = false;
            this.SortInDescendingOrderRadioButton.CheckedChanged += new System.EventHandler(this.SortInDescendingOrderRadioButton_CheckedChanged);
            // 
            // SortByGrowthRadioButton
            // 
            this.SortByGrowthRadioButton.AutoSize = true;
            this.SortByGrowthRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SortByGrowthRadioButton.Checked = true;
            this.SortByGrowthRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByGrowthRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortByGrowthRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SortByGrowthRadioButton.Location = new System.Drawing.Point(11, 3);
            this.SortByGrowthRadioButton.Name = "SortByGrowthRadioButton";
            this.SortByGrowthRadioButton.Size = new System.Drawing.Size(101, 24);
            this.SortByGrowthRadioButton.TabIndex = 5;
            this.SortByGrowthRadioButton.TabStop = true;
            this.SortByGrowthRadioButton.Text = "by growth";
            this.SortByGrowthRadioButton.UseVisualStyleBackColor = false;
            this.SortByGrowthRadioButton.CheckedChanged += new System.EventHandler(this.SortByGrowthRadioButton_CheckedChanged);
            // 
            // ByCalculatetPercentRadioButton
            // 
            this.ByCalculatetPercentRadioButton.AutoSize = true;
            this.ByCalculatetPercentRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ByCalculatetPercentRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ByCalculatetPercentRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ByCalculatetPercentRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ByCalculatetPercentRadioButton.Location = new System.Drawing.Point(14, 76);
            this.ByCalculatetPercentRadioButton.Name = "ByCalculatetPercentRadioButton";
            this.ByCalculatetPercentRadioButton.Size = new System.Drawing.Size(202, 24);
            this.ByCalculatetPercentRadioButton.TabIndex = 6;
            this.ByCalculatetPercentRadioButton.TabStop = true;
            this.ByCalculatetPercentRadioButton.Text = "by calculated percentage";
            this.ByCalculatetPercentRadioButton.UseVisualStyleBackColor = false;
            this.ByCalculatetPercentRadioButton.CheckedChanged += new System.EventHandler(this.ByCalculatetPercentRadioButton_CheckedChanged);
            // 
            // SelectSortingLabel
            // 
            this.SelectSortingLabel.AutoSize = true;
            this.SelectSortingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectSortingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectSortingLabel.Location = new System.Drawing.Point(3, 2);
            this.SelectSortingLabel.Name = "SelectSortingLabel";
            this.SelectSortingLabel.Size = new System.Drawing.Size(271, 28);
            this.SelectSortingLabel.TabIndex = 4;
            this.SelectSortingLabel.Text = "Select sorting frequency table\r\n";
            // 
            // ByAlphabetRadioButton
            // 
            this.ByAlphabetRadioButton.AutoSize = true;
            this.ByAlphabetRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ByAlphabetRadioButton.Checked = true;
            this.ByAlphabetRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ByAlphabetRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ByAlphabetRadioButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ByAlphabetRadioButton.Location = new System.Drawing.Point(14, 45);
            this.ByAlphabetRadioButton.Name = "ByAlphabetRadioButton";
            this.ByAlphabetRadioButton.Size = new System.Drawing.Size(111, 24);
            this.ByAlphabetRadioButton.TabIndex = 5;
            this.ByAlphabetRadioButton.TabStop = true;
            this.ByAlphabetRadioButton.Text = "by alphabet";
            this.ByAlphabetRadioButton.UseVisualStyleBackColor = false;
            this.ByAlphabetRadioButton.CheckedChanged += new System.EventHandler(this.ByAlphabetRadioButton_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            // 
            // SelectFileRuButton
            // 
            this.SelectFileRuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFileRuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectFileRuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectFileRuButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectFileRuButton.Location = new System.Drawing.Point(0, 3);
            this.SelectFileRuButton.Name = "SelectFileRuButton";
            this.SelectFileRuButton.Size = new System.Drawing.Size(284, 50);
            this.SelectFileRuButton.TabIndex = 11;
            this.SelectFileRuButton.Text = "SELECT RU.TXT";
            this.SelectFileRuButton.UseVisualStyleBackColor = false;
            this.SelectFileRuButton.Click += new System.EventHandler(this.SelectFileRuButton_Click);
            // 
            // SaveTableUaButton
            // 
            this.SaveTableUaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTableUaButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveTableUaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveTableUaButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveTableUaButton.Location = new System.Drawing.Point(6, 62);
            this.SaveTableUaButton.Name = "SaveTableUaButton";
            this.SaveTableUaButton.Size = new System.Drawing.Size(139, 50);
            this.SaveTableUaButton.TabIndex = 12;
            this.SaveTableUaButton.Text = "SAVE";
            this.SaveTableUaButton.UseVisualStyleBackColor = false;
            this.SaveTableUaButton.Click += new System.EventHandler(this.SaveTableUaButton_Click);
            // 
            // ImportTableUaButton
            // 
            this.ImportTableUaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportTableUaButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImportTableUaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImportTableUaButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportTableUaButton.Location = new System.Drawing.Point(148, 62);
            this.ImportTableUaButton.Name = "ImportTableUaButton";
            this.ImportTableUaButton.Size = new System.Drawing.Size(139, 50);
            this.ImportTableUaButton.TabIndex = 14;
            this.ImportTableUaButton.Text = "IMPORT";
            this.ImportTableUaButton.UseVisualStyleBackColor = false;
            this.ImportTableUaButton.Click += new System.EventHandler(this.ImportTableUaButton_Click);
            // 
            // SaveTableRuButton
            // 
            this.SaveTableRuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTableRuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveTableRuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveTableRuButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveTableRuButton.Location = new System.Drawing.Point(0, 59);
            this.SaveTableRuButton.Name = "SaveTableRuButton";
            this.SaveTableRuButton.Size = new System.Drawing.Size(139, 50);
            this.SaveTableRuButton.TabIndex = 15;
            this.SaveTableRuButton.Text = "SAVE";
            this.SaveTableRuButton.UseVisualStyleBackColor = false;
            this.SaveTableRuButton.Click += new System.EventHandler(this.SaveTableRuButton_Click);
            // 
            // ImprotTableRuButoon
            // 
            this.ImprotTableRuButoon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImprotTableRuButoon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImprotTableRuButoon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImprotTableRuButoon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImprotTableRuButoon.Location = new System.Drawing.Point(145, 59);
            this.ImprotTableRuButoon.Name = "ImprotTableRuButoon";
            this.ImprotTableRuButoon.Size = new System.Drawing.Size(139, 50);
            this.ImprotTableRuButoon.TabIndex = 16;
            this.ImprotTableRuButoon.Text = "IMPORT";
            this.ImprotTableRuButoon.UseVisualStyleBackColor = false;
            this.ImprotTableRuButoon.Click += new System.EventHandler(this.ImprotTableRuButoon_Click);
            // 
            // DisplayTableRuTextBox
            // 
            this.DisplayTableRuTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayTableRuTextBox.Location = new System.Drawing.Point(0, 129);
            this.DisplayTableRuTextBox.Multiline = true;
            this.DisplayTableRuTextBox.Name = "DisplayTableRuTextBox";
            this.DisplayTableRuTextBox.ReadOnly = true;
            this.DisplayTableRuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayTableRuTextBox.Size = new System.Drawing.Size(284, 320);
            this.DisplayTableRuTextBox.TabIndex = 18;
            this.DisplayTableRuTextBox.WordWrap = false;
            // 
            // DisplayTableEnTextBox
            // 
            this.DisplayTableEnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayTableEnTextBox.Location = new System.Drawing.Point(3, 128);
            this.DisplayTableEnTextBox.Multiline = true;
            this.DisplayTableEnTextBox.Name = "DisplayTableEnTextBox";
            this.DisplayTableEnTextBox.ReadOnly = true;
            this.DisplayTableEnTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayTableEnTextBox.Size = new System.Drawing.Size(284, 320);
            this.DisplayTableEnTextBox.TabIndex = 24;
            this.DisplayTableEnTextBox.WordWrap = false;
            // 
            // ImportTableEnButton
            // 
            this.ImportTableEnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportTableEnButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImportTableEnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImportTableEnButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImportTableEnButton.Location = new System.Drawing.Point(148, 61);
            this.ImportTableEnButton.Name = "ImportTableEnButton";
            this.ImportTableEnButton.Size = new System.Drawing.Size(139, 50);
            this.ImportTableEnButton.TabIndex = 22;
            this.ImportTableEnButton.Text = "IMPORT";
            this.ImportTableEnButton.UseVisualStyleBackColor = false;
            this.ImportTableEnButton.Click += new System.EventHandler(this.ImportTableEnButton_Click);
            // 
            // SaveTableEnButton
            // 
            this.SaveTableEnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTableEnButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveTableEnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveTableEnButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SaveTableEnButton.Location = new System.Drawing.Point(3, 61);
            this.SaveTableEnButton.Name = "SaveTableEnButton";
            this.SaveTableEnButton.Size = new System.Drawing.Size(139, 50);
            this.SaveTableEnButton.TabIndex = 21;
            this.SaveTableEnButton.Text = "SAVE";
            this.SaveTableEnButton.UseVisualStyleBackColor = false;
            this.SaveTableEnButton.Click += new System.EventHandler(this.SaveTableEnButton_Click);
            // 
            // SelectFileEnButton
            // 
            this.SelectFileEnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFileEnButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectFileEnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectFileEnButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SelectFileEnButton.Location = new System.Drawing.Point(3, 3);
            this.SelectFileEnButton.Name = "SelectFileEnButton";
            this.SelectFileEnButton.Size = new System.Drawing.Size(284, 50);
            this.SelectFileEnButton.TabIndex = 20;
            this.SelectFileEnButton.Text = "SELECT EN.TXT";
            this.SelectFileEnButton.UseVisualStyleBackColor = false;
            this.SelectFileEnButton.Click += new System.EventHandler(this.SelectFileEnButton_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog2";
            this.openFileDialog3.Multiselect = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.SortingPanel);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 630);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.DisplayTableEnTextBox);
            this.panel3.Controls.Add(this.SelectFileEnButton);
            this.panel3.Controls.Add(this.SaveTableEnButton);
            this.panel3.Controls.Add(this.ImportTableEnButton);
            this.panel3.Location = new System.Drawing.Point(607, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 458);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.DisplayTableRuTextBox);
            this.panel4.Controls.Add(this.SaveTableRuButton);
            this.panel4.Controls.Add(this.SelectFileRuButton);
            this.panel4.Controls.Add(this.ImprotTableRuButoon);
            this.panel4.Location = new System.Drawing.Point(311, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 458);
            this.panel4.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SelectFileUaButton);
            this.panel5.Controls.Add(this.SaveTableUaButton);
            this.panel5.Controls.Add(this.DisplayTableUaTextBox);
            this.panel5.Controls.Add(this.ImportTableUaButton);
            this.panel5.Location = new System.Drawing.Point(10, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 461);
            this.panel5.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(915, 638);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequency analysis";
            this.SortingPanel.ResumeLayout(false);
            this.SortingPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SortingByPanel.ResumeLayout(false);
            this.SortingByPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox DisplayTableUaTextBox;
        private Button SelectFileUaButton;
        private Panel SortingPanel;
        private Panel SortingByPanel;
        private RadioButton SortInDescendingOrderRadioButton;
        private RadioButton SortByGrowthRadioButton;
        private Label SelectSortingLabel;
        private RadioButton ByCalculatetPercentRadioButton;
        private RadioButton ByAlphabetRadioButton;
        private OpenFileDialog openFileDialog1;
        private RadioButton ByStandartPercentRadioButton;
        private OpenFileDialog openFileDialog2;
        private SaveFileDialog saveFileDialog1;
        private Button SelectFileRuButton;
        private Button SaveTableUaButton;
        private Button ImportTableUaButton;
        private Button SaveTableRuButton;
        private Button ImprotTableRuButoon;
        private TextBox DisplayTableRuTextBox;
        private TextBox DisplayTableEnTextBox;
        private Button ImportTableEnButton;
        private Button SaveTableEnButton;
        private Button SelectFileEnButton;
        private RadioButton SortingRuTableRadioButton;
        private RadioButton SortingEnTableRadioButton;
        private RadioButton SortingUaTableRadioButton;
        private Panel panel1;
        private OpenFileDialog openFileDialog3;
        private SaveFileDialog saveFileDialog2;
        private SaveFileDialog saveFileDialog3;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}