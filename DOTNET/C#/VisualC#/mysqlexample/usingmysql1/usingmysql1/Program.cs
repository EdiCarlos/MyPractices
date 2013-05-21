using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using usingmysql1.mydatabaseDataSetTableAdapters;
using usingmysql;


namespace usingmysql1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Myclass cl = new Myclass();
            //cl.showValues();
            //mycalculationClass.CalculationClass.Add(10, 10);
            
        }
    }
    class someclass
    {
        public static void showDetails()
        {
            mytableTableAdapter adapter = new mytableTableAdapter();
            mydatabaseDataSet set = new mydatabaseDataSet();
            adapter.Fill(set.mytable);
            DataRow row = (DataRow)set.mytable.Rows[0];
            Console.WriteLine(row[1]);
        }
    }
}
