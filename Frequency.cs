using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Frequency
    {
        public static Dictionary<string, List<(char Symbol, float StandartPercent)>> standartFrequencyTable = new Dictionary<string, List<(char Symbol, float StandartPercent)>>()
        {
            { "UA" , new List<(char Symbol, float StandartPercent)>{
                ('О', 11.31f),
                ('Н', 8.11f),
                ('Е', 7.00f),
                ('А', 6.97f),
                ('І', 6.54f),
                ('И', 5.53f),
                ('В', 5.44f),
                ('Т', 4.93f),
                ('Р', 4.33f),
                ('Л', 4.17f),
                ('К', 3.49f),
                ('М', 3.21f),
                ('У', 2.63f),
                ('С', 2.45f),
                ('Д', 2.38f),
                ('Й', 1.86f),
                ('З', 1.47f),
                ('Ж', 1.24f),
                ('Ч', 0.95f),
                ('Б', 0.85f),
                ('Г', 0.84f),
                ('П', 0.79f),
                ('Ш', 0.68f),
                ('Ю', 0.46f),
                ('Я', 0.45f),
                ('Щ', 0.38f),
                ('Є', 0.33f),
                ('Ї', 0.13f),
                ('Ф', 0.11f),
                ('Ь', 0.06f),}},
            { "RU" , new List<(char Symbol, float StandartPercent)>{
                ('О', 9.3f),
                ('Е', 8.5f),
                ('А', 7.9f),
                ('И', 7.8f),
                ('Н', 6.7f),
                ('Т', 6.4f),
                ('С', 5.2f),
                ('Р', 4.8f),
                ('В', 4.5f),
                ('Л', 4.3f),
                ('К', 3.4f),
                ('М', 3.2f),
                ('Д', 2.9f),
                ('П', 2.8f),
                ('У', 2.6f),
                ('Я', 2.1f),
                ('Ы', 1.9f),
                ('Ь', 1.7f),
                ('Г', 1.6f),
                ('З', 1.6f),
                ('Б', 1.5f),
                ('Ч', 1.4f),
                ('Й', 1.2f),
                ('Х', 0.9f),
                ('Ж', 0.7f),
                ('Ш', 0.7f),
                ('Ю', 0.6f),
                ('Ц', 0.4f),
                ('Щ', 0.3f),
                ('Э', 0.3f),
                ('Ф', 0.2f),
                ('Ъ', 0.1f),
                ('Ё', 0.1f)}},
            { "EN" , new List<(char Symbol, float StandartPercent)>{
                ('E', 11.160f),
                ('T', 9.356f),
                ('A', 8.497f),
                ('O', 8.096f),
                ('I', 7.294f),
                ('N', 7.240f),
                ('S', 6.654f),
                ('H', 6.094f),
                ('R', 5.987f),
                ('D', 4.253f),
                ('L', 4.025f),
                ('C', 2.782f),
                ('U', 2.758f),
                ('M', 2.406f),
                ('W', 2.360f),
                ('F', 2.228f),
                ('G', 2.015f),
                ('Y', 1.974f),
                ('P', 1.929f),
                ('B', 1.492f),
                ('V', 0.978f),
                ('K', 0.772f),
                ('J', 0.153f),
                ('X', 0.150f),
                ('Q', 0.095f),
                ('Z', 0.077f)}}
        };



        private static List<char> FileRead(in string NameFile)
        {
            List<char> symbols;
            using (StreamReader sr = new StreamReader(NameFile))
            {
                symbols = sr.ReadToEnd().ToList();
            }
            return symbols.Where(sym => Char.IsLetter(sym)).Select(sym => Char.ToUpper(sym)).ToList();
        }

        public static List<(char Symbol, float CalcPercent, float StandartPercent)> FrequencyTable(in string NameFile,string Lang)
        {

            var AllSymbols = Frequency.FileRead(NameFile);
            var frequencyTabel = new List<(char, float, float)>();

            int CountAllSymbols = AllSymbols.Count;
            int CountSymbol;
            for (int i = 0; i < Frequency.standartFrequencyTable[Lang].Count(); i++ )/////////////////////////////////////
            {
                CountSymbol = AllSymbols.Where(sym => sym == Frequency.standartFrequencyTable[Lang][i].Symbol).Count();
                float CalculatePercent = (float)CountSymbol / (float)CountAllSymbols;
                frequencyTabel.Add((Frequency.standartFrequencyTable[Lang][i].Symbol, (float)Math.Round(CalculatePercent*100, 3), Frequency.standartFrequencyTable[Lang][i].StandartPercent));
            }
            return frequencyTabel.OrderBy(x => x.Item1.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
            
        }

        public static string BuildTable(in List<(char Symbol, float CalcPercent, float StandartPercent)> TableList)
        {
            string TableString = "";
            TableString += "Symbol\tCalculate %\tStandart %" + Environment.NewLine;

            foreach (var item in TableList)
            {
                TableString += $"{item.Symbol}\t{item.CalcPercent}\t\t{item.StandartPercent}"+ Environment.NewLine;
            }
            return TableString;
        }

        public static void SaveTable(in List<(char Symbol, float CalcPercent, float StandartPercent)> table, in string FileNAme)
        {
            try
            {
                using (var sw = new StreamWriter(FileNAme))
                {
                    //var newTable = this.tableUa.OrderBy(i => i.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                    foreach (var item in table)
                    {
                        sw.WriteLine($"{item.Symbol};{item.CalcPercent};{item.StandartPercent}");
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }

        }

        public static List<(char Symbol, float CalcPercent, float StandartPercent)> ImportTable(in string FileName)
        {
            var table = new List<(char, float, float)>();
            try
            {
                using (var sr = new StreamReader(FileName))
                {
                    string AllText = sr.ReadToEnd();
                    var SplitLine = AllText.Split("\r\n").Where(i => i.Length>2).ToList();
                    foreach (var item in SplitLine)
                    {
                        var line = item.Split(';').ToList();
                        table.Add((Char.Parse(line[0]), float.Parse(line[1]), float.Parse(line[2])));
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You are doing something wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false); 
            }
            return table;
        }
    }
}
