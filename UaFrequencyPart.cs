using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1
    {
        private string langUa = "UA";
        private void SelectFileUaButton_Click(object sender, EventArgs e)
        {
            var post = this.openFileDialog1.ShowDialog();
            if (post == DialogResult.OK)
            {
                this.SelectFileNameUa = this.openFileDialog1.FileName;
                if (this.SelectFileNameUa[^3..]!="txt")
                {
                    MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }

                this.tableUa = Frequency.FrequencyTableList(this.openFileDialog1.FileName, langUa);
                this.DisplayTableUaTextBox.Text =  Frequency.BuildTable(this.tableUa);
            }
        }

        private void SaveTableUaButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.saveFileDialog1.ShowDialog();

                if (post == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(this.saveFileDialog1.FileName))
                    {
                        //var newTable = this.tableUa.OrderBy(i => i.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                        foreach (var item in tableUa)
                        {
                            sw.WriteLine($"{item.Symbol};{item.CalcPercent};{item.StandartPercent}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        private void ImportTableUaButton_Click(object sender, EventArgs e)
        {
            try
            {
                var post = this.openFileDialog1.ShowDialog();
                if (post == DialogResult.OK)
                {
                    this.tableUa = new List<(char, float, float)>();
                    using (var sr = new StreamReader(openFileDialog1.FileName))
                    {
                        string AllText = sr.ReadToEnd();
                        var SplitLine = AllText.Split("\r\n").Where(i => i.Length>2).ToList();
                        foreach (var item in SplitLine)
                        {
                            var line = item.Split(';').ToList();
                            tableUa.Add((Char.Parse(line[0]), float.Parse(line[1]), float.Parse(line[2])));
                        }
                    }
                    this.DisplayTableUaTextBox.Text = Frequency.BuildTable(this.tableUa);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        private void CompareTablesUaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
