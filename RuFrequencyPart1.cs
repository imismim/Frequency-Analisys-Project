using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsApp1
{
    partial class Form1
    {
        string langRu = "RU";
        private void SelectFileRuButton_Click(object sender, EventArgs e)
        {
            var post = this.openFileDialog2.ShowDialog();
            if (post == DialogResult.OK)
            {
                this.SelectFileNameRu = this.openFileDialog2.FileName;
                if (this.SelectFileNameRu[^3..]!="txt")
                {
                    MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
                }
                else
                {
                    this.tableRu = Frequency.FrequencyTableList(this.openFileDialog2.FileName, langRu);
                    this.DisplayTableRuTextBox.Text =  Frequency.BuildTable(this.tableRu);
                }

 
            }
        }

        private void SaveTableRuButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.saveFileDialog2.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.saveFileDialog2.ShowDialog();

                if (post == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(this.saveFileDialog2.FileName))
                    {
                        //var newTable = this.tableUa.OrderBy(i => i.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                        foreach (var item in tableRu)
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

        private void ImprotTableRuButoon_Click(object sender, EventArgs e)
        {
            try
            {
                var post = this.openFileDialog2.ShowDialog();
                if (post == DialogResult.OK)
                {
                    this.tableRu = new List<(char, float, float, float)>();
                    List<string> line;
                    float CalcPer, StandartPer, Dif;
                    using (var sr = new StreamReader(openFileDialog2.FileName))
                    {
                        string AllText = sr.ReadToEnd();
                        var SplitLine = AllText.Split("\r\n").Where(i => i.Length>2).ToList();
                        foreach (var item in SplitLine)
                        {
                            line = item.Split(';').ToList();
                            CalcPer = float.Parse(line[1]);
                            StandartPer = float.Parse(line[2]);
                            Dif =(float)Math.Round(Math.Abs(CalcPer-StandartPer), 3);
                            tableRu.Add((Char.Parse(line[0]), CalcPer, StandartPer, Dif));
                        }
                    }
                    this.DisplayTableRuTextBox.Text = Frequency.BuildTable(this.tableRu);
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
