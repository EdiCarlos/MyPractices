using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace CheckLane
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] laneid = GetFromExcel();
            for (int i = 0; i < laneid.GetUpperBound(0); i++)
            {
                if (IfValueExist(laneid[i]))
                {
                    Console.WriteLine("value exists");
                }
            }
                Console.ReadLine();


        }

        private static bool IfValueExist(string laneid)
        {
            string[] lane = GetFromDataBase();
            foreach (string str in lane)
            {
                if (str.Trim().Equals(lane))
                {
                    return true;
                }
            }
            return false;
        }

        private static string[] GetFromDataBase()
        {
            CheckLane.lanesetTableAdapters.tariff_oceanTableAdapter tableAdapter = new CheckLane.lanesetTableAdapters.tariff_oceanTableAdapter();
            laneset.tariff_oceanDataTable table = new laneset.tariff_oceanDataTable();
            tableAdapter.Fill(table);
            DataTableReader reader = new DataTableReader(table);
            string[] laneid = new string[table.Rows.Count];
            int counter = 0;
            while (reader.Read())
            {
                laneid[counter++] = reader[0].ToString();
            }
            return laneid;
        }

        private static string[] GetFromExcel()
        {

            Excel.Application excelObj = null;
            excelObj = new Excel.Application();
            if (excelObj == null)
            {
                throw new NullReferenceException("excel object is null");
            }
            Excel.Workbook workbook = excelObj.Workbooks.Open(@"D:\documents and settings\axkhan2\APM_2964\Master Air and Ocean Pricing 10_04_02B.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel.Sheets sheets = workbook.Worksheets;
            Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
            //int i = 8, x = 723;
            Excel.Range rng = worksheet.get_Range("C9", "C723");
            string[] laneid = new string[rng.Rows.Count];
            int lne = 0;
            for (int i = 9; i < 723; i++)
            {
                Excel.Range range = (Excel.Range)worksheet.Cells[i, 3];
                laneid[lne++] = range.Cells.Value2.ToString();
            }
            return laneid;
        }
    }
}
