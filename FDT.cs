using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    internal class FDT
    {
        public static string ReadFile(string path)
        {
            string text = string.Empty;
            using (StreamReader sr = new StreamReader(path, Encoding.ASCII))
            {
                text = sr.ReadToEnd();
            }
            return text;
        }

        public static List<(char letter1, char letter2)> ListLettersChanged(in string path, in string lang)
        {

            var letters = new List<(char letter1, char letter2)>();
            var frequencyTable = Frequency.FrequencyTableList(path, lang).OrderByDescending(i=>i.CalcPercent).Select(i=>i.Symbol).ToList();
            for (int i = 0; i < Frequency.standartFrequencyTable[lang].Count(); i++)
            {
                letters.Add((frequencyTable[i], Frequency.standartFrequencyTable[lang][i].Symbol));
            }
            return letters;
        }

        public static string DecodedText(string text, in string path, in string lang) 
        {
            var decodedText = string.Empty;
            var letters = ListLettersChanged(path, lang);
            var letter1 = letters.Select(i=>char.ToLower(i.letter1)).ToList();
            var letter2 = letters.Select(i=>char.ToLower(i.letter2)).ToList();

            foreach (var item in text.Select(i => char.ToLower(i)))
            {
                if (letter1.Contains(item))
                {
                    decodedText += letter2[letter1.IndexOf(item)];
                }
                else
                {
                    decodedText += item;
                }
            }


            return decodedText;
        }

        public static string DecodedTextFrequencyTable(List<char> table, in string text, string path, string lang)
        {
            var decodedText = string.Empty;

            var letters = new List<(char letter1, char letter2)>();

            var frequencyTable = Frequency.FrequencyTableList(path, lang).OrderByDescending(i => i.CalcPercent).Select(i => i.Symbol).ToList();

            for (int i = 0; i < Frequency.standartFrequencyTable[lang].Count(); i++)
            {
                letters.Add((frequencyTable[i], table[i]));
            }

            var letter1 = letters.Select(i => char.ToLower(i.letter1)).ToList();
            var letter2 = letters.Select(i => char.ToLower(i.letter2)).ToList();

            foreach (var item in text.Select(i => char.ToLower(i)))
            {
                if (letter1.Contains(item))
                {
                    decodedText += letter2[letter1.IndexOf(item)];
                }
                else
                {
                    decodedText += item;
                }
            }
            return decodedText;
        }

        public static string OneTimeReplaceLetter(string text, in char letter1, in char letter2)
        {
            string changedText = string.Empty;
            foreach (var item in text.Select(i => char.ToLower(i)))
            {
                if (item == letter1)
                    changedText += letter2;
                else if (item == letter2)
                    changedText += letter1;
                else
                   changedText += item;
            }
            
            return changedText;

        }

        public static void SaveLogFile(in string path, in string logReplace)
        {
            using (var wr = new StreamWriter(path))
            {
                wr.Write(logReplace);
            }
        }
    }
}
