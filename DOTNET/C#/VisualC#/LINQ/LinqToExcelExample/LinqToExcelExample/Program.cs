using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace LinqToExcelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\t\edp\Processed\mastinv_47100_4627900.xls";
            string connectionstring = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + filePath + ";Extended Properties=Excel 8.0;";
            DataTable table = new DataTable();
            OleDbConnection con = new OleDbConnection(connectionstring);
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter("Select * from [data$]", con);
            OleDbCommand InsertC = new OleDbCommand("insert into [data$]([File name], [client], [batch], [scac], [carracct], [invoice number], [invoice date], [currency], [billed amount], [vat]) values('123', '123', '123', '123', '123', '123', '123','123', '123', '1234')", con);
            adap.InsertCommand = InsertC;
            adap.FillSchema(table, SchemaType.Mapped);
            adap.UpdateCommand = new OleDbCommand("update [data$] set batch = 'aasdf' where [file name] = '47100_4627900_00004.PDF'", con);
            //adap.UpdateCommand.ExecuteNonQuery();
            adap.InsertCommand.ExecuteNonQuery();
            con.Close();

        }
    }
}
