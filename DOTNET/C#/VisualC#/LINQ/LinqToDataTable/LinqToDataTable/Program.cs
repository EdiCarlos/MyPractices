using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace LinqToDataTable
{
    class Program
    {
       static Hashtable t1;

        public static Hashtable T1
        {
            get { return t1; }
            set { t1 = value; }
        }
        static void Main(string[] args)
        {
            //OleDbConnection con = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source='d:\t\g\test\process\'");
            //OleDbDataAdapter adapter = new OleDbDataAdapter("select * from pdfdetail.dbf", con);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //IEnumerable<DataRow> row = table.AsEnumerable();
            //foreach (DataRow rw in row)
            //{
            //    Console.WriteLine(rw[1]);
            //    if (rw[1].ToString() == "7840")
            //        rw.Delete();
            //}
            //table.AcceptChanges();
            //adapter.Update(table);
            Hashtable table = new Hashtable();
            table.Add("1", "arif");
            table.Add("2", "arif");
            table.Add("3", "arif");
            table.Add("4", "arif");
            table.Add("5", "arif");

            object obj = table;//new Hashtable();
            //object obj1 = table;
            //T1 = (Hashtable)obj;
            UseHashTable();
        }
        public static void UseHashTable()
        {
            Hashtable gohashTable = new Hashtable();
            //if (T1 != null)
            //{
                gohashTable = (Hashtable)T1;
            //}
            foreach (DictionaryEntry entry in T1)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
