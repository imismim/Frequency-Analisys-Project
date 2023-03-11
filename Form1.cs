using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Web;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string SelectFileNameUa { get; set; }
        private string SelectFileNameRu { get; set; }
        private string SelectFileNameEn { get; set; }

        private List<(char Symbol, float CalcPercent, float StandartPercent, float Dif)> tableUa { get; set; }
        private List<(char Symbol, float CalcPercent, float StandartPercent, float Dif)> tableRu { get; set; }
        private List<(char Symbol, float CalcPercent, float StandartPercent, float Dif)> tableEn { get; set; }

        private string CheckLang { get; set; }
        private bool ModeSorting { get; set; } = false;
        ToolTip CompareTip = new ToolTip();
        private string CompareTipString = "This value shows how close the calculated frequency tableUa\n" +
            "is to the standart frequency tableUa.\n" +
            " The closer the value is to 1, the more similar they are.";
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            
        }

        //private void DoItButton_Click(object sender, EventArgs e)
        //{
        //    this.tableUa = Frequency.FrequencyTableList(SelectFileNameUa, CheckLang);
        //    this.DisplayTableUaTextBox.Text = Frequency.BuildTable(tableUa);
        //}

        //private void ChooseFileButton_Click(object sender, EventArgs e)
        //{
        //    var post = this.openFileDialog1.ShowDialog();
        //    if (post == DialogResult.OK) 
        //    {
        //        this.SelectFileNameUa = this.openFileDialog1.SelectFileNameUa;
        //        if (this.SelectFileNameUa[^3..]!="txt")
        //        {
        //            if (InterfaceLangUa.Checked)
        //            {
        //                MessageBox.Show("Ви вибрали не правильний формат файлу!\nВиберіть txt формат!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning,
        //                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        //            }
        //            else if (InterfaceLangEn.Checked)
        //            {
        //                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
        //                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        //            }
        //        }
        //    }

        //}


        //private void importTable_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var post = this.openFileDialog1.ShowDialog();
        //        if (post == DialogResult.OK)
        //        {
        //            tableUa = new List<(char, float, float)>();
        //            using (var sr = new StreamReader(openFileDialog1.SelectFileNameUa))
        //            {
        //                string AllText = sr.ReadToEnd();
        //                var SplitLine = AllText.Split("\r\n").Where(i => i.Length>2).ToList();
        //                foreach (var item in SplitLine)
        //                {
        //                    var line = item.Split(';').ToList();
        //                    tableUa.Add((Char.Parse(line[0]), float.Parse(line[1]), float.Parse(line[2])));
        //                }
        //            }
        //            this.ShowFrequenchyTableTextBox.Text = Frequency.BuildTable(tableUa);
        //            this.SortingPanel.Visible = true;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        if (InterfaceLangUa.Checked)
        //        {
        //            MessageBox.Show("Ви щось робите не так!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning,
        //                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        //        }
        //        else if (InterfaceLangEn.Checked)
        //        {
        //            MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
        //                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        //        }
        //    }
        //}

        //private void SaveTable_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //        var post = this.saveFileDialog1.ShowDialog();

        //        if (post == DialogResult.OK)
        //        {
        //            using (var sw = new StreamWriter(this.saveFileDialog1.SelectFileNameUa))
        //            {
        //                //var newTable = this.tableUa.OrderBy(i => i.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
        //                foreach (var item in tableUa)
        //                {
        //                    sw.WriteLine($"{item.Symbol};{item.CalcPercent};{item.StandartPercent}");
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        if (InterfaceLangUa.Checked)
        //        {
        //            MessageBox.Show("Ви щось робите не так!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning,
        //                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        //        }
        //        else if (InterfaceLangEn.Checked)
        //        {
        //            MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
        //                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
        //        }
        //    }
        //}

        private void CompareTablesButton_Click(object sender, EventArgs e)
        {
            float AxB=0;
            float norm_A = 0;
            float norm_B = 0;

            for (int i = 0; i < tableUa.Count(); i++)
            {
                AxB += tableUa[i].CalcPercent * tableUa[i].StandartPercent;
                norm_A += (float)Math.Pow(tableUa[i].CalcPercent, 2);
                norm_B += (float)Math.Pow(tableUa[i].StandartPercent, 2);
            }
            norm_A = (float)Math.Sqrt(norm_A);
            norm_B = (float)Math.Sqrt(norm_B);

            var result = AxB / (norm_A * norm_B);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}