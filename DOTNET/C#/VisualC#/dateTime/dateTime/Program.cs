using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //dateTime.DataSet1TableAdapters.table1TableAdapter table = new dateTime.DataSet1TableAdapters.table1TableAdapter();
            //table.Insert("arif", "khan", "hasan", "1988-01-10", "100.00");
            //Console.ReadLine();

            OleDbConnection con = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=D:\Documents and Settings\axkhan2\Desktop\table\table1.dbf");
            con.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(@"select * from 'D:\Documents and Settings\axkhan2\Desktop\table\table1.dbf'", con);
            OleDbCommandBuilder build = new OleDbCommandBuilder(adapt);
            DataSet set = new DataSet();
            adapt.Fill(set);
            DataTable table = set.Tables[0];
            DataRow row = table.NewRow();
            row["firstname"] = "arifkhan";
            row["lastname"] = "khan";
            row["middlename"] = "mname";
            row["dob"] = DateTime.Now;
            row["amount"] = 100;
            table.Rows.Add(row);
           
            //adapt.Update(table);
            //adapt.UpdateCommand =  build.GetUpdateCommand();
            adapt.Update(table);
            //cmd.ExecuteNonQuery();
        }
    }
}
