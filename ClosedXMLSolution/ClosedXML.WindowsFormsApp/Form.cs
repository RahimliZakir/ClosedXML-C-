using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ClosedXML.WindowsFormsApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnWriteToExcel_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();

            var worksheet = workbook.AddWorksheet("Our WorkSheet");

            worksheet.Cell("A1").Value = richTextBox.Text;

            workbook.SaveAs("FirstWork.xlsx");

            MessageBox.Show("Məlumat Excel'ə uğurla yazılmışdır.", "Uğurlu"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDiffWriteToExcel_Click(object sender, EventArgs e)
        {
            var workbook = new XLWorkbook();

            var worksheet = workbook.AddWorksheet("SecondWorkSheet");

            var range = worksheet.Range("A1:F1");

            range.Value = richTextBox.Text;

            range.Style.Fill.BackgroundColor = XLColor.AmericanRose;

            range.Merge();

            workbook.SaveAs("SecondWork.xlsx");

            MessageBox.Show("Məlumat Excel'ə uğurla yazılmışdır.", "Uğurlu"
    , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
