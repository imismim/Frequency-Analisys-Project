using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1
    {
        private string FDTfileName { get; set; }
        private string EncodedText { get; set; }
        private string DecodedText { get; set; }
        private List<(char letter1, char letter2)> letters { get; set; } 
        private string FDTlang { get; set; } = "EN";
        object[] ukrAlphabet = { 'А', 'Б', 'В', 'Г', 'Ґ', 'Д', 'Е', 'Є', 'Ж', 'З', 'И', 'І', 'Ї', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ю', 'Я' };
        object[] engAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        object[] rusAlphabet = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };
        public string LogString { get; set; } = string.Empty;

        private void FDTselectTextButton_Click(object sender, EventArgs e)
        {
            var post = this.FDTopenFileDialog.ShowDialog();
            if (post == DialogResult.OK)
            {
                this.FDTfileName = this.FDTopenFileDialog.FileName;
                if (this.FDTfileName[^3..]!="txt")
                {
                    MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
               
                }
                else
                {
                    this.EncodedText = FDT.ReadFile(this.FDTopenFileDialog.FileName);
                    this.DecodedText = FDT.DecodedText(this.EncodedText, this.FDTfileName, this.FDTlang);

                    this.FDTencodedTextBox.Text = this.EncodedText;
                    this.FDTdecodedTextBox.Text = this.DecodedText;
                    this.ChangeReplaceAlphabet(this.engAlphabet);
                }
            }
        }

        private void FDTdoChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var firstLetter = char.ToLower(char.Parse(this.FDTletterReplace1ComboBox.SelectedItem.ToString()));
                var secondLetter = char.ToLower(char.Parse(this.FDTletterReplace2ComboBox.SelectedItem.ToString()));
                this.LogString += $"{firstLetter}<->{secondLetter}{Environment.NewLine}";
                this.DecodedText = FDT.OneTimeReplaceLetter(this.DecodedText, firstLetter, secondLetter);
                this.FDTdecodedTextBox.Text = this.DecodedText;
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void FDTsaveLogFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.FDTsaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.FDTsaveFileDialog.ShowDialog();
                if (post == DialogResult.OK)
                {
                    string log = string.Empty;
                    var list = FDT.ListLettersChanged(this.FDTfileName, this.FDTlang);
                    foreach (var item in list)
                    {
                        log+=$"{item.letter1}->{item.letter2}{Environment.NewLine}";
                    }
                    log += $"{Environment.NewLine}Manual Replace{Environment.NewLine}";
                    log += this.LogString;
                    FDT.SaveLogFile(this.FDTsaveFileDialog.FileName, log);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void FDTsaveDecodedTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.FDTsaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                var post = this.FDTsaveFileDialog.ShowDialog();
                if (post == DialogResult.OK)
                {
                    using (var wr = new StreamWriter(this.FDTsaveFileDialog.FileName))
                    {
                        wr.Write(this.DecodedText);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void ChangeReplaceAlphabet(in object[] alphabet)
        {
            letters = FDT.ListLettersChanged(this.FDTfileName, this.FDTlang);
            this.FDTletterReplace1ComboBox.Items.Clear();
            this.FDTletterReplace2ComboBox.Items.Clear();
            this.FDTletterReplace1ComboBox.Items.AddRange(alphabet);
            this.FDTletterReplace1ComboBox.Text = alphabet[0].ToString();
            this.FDTletterReplace2ComboBox.Items.AddRange(alphabet);
            this.FDTletterReplace2ComboBox.Text = alphabet[0].ToString();
            this.LogString = string.Empty;
    
        }

        private void FDTuaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.FDTlang = "UA";  
                this.ChangeReplaceAlphabet(this.ukrAlphabet);
                this.FDTdecodedTextBox.Text = FDT.DecodedText(this.EncodedText, this.FDTfileName, this.FDTlang);
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        private void FDTenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.FDTlang = "EN";
                this.ChangeReplaceAlphabet(this.engAlphabet);
                this.FDTdecodedTextBox.Text = FDT.DecodedText(this.EncodedText, this.FDTfileName, this.FDTlang);      
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        private void FDTruRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.FDTlang = "RU";
                this.ChangeReplaceAlphabet(this.rusAlphabet);
                this.FDTdecodedTextBox.Text = FDT.DecodedText(this.EncodedText, this.FDTfileName, this.FDTlang);   
            }
            catch (Exception)
            {

                MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        private void ImportTableButton_Click(object sender, EventArgs e)
        {
            var post = this.FDTopenFileDialog.ShowDialog();
            if (post == DialogResult.OK)
            {
                if (this.FDTopenFileDialog.FileName[^3..]!="txt")
                {
                    MessageBox.Show("You selected the wrong file format!\nChoose txt format!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);

                }
                else
                {
                    var table = Frequency.ImportTable(this.FDTopenFileDialog.FileName).OrderByDescending(i => i.CalcPercent).Select(i => i.Symbol).ToList();

                    this.DecodedText = FDT.DecodedTextFrequencyTable(table, this.DecodedText, this.FDTfileName, this.FDTlang);

                   
                    this.FDTdecodedTextBox.Text = this.DecodedText;
                    this.ChangeReplaceAlphabet(this.engAlphabet);
                }
            }
            
        }

        public List<(char Symbol, float CalcPercent, float StandartPercent, float Dif)> GetTable(string AllSymbols, string Lang)
        {

            
            var frequencyTabel = new List<(char, float, float, float)>();

            float CountAllSymbols = AllSymbols.Length;
            float CountSymbol, CalculatePercent, Dif;
            for (int i = 0; i < Frequency.standartFrequencyTable[Lang].Count(); i++)/////////////////////////////////////
            {
                CountSymbol = AllSymbols.Where(sym => sym == Frequency.standartFrequencyTable[Lang][i].Symbol).Count();
                CalculatePercent = (float)Math.Round((CountSymbol / CountAllSymbols)*100, 3);
                Dif = (float)Math.Round(Math.Abs(CalculatePercent-Frequency.standartFrequencyTable[Lang][i].StandartPercent), 3);
                frequencyTabel.Add((Frequency.standartFrequencyTable[Lang][i].Symbol, CalculatePercent, Frequency.standartFrequencyTable[Lang][i].StandartPercent, Dif));
            }
            return frequencyTabel.OrderBy(x => x.Item1.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();

        }

    }
}
