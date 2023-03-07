﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Form1
    {
        private void ByAlphabetRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ModeSorting)
                this.table = this.table.OrderByDescending(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
            else
                this.table = this.table.OrderBy(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
            this.ShowFrequenchyTableTextBox.Text = Frequency.BuildTable(table);
        }

        private void ByCalculatetPercentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ModeSorting)
                this.table = this.table.OrderByDescending(x => x.CalcPercent).ToList();
            else
                this.table = this.table.OrderBy(x => x.CalcPercent).ToList();

            this.ShowFrequenchyTableTextBox.Text = Frequency.BuildTable(table);

        }


        private void ByStandartPercentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ModeSorting)
                this.table = this.table.OrderByDescending(x => x.StandartPercent).ToList();
            else
                this.table = this.table.OrderBy(x => x.StandartPercent).ToList();
            this.ShowFrequenchyTableTextBox.Text = Frequency.BuildTable(table);
        }

        private void SortByGrowthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ModeSorting = false;
            if (this.ByAlphabetRadioButton.Checked)
                this.ByAlphabetRadioButton_CheckedChanged(sender, e);
            else if (this.ByCalculatetPercentRadioButton.Checked)
                this.ByCalculatetPercentRadioButton_CheckedChanged(sender, e);
            else if (this.ByStandartPercentRadioButton.Checked)
                this.ByStandartPercentRadioButton_CheckedChanged(sender, e);
        }

        private void SortInDescendingOrderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ModeSorting = true;
            if (this.ByAlphabetRadioButton.Checked)
                this.ByAlphabetRadioButton_CheckedChanged(sender, e);
            else if (this.ByCalculatetPercentRadioButton.Checked)
                this.ByCalculatetPercentRadioButton_CheckedChanged(sender, e);
            else if (this.ByStandartPercentRadioButton.Checked)
                this.ByStandartPercentRadioButton_CheckedChanged(sender, e);
        }
    }
}
