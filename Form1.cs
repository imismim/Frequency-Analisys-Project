using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Web;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string FileName { get; set; }
        private List<(char Symbol, float CalcPercent, float StandartPercent)> table { get; set; }
        private char CheckLang { get; set; }
        private bool ModeSorting { get; set; } = false;
        ToolTip CompareTip = new ToolTip();
        private string CompareTipString = "This value shows how close the calculated frequency table\n" +
            "is to the standart frequency table.\n" +
            " The closer the value is to 1, the more similar they are.";
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            this.CompareResultLabel.MouseHover += new EventHandler((sender, e) =>

                this.CompareTip.SetToolTip(this.CompareResultLabel, this.CompareTipString)
             );
            
        }

        private void DoItButton_Click(object sender, EventArgs e)
        {
            if (isEnFile.Checked)
                CheckLang = 'e';
            else if (isUkFile.Checked)
                CheckLang = 'u';
            this.table = Frequency.FrequencyTable(FileName, CheckLang);
            this.ShowFrequenchyTableTextBox.Text = Frequency.BuildTable(table);
            this.SortingPanel.Visible = true;
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            var post = this.openFileDialog1.ShowDialog();
            if (post == DialogResult.OK) 
            {
                this.FileName = this.openFileDialog1.FileName;
                if (this.FileName[^3..]=="txt")
                {
                    this.ControlPanel.Visible = false;
                    this.SortingPanel.Visible = false;
                    this.LangFilePanel.Visible = false;
                    this.ShowPathTextBox.Text = this.FileName;
                    this.LangFilePanel.Visible = true;
                }
                else
                {
                    if (InterfaceLangUa.Checked)
                    {
                        MessageBox.Show("Ви вибрали не правильний формат файлу!\nВиберіть txt формат!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                    }
                    else if (InterfaceLangEn.Checked)
                    {
                        MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                    }
                }
            }

        }

        private void UkFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlPanel.Visible = true;
            this.LangFilePanel.Visible= false;
        }

        private void EnFileRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlPanel.Visible = true;
            this.LangFilePanel.Visible= false;
        }

        private void ReturnToChangeLangButton_Click(object sender, EventArgs e)
        {
            this.ControlPanel.Visible = false;
            this.LangFilePanel.Visible= true;
        }

        private void importTable_Click(object sender, EventArgs e)
        {
            try
            {
                var post = this.openFileDialog1.ShowDialog();
                if (post == DialogResult.OK)
                {
                    table = new List<(char, float, float)>();
                    using (var sr = new StreamReader(openFileDialog1.FileName))
                    {
                        string AllText = sr.ReadToEnd();
                        var SplitLine = AllText.Split("\r\n").Where(i => i.Length>2).ToList();
                        foreach (var item in SplitLine)
                        {
                            var line = item.Split(';').ToList();
                            table.Add((Char.Parse(line[0]), float.Parse(line[1]), float.Parse(line[2])));
                        }
                    }
                    this.ShowFrequenchyTableTextBox.Text = Frequency.BuildTable(table);
                    this.SortingPanel.Visible = true;
                }
            }
            catch (Exception)
            {
                if (InterfaceLangUa.Checked)
                {
                    MessageBox.Show("Ви щось робите не так!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
                else if (InterfaceLangEn.Checked)
                {
                    MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
            }
        }

        private void SaveTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEnFile.Checked)
                    this.saveFileDialog1.Title = $"FTable_{rand.Next(0, 100000)}_en.txt";
                else if (isUkFile.Checked)
                    this.saveFileDialog1.Title = $"FTable_{rand.Next(0, 100000)}_ua.txt";

                this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.saveFileDialog1.ShowDialog();

                if (post == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(this.saveFileDialog1.FileName))
                    {
                        //var newTable = this.table.OrderBy(i => i.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                        foreach (var item in table)
                        {
                            sw.WriteLine($"{item.Symbol};{item.CalcPercent};{item.StandartPercent}");
                        }
                    }
                }
            }
            catch (Exception)
            {

                if (InterfaceLangUa.Checked)
                {
                    MessageBox.Show("Ви щось робите не так!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
                else if (InterfaceLangEn.Checked)
                {
                    MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
            }
        }

        private void CompareTablesButton_Click(object sender, EventArgs e)
        {
            float AxB=0;
            float norm_A = 0;
            float norm_B = 0;

            for (int i = 0; i < table.Count(); i++)
            {
                AxB += table[i].CalcPercent * table[i].StandartPercent;
                norm_A += (float)Math.Pow(table[i].CalcPercent, 2);
                norm_B += (float)Math.Pow(table[i].StandartPercent, 2);
            }
            norm_A = (float)Math.Sqrt(norm_A);
            norm_B = (float)Math.Sqrt(norm_B);

            var result = AxB / (norm_A * norm_B);
            this.CompareResultLabel.Text = result.ToString();
        }

    }
}