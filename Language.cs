using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    partial class Form1
    {
        private void InterfaceLangUa_Click(object sender, EventArgs e)
        {
            this.InterfaceLangUa.Checked = true;
            this.InterfaceLangEn.Checked = false;

            this.Text = "Частотний аналіз";

            this.InterfaceLangEn.Text = "Англіська";
            this.InterfaceLangUa.Text = "Українська";

            this.LanguageToolStripMenuItem.Text = "Мова інтерфейсу";
            this.importTable.Text = "Імпортувати таблицю";
            this.SaveTable.Text = "Зберегти Таблицю";

            this.ChooseFileButton.Text = "Вибрати файл";
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.DoItButton.Text = "СТАРТ";
            this.ReturnToChangeLangButton.Text = "Повернутися до вибору мови";
            this.ReturnToChangeLangButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);


            this.SelectLangFileLabel.Text = "Виберіть мову у вибраному файлі";
            this.isUkFile.Text = "Українська";
            this.isEnFile.Text = "Англіька";

            this.SelectSortingLabel.Text = "Виберіть сортування в частотній таблиці";
            this.ByAlphabetRadioButton.Text = "за алфівітом";
            this.ByCalculatetPercentRadioButton.Text = "за порахованими відсотками";
            this.ByStandartPercentRadioButton.Text = "за еталоними відсотками";

            this.SortByGrowthRadioButton.Text = "за зростанням";
            this.SortInDescendingOrderRadioButton.Text = "за спаданням";

            this.CompareTablesButton.Text = "Порівняти";
            this.CompareTipString = "Це значення показує наскільки вирахувана таблиця частот \n" +
                "є близька до еталоної таблиці частот.\n" +
                "Чим ближче значення до 1 тим вони більш схожі.";
        }

        private void InterfaceLangEn_Click(object sender, EventArgs e)
        {
            this.InterfaceLangUa.Checked = false;
            this.InterfaceLangEn.Checked = true;

            this.Text = "Frequency analysis";

            this.InterfaceLangEn.Text = "English";
            this.InterfaceLangUa.Text = "Ukrainian";

            this.LanguageToolStripMenuItem.Text = "Language interface";
            this.importTable.Text = "Import Table";
            this.SaveTable.Text = "Save Table";

            this.ChooseFileButton.Text = "Select File";
            this.ChooseFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.DoItButton.Text = "ENTER";
            this.ReturnToChangeLangButton.Text = "Return to select lang";
            this.ReturnToChangeLangButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            this.SelectLangFileLabel.Text = "Select language in selected file";
            this.isUkFile.Text = "Ukrainian";
            this.isEnFile.Text = "English";

            this.SelectSortingLabel.Text = "Select sorting frequency table";
            this.ByAlphabetRadioButton.Text = "by alphabet";
            this.ByCalculatetPercentRadioButton.Text = "by calculated percentage";
            this.ByStandartPercentRadioButton.Text = "by standart percentage";

            this.SortByGrowthRadioButton.Text = "by growth";
            this.SortInDescendingOrderRadioButton.Text = "by descending";

            this.CompareTablesButton.Text = "Сompare";
            this.CompareTipString = "This value shows how close the calculated frequency table\n" +
                "is to the standart frequency table.\n" +
                " The closer the value is to 1, the more similar they are.";
            //------------------------------------------------------
        }
    }
}
