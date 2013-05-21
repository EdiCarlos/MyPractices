using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using usingmysql.DataSet1TableAdapters;

namespace usingmysql
{
   public class Myclass
    {
        usingmysql.DataSet1TableAdapters.DataTable2TableAdapter adapter;
        
        public Myclass()
        {
            adapter = new DataTable2TableAdapter();
        }
        public void showValues()
        {
            DataSet1 set = new DataSet1();
            adapter.Fill(set.DataTable2);
            DataRow [] arrRow = set.DataTable2.Select("fname = 'arif'");
            DataRow row = arrRow[0];
            Console.WriteLine(row[1]);
        }
        
    }
}
