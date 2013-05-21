using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace DeleteRowFromExcel
{
    public partial class Form1 : Form
    {
        object missing;
        ApplicationClass appClass;

        public Form1()
        {
            //missing = Missing.Value;
            //InitializeComponent();
            //appClass = new ApplicationClass();
            //Workbook myWorkbook = (Workbook)appClass.Workbooks.Open(@"d:\documents and settings\axkhan2\Desktop\excel.xls", missing, false, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
            //Worksheet myWorksheet = new Worksheet();
            //int countVar = 1;
            //while (countVar <= myWorkbook.Worksheets.Count)
            //{
            //    Worksheet tempWorkSheet = (Worksheet)myWorkbook.Worksheets.get_Item(countVar);
            //    if (tempWorkSheet.Name == "data")
            //    {
            //        myWorksheet = tempWorkSheet;
            //        break;
            //    }
            //    countVar++;
            //}
            //Range HeaderRange = (Range)myWorksheet.get_Range("A1", missing);
            //Range columnRange = (Range)HeaderRange.Find("id2", Missing.Value, Missing.Value, XlLookAt.xlWhole, XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false, false, false);
            //columnRange.EntireColumn.Select();
            //Range deleteRange = (Range)columnRange.Find("2", Missing.Value, Missing.Value, XlLookAt.xlWhole, XlSearchOrder.xlByColumns, XlSearchDirection.xlNext, false, false, false);
            //if (deleteRange != null)
            //{
            //    deleteRange.EntireRow.Delete(XlDeleteShiftDirection.xlShiftUp);
            //    string address = columnRange.get_Address(true, true, XlReferenceStyle.xlA1, false, false);
            //    address = address.Replace("$", "");
            //    int lastRow = myWorksheet.Cells.Find("*", Missing.Value, Missing.Value, Missing.Value, XlSearchOrder.xlByRows, Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious, Missing.Value, Missing.Value, Missing.Value).Row;
            //    for (int i = 1; i < lastRow; i++)
            //    {
            //        myWorksheet.get_Range(address.Remove(1, 1)+(i + 1).ToString(), Missing.Value).Value2 = i.ToString();
            //    }
            //}
            //myWorkbook.Save();
            //myWorkbook.Close(true, @"d:\documents and settings\axkhan2\Desktop\excel.xls", false);

            if (DeleteExcelRow.ExcelUtil.DeleteRowFromExcel(@"d:\documents and settings\axkhan2\Desktop\excel.xls", "id2", "1"))
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
        ~Form1()
        {

        }
    }
}
