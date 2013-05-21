using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ex = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Reflection;

namespace ExcelReader1
{
    public partial class WriteToExcel : Form
    {
        string filename = String.Empty;
        public WriteToExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                filename = openFileDialog1.FileName;
            }
        }
        public void Write2Excel(string filename)
        {
            ex.Application appObj = new Microsoft.Office.Interop.Excel.Application();
            ex.Workbook workbook = appObj.Workbooks.Open(filename, Missing.Value, false, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            ex.Sheets sheets = workbook.Worksheets;
            ex.Worksheet wrksheet = (ex.Worksheet)sheets.get_Item(1);
            ex.Range range1 = (ex.Range)wrksheet.Rows.get_Range("A2", "A2");
           range1.EntireRow.Delete(Missing.Value);
           //ex.Range rng = (ex.Range)wrksheet.Rows.Select();
            //rng.Select();
            //rng.EntireRow.Delete(System.Reflection.Missing.Value);
            //rng.Delete();
            //int lastrow  = wrksheet.Cells.Find("*", Missing.Value, Missing.Value, Missing.Value, ex.XlSearchOrder.xlByRows, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious, Missing.Value, Missing.Value, Missing.Value).Row;
            //int currentrow = lastrow + 1;
            //wrksheet.get_Range("a" + currentrow, Missing.Value).Value2 = DateTime.Now.ToShortDateString();
            //wrksheet.get_Range("b" + currentrow, Missing.Value).Value2 = "Post Audit";
            //wrksheet.get_Range("d" + currentrow, Missing.Value).Value2 = "filename";
            //wrksheet.get_Range("h" + currentrow, Missing.Value).Value2 = DateTime.Now.ToShortDateString();

            workbook.Save();
            //workbook.Close(true, filename, Missing.Value);
            appObj.Quit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Write2Excel(filename);
        }
    }
}
