using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using tool = Microsoft.Office.Tools.Excel;


namespace SortCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"d:\excel1\myfile.xls";

            Application objExcel = new Application();
            Workbook workBook = objExcel.Workbooks.Add(Missing.Value);
            if (!File.Exists(filename))
            {
                workBook.SaveAs(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlExclusive, Missing.Value,
    Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            }
            else
            {
                workBook = objExcel.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            }
            Sheets sheets = workBook.Worksheets;
            Worksheet worksheet = (Worksheet)sheets.get_Item(1);
            worksheet.get_Range("A1", Missing.Value).Value2 = "A";
            worksheet.get_Range("A2", Missing.Value).Value2 = "B";
            worksheet.get_Range("A3", Missing.Value).Value2 = "C";
            worksheet.get_Range("A4", Missing.Value).Value2 = "D";
            worksheet.get_Range("A5", Missing.Value).Value2 = "E";
            Range range = worksheet.get_Range("A1", "A5");
            range.Sort(range.Columns[1,Missing.Value], XlSortOrder.xlDescending, Missing.Value, Missing.Value, XlSortOrder.xlAscending, Missing.Value, XlSortOrder.xlAscending, XlYesNoGuess.xlGuess, Missing.Value, Missing.Value, XlSortOrientation.xlSortColumns, XlSortMethod.xlPinYin, XlSortDataOption.xlSortNormal, XlSortDataOption.xlSortNormal, XlSortDataOption.xlSortNormal);

            workBook.Save();
            objExcel.Quit();
            
        }
    }
}
