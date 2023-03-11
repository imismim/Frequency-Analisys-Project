using System;
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
            if (this.SortingUaTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableUa = this.tableUa.OrderByDescending(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableUa = this.tableUa.OrderBy(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableUaTextBox.Text = Frequency.BuildTable(tableUa);
            }
            else if (this.SortingRuTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableRu = this.tableRu.OrderByDescending(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableRu = this.tableRu.OrderBy(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableRuTextBox.Text = Frequency.BuildTable(tableRu);
            }
            else if (this.SortingEnTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableEn = this.tableEn.OrderByDescending(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableEn = this.tableEn.OrderBy(x => x.Symbol.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableEnTextBox.Text = Frequency.BuildTable(tableEn);
            }

        }

        private void ByCalculatetPercentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SortingUaTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableUa = this.tableUa.OrderByDescending(x => x.CalcPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableUa = this.tableUa.OrderBy(x => x.CalcPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableUaTextBox.Text = Frequency.BuildTable(tableUa);
            }
            else if (this.SortingRuTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableRu = this.tableRu.OrderByDescending(x => x.CalcPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableRu = this.tableRu.OrderBy(x => x.CalcPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableRuTextBox.Text = Frequency.BuildTable(tableRu);
            }
            else if (this.SortingEnTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableEn = this.tableEn.OrderByDescending(x => x.CalcPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableEn = this.tableEn.OrderBy(x => x.CalcPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableEnTextBox.Text = Frequency.BuildTable(tableEn);
            }
        }


        private void ByStandartPercentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SortingUaTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableUa = this.tableUa.OrderByDescending(x => x.StandartPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableUa = this.tableUa.OrderBy(x => x.StandartPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableUaTextBox.Text = Frequency.BuildTable(tableUa);
            }
            else if (this.SortingRuTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableRu = this.tableRu.OrderByDescending(x => x.StandartPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableRu = this.tableRu.OrderBy(x => x.StandartPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableRuTextBox.Text = Frequency.BuildTable(tableRu);
            }
            else if (this.SortingEnTableRadioButton.Checked)
            {
                if (this.ModeSorting)
                    this.tableEn = this.tableEn.OrderByDescending(x => x.StandartPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                else
                    this.tableEn = this.tableEn.OrderBy(x => x.StandartPercent.ToString(), StringComparer.Create(new CultureInfo("uk-UA"), true)).ToList();
                this.DisplayTableEnTextBox.Text = Frequency.BuildTable(tableEn);
            }
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
