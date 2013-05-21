using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace VPFExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<DataRow> ie = DbClass.GetData();

            var result = from iq in ie where iq["empid"].ToString().Trim() == "1" select iq;
            foreach (var item in result)
            {
                item["name"] = "afreen";
                item.AcceptChanges();
                DataRow[] row = { item };
                DbClass.mainAdapter.Update(row);
            }
        }
    }
    class DbClass
    {
        public static OleDbDataAdapter mainAdapter;
        public static IEnumerable<DataRow> GetData()
        {
            string tablePath = @"D:\temp\VisualC#\LINQ\LinqExample\employeedt.dbf";
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tablePath, @"Provider=VFPOLEDB.1;Data Source='D:\temp\VisualC#\LINQ\LinqExample\employeedt.dbf';Collating Sequence=MACHINE");
            DataTable table = new DataTable();
            DataSet set = new DataSet();
            adapter.Fill(set);
            table = set.Tables[0];
            mainAdapter = adapter;
            //CreateInsertQuery(table, ref mainAdapter, tablePath);
            mainAdapter.UpdateCommand = new OleDbCommand("update " + tablePath + " set name = ?, state = ?, city = ?, country = ? where empid = ?");
            mainAdapter.UpdateCommand.Parameters.Add("@name", OleDbType.Char, 40, "name");
            mainAdapter.UpdateCommand.Parameters.Add("@state", OleDbType.Char, 40, "state");
            mainAdapter.UpdateCommand.Parameters.Add("@city", OleDbType.Char, 40, "city");
            mainAdapter.UpdateCommand.Parameters.Add("@country", OleDbType.Char, 40, "country");
           // mainAdapter.UpdateCommand.Parameters.Add("@empid", OleDbType.Integer, 4, "empid").SourceVersion = DataRowVersion.Original;
            mainAdapter.UpdateCommand.Connection = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source='D:\temp\VisualC#\LINQ\LinqExample\employeedt.dbf';Collating Sequence=MACHINE");
            mainAdapter.InsertCommand = new OleDbCommand("insert into " + tablePath + " {?, ?, ?, ?);");
            mainAdapter.InsertCommand.Connection = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source='D:\temp\VisualC#\LINQ\LinqExample\employeedt.dbf';Collating Sequence=MACHINE");
            return table.AsEnumerable();
        }
        private static  void CreateInsertQuery(DataTable resultSet, ref OleDbDataAdapter targetDbfDataAdapter, string tablePath)
        {
            string parameters = string.Empty;
            string fields = string.Empty;
            foreach (DataColumn TrnDbfColumn in resultSet.Columns)
            {
                parameters += ",?";
                fields = fields + "," + "[" + TrnDbfColumn.ColumnName + "]";
            }
            targetDbfDataAdapter.InsertCommand = new OleDbCommand();
            //targetDbfDataAdapter.InsertCommand.Connection = new OleDbConnection(connectionString);
            targetDbfDataAdapter.InsertCommand.CommandText = "insert into "+tablePath + "(" + fields.TrimStart(',') + ") values(" + parameters.TrimStart(',') + ")";
            // targetDbfDataAdapter.InsertCommand.CommandText = "insert into [data$] values(" + parameters.TrimStart(',') + ")";
            foreach (DataColumn TrnDbfColumn in resultSet.Columns)
            {
                switch (TrnDbfColumn.DataType.FullName)
                {
                    case "System.String":
                        TrnDbfColumn.DefaultValue = "";
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.VarChar, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        break;
                    case "System.DateTime":
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Date, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        break;
                    case "System.Int16":
                    case "System.Int32":
                    case "System.Int64":
                    case "System.Decimal":
                    case "System.Double":
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Decimal, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        TrnDbfColumn.DefaultValue = 0;
                        break;
                    case "System.Boolean":
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Boolean, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        TrnDbfColumn.DefaultValue = false;
                        break;
                    default:
                        throw new Exception("Intialisation not provided for data type " + TrnDbfColumn.DataType.FullName + " Column Name :" + TrnDbfColumn.ColumnName);
                }
            }
        }
    }
}
