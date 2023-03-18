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

        private bool ModeSorting { get; set; } = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}