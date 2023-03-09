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
            this.DoItButton = new System.Windows.Forms.Button();
            this.ShowFrequenchyTableTextBox = new System.Windows.Forms.TextBox();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.ShowPathTextBox = new System.Windows.Forms.TextBox();
            this.SelectLangFileLabel = new System.Windows.Forms.Label();
            this.isUkFile = new System.Windows.Forms.RadioButton();
            this.LangFilePanel = new System.Windows.Forms.Panel();
            this.isEnFile = new System.Windows.Forms.RadioButton();
            this.SortingPanel = new System.Windows.Forms.Panel();
            this.CompareResultLabel = new System.Windows.Forms.Label();
            this.CompareTablesButton = new System.Windows.Forms.Button();
            this.ByStandartPercentRadioButton = new System.Windows.Forms.RadioButton();
            this.SortingByPanel = new System.Windows.Forms.Panel();
            this.SortInDescendingOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.SortByGrowthRadioButton = new System.Windows.Forms.RadioButton();
            this.ByCalculatetPercentRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectSortingLabel = new System.Windows.Forms.Label();
            this.ByAlphabetRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ReturnToChangeLangButton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InterfaceLangUa = new System.Windows.Forms.ToolStripMenuItem();
            this.InterfaceLangEn = new System.Windows.Forms.ToolStripMenuItem();
            this.importTable = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTable = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.LangFilePanel.SuspendLayout();
            this.SortingPanel.SuspendLayout();
            this.SortingByPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoItButton
            // 
            this.DoItButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DoItButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoItButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DoItButton.Location = new System.Drawing.Point(12, 0);
            this.DoItButton.Name = "DoItButton";
            this.DoItButton.Size = new System.Drawing.Size(417, 60);
            this.DoItButton.TabIndex = 0;
            this.DoItButton.Text = "ENTER";
            this.DoItButton.UseVisualStyleBackColor = false;
            this.DoItButton.Click += new System.EventHandler(this.DoItButton_Click);
            // 
            // ShowFrequenchyTableTextBox
            // 
            this.ShowFrequenchyTableTextBox.Location = new System.Drawing.Point(441, 103);
            this.ShowFrequenchyTableTextBox.Multiline = true;
            this.ShowFrequenchyTableTextBox.Name = "ShowFrequenchyTableTextBox";
            this.ShowFrequenchyTableTextBox.ReadOnly = true;
            this.ShowFrequenchyTableTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ShowFrequenchyTableTextBox.Size = new System.Drawing.Size(389, 355);
            this.ShowFrequenchyTableTextBox.TabIndex = 1;
            this.ShowFrequenchyTableTextBox.WordWrap = false;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseFileButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 33);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(185, 52);
            this.ChooseFileButton.TabIndex = 2;
            this.ChooseFileButton.Text = "Select File";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // ShowPathTextBox
            // 
            this.ShowPathTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ShowPathTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowPathTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ShowPathTextBox.Location = new System.Drawing.Point(204, 33);
            this.ShowPathTextBox.Multiline = true;
            this.ShowPathTextBox.Name = "ShowPathTextBox";
            this.ShowPathTextBox.ReadOnly = true;
            this.ShowPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ShowPathTextBox.Size = new System.Drawing.Size(626, 52);
            this.ShowPathTextBox.TabIndex = 3;
            this.ShowPathTextBox.WordWrap = false;
            // 
            // SelectLangFileLabel
            // 
            this.SelectLangFileLabel.AutoSize = true;
            this.SelectLangFileLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectLangFileLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectLangFileLabel.Location = new System.Drawing.Point(0, 0);
            this.SelectLangFileLabel.Name = "SelectLangFileLabel";
            this.SelectLangFileLabel.Size = new System.Drawing.Size(278, 28);
            this.SelectLangFileLabel.TabIndex = 4;
            this.SelectLangFileLabel.Text = "Select language in selected file";
            // 
            // isUkFile
            // 
            this.isUkFile.AutoSize = true;
            this.isUkFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isUkFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isUkFile.ForeColor = System.Drawing.SystemColors.Control;
            this.isUkFile.Location = new System.Drawing.Point(14, 45);
            this.isUkFile.Name = "isUkFile";
            this.isUkFile.Size = new System.Drawing.Size(96, 24);
            this.isUkFile.TabIndex = 5;
            this.isUkFile.Text = "Ukrainian";
            this.isUkFile.UseVisualStyleBackColor = true;
            this.isUkFile.CheckedChanged += new System.EventHandler(this.UkFileRadioButton_CheckedChanged);
            // 
            // LangFilePanel
            // 
            this.LangFilePanel.Controls.Add(this.isEnFile);
            this.LangFilePanel.Controls.Add(this.SelectLangFileLabel);
            this.LangFilePanel.Controls.Add(this.isUkFile);
            this.LangFilePanel.Location = new System.Drawing.Point(16, 103);
            this.LangFilePanel.Name = "LangFilePanel";
            this.LangFilePanel.Size = new System.Drawing.Size(419, 100);
            this.LangFilePanel.TabIndex = 6;
            this.LangFilePanel.Visible = false;
            // 
            // isEnFile
            // 
            this.isEnFile.AutoSize = true;
            this.isEnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isEnFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isEnFile.ForeColor = System.Drawing.SystemColors.Control;
            this.isEnFile.Location = new System.Drawing.Point(150, 45);
            this.isEnFile.Name = "isEnFile";
            this.isEnFile.Size = new System.Drawing.Size(79, 24);
            this.isEnFile.TabIndex = 6;
            this.isEnFile.Text = "English";
            this.isEnFile.UseVisualStyleBackColor = true;
            this.isEnFile.CheckedChanged += new System.EventHandler(this.EnFileRadioButton_CheckedChanged);
            // 
            // SortingPanel
            // 
            this.SortingPanel.Controls.Add(this.CompareResultLabel);
            this.SortingPanel.Controls.Add(this.CompareTablesButton);
            this.SortingPanel.Controls.Add(this.ByStandartPercentRadioButton);
            this.SortingPanel.Controls.Add(this.SortingByPanel);
            this.SortingPanel.Controls.Add(this.ByCalculatetPercentRadioButton);
            this.SortingPanel.Controls.Add(this.SelectSortingLabel);
            this.SortingPanel.Controls.Add(this.ByAlphabetRadioButton);
            this.SortingPanel.Location = new System.Drawing.Point(6, 73);
            this.SortingPanel.Name = "SortingPanel";
            this.SortingPanel.Size = new System.Drawing.Size(426, 205);
            this.SortingPanel.TabIndex = 7;
            this.SortingPanel.Visible = false;
            // 
            // CompareResultLabel
            // 
            this.CompareResultLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompareResultLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompareResultLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CompareResultLabel.Location = new System.Drawing.Point(120, 153);
            this.CompareResultLabel.Name = "CompareResultLabel";
            this.CompareResultLabel.Size = new System.Drawing.Size(303, 49);
            this.CompareResultLabel.TabIndex = 11;
            this.CompareResultLabel.Text = "0000000";
            this.CompareResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompareTablesButton
            // 
            this.CompareTablesButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CompareTablesButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompareTablesButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CompareTablesButton.Location = new System.Drawing.Point(6, 153);
            this.CompareTablesButton.Name = "CompareTablesButton";
            this.CompareTablesButton.Size = new System.Drawing.Size(108, 49);
            this.CompareTablesButton.TabIndex = 10;
            this.CompareTablesButton.Text = "Compare";
            this.CompareTablesButton.UseVisualStyleBackColor = false;
            this.CompareTablesButton.Click += new System.EventHandler(this.CompareTablesButton_Click);
            // 
            // ByStandartPercentRadioButton
            // 
            this.ByStandartPercentRadioButton.AutoSize = true;
            this.ByStandartPercentRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ByStandartPercentRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ByStandartPercentRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ByStandartPercentRadioButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
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
            this.SortingByPanel.Location = new System.Drawing.Point(267, 33);
            this.SortingByPanel.Name = "SortingByPanel";
            this.SortingByPanel.Size = new System.Drawing.Size(147, 76);
            this.SortingByPanel.TabIndex = 8;
            // 
            // SortInDescendingOrderRadioButton
            // 
            this.SortInDescendingOrderRadioButton.AutoSize = true;
            this.SortInDescendingOrderRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SortInDescendingOrderRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortInDescendingOrderRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortInDescendingOrderRadioButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SortInDescendingOrderRadioButton.Location = new System.Drawing.Point(11, 43);
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
            this.SortByGrowthRadioButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SortByGrowthRadioButton.Location = new System.Drawing.Point(11, 13);
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
            this.ByCalculatetPercentRadioButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
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
            this.SelectSortingLabel.Location = new System.Drawing.Point(11, 0);
            this.SelectSortingLabel.Name = "SelectSortingLabel";
            this.SelectSortingLabel.Size = new System.Drawing.Size(271, 28);
            this.SelectSortingLabel.TabIndex = 4;
            this.SelectSortingLabel.Text = "Select sorting frequency table";
            // 
            // ByAlphabetRadioButton
            // 
            this.ByAlphabetRadioButton.AutoSize = true;
            this.ByAlphabetRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ByAlphabetRadioButton.Checked = true;
            this.ByAlphabetRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ByAlphabetRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ByAlphabetRadioButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
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
            // ReturnToChangeLangButton
            // 
            this.ReturnToChangeLangButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReturnToChangeLangButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnToChangeLangButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ReturnToChangeLangButton.Location = new System.Drawing.Point(12, 296);
            this.ReturnToChangeLangButton.Name = "ReturnToChangeLangButton";
            this.ReturnToChangeLangButton.Size = new System.Drawing.Size(417, 59);
            this.ReturnToChangeLangButton.TabIndex = 8;
            this.ReturnToChangeLangButton.Text = "Return to select lang";
            this.ReturnToChangeLangButton.UseVisualStyleBackColor = false;
            this.ReturnToChangeLangButton.Click += new System.EventHandler(this.ReturnToChangeLangButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageToolStripMenuItem,
            this.importTable,
            this.SaveTable});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(842, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LanguageToolStripMenuItem
            // 
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InterfaceLangUa,
            this.InterfaceLangEn});
            this.LanguageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            this.LanguageToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.LanguageToolStripMenuItem.Text = "Language interface";
            // 
            // InterfaceLangUa
            // 
            this.InterfaceLangUa.Name = "InterfaceLangUa";
            this.InterfaceLangUa.Size = new System.Drawing.Size(154, 26);
            this.InterfaceLangUa.Text = "Ukrainian";
            this.InterfaceLangUa.Click += new System.EventHandler(this.InterfaceLangUa_Click);
            // 
            // InterfaceLangEn
            // 
            this.InterfaceLangEn.Checked = true;
            this.InterfaceLangEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InterfaceLangEn.Name = "InterfaceLangEn";
            this.InterfaceLangEn.Size = new System.Drawing.Size(154, 26);
            this.InterfaceLangEn.Text = "English";
            this.InterfaceLangEn.Click += new System.EventHandler(this.InterfaceLangEn_Click);
            // 
            // importTable
            // 
            this.importTable.Name = "importTable";
            this.importTable.Size = new System.Drawing.Size(107, 24);
            this.importTable.Text = "Import Table";
            this.importTable.Click += new System.EventHandler(this.importTable_Click);
            // 
            // SaveTable
            // 
            this.SaveTable.Name = "SaveTable";
            this.SaveTable.Size = new System.Drawing.Size(93, 24);
            this.SaveTable.Text = "Save Table";
            this.SaveTable.Click += new System.EventHandler(this.SaveTable_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.SortingPanel);
            this.ControlPanel.Controls.Add(this.ReturnToChangeLangButton);
            this.ControlPanel.Controls.Add(this.DoItButton);
            this.ControlPanel.Location = new System.Drawing.Point(0, 103);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(435, 360);
            this.ControlPanel.TabIndex = 8;
            this.ControlPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(842, 475);
            this.Controls.Add(this.ShowFrequenchyTableTextBox);
            this.Controls.Add(this.ShowPathTextBox);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LangFilePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequency analysis";
            this.LangFilePanel.ResumeLayout(false);
            this.LangFilePanel.PerformLayout();
            this.SortingPanel.ResumeLayout(false);
            this.SortingPanel.PerformLayout();
            this.SortingByPanel.ResumeLayout(false);
            this.SortingByPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DoItButton;
        private TextBox ShowFrequenchyTableTextBox;
        private Button ChooseFileButton;
        private TextBox ShowPathTextBox;
        private Label SelectLangFileLabel;
        private RadioButton isUkFile;
        private Panel LangFilePanel;
        private RadioButton isEnFile;
        private Panel SortingPanel;
        private Panel SortingByPanel;
        private RadioButton SortInDescendingOrderRadioButton;
        private RadioButton SortByGrowthRadioButton;
        private Label SelectSortingLabel;
        private RadioButton ByCalculatetPercentRadioButton;
        private RadioButton ByAlphabetRadioButton;
        private OpenFileDialog openFileDialog1;
        private Button ReturnToChangeLangButton;
        private RadioButton ByStandartPercentRadioButton;
        private OpenFileDialog openFileDialog2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem LanguageToolStripMenuItem;
        private ToolStripMenuItem InterfaceLangUa;
        private ToolStripMenuItem InterfaceLangEn;
        private ToolStripMenuItem importTable;
        private Label CompareResultLabel;
        private Button CompareTablesButton;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem SaveTable;
        private Panel ControlPanel;
    }
}