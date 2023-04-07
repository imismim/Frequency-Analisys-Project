using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Form1
    {
        private string langEn = "EN";
        private void SelectFileEnButton_Click(object sender, EventArgs e)
        {
            var post = this.openFileDialog3.ShowDialog();
            if (post == DialogResult.OK)
            {
                this.SelectFileNameEn = this.openFileDialog3.FileName;
                if (this.SelectFileNameEn[^3..]!="txt")
                {
                    MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
                else
                {
                    this.tableEn = Frequency.FrequencyTableList(this.openFileDialog3.FileName, langEn);
                    this.DisplayTableEnTextBox.Text =  Frequency.BuildTable(this.tableEn);
                }
            }
        }

        private void SaveTableEnButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog3.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.saveFileDialog3.ShowDialog();

                if (post == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(this.saveFileDialog3.FileName))
                    {
                        //var newTable = this.tableUa.OrderBy(i => i.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                        foreach (var item in tableEn)
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

        private void ImportTableEnButton_Click(object sender, EventArgs e)
        {
            try
            {
                var post = this.openFileDialog3.ShowDialog();
                if (post == DialogResult.OK)
                {
                    this.tableEn = new List<(char, float, float, float)>();
                    List<string> line;
                    float CalcPer, StandartPer, Dif;
                    using (var sr = new StreamReader(openFileDialog3.FileName))
                    {
                        string AllText = sr.ReadToEnd();
                        var SplitLine = AllText.Split("\r\n").Where(i => i.Length>2).ToList();
                        foreach (var item in SplitLine)
                        {
                            line = item.Split(';').ToList();
                            CalcPer = float.Parse(line[1]);
                            StandartPer = float.Parse(line[2]);
                            Dif =(float)Math.Round(Math.Abs(CalcPer-StandartPer), 3);
                            tableEn.Add((Char.Parse(line[0]), CalcPer, StandartPer, Dif));
                        }
                    }
                    this.DisplayTableEnTextBox.Text = Frequency.BuildTable(this.tableEn);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }
    }
}
