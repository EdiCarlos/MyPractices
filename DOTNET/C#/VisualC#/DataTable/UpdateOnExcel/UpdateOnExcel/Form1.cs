using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections;

namespace UpdateOnExcel
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter adapter;
        System.Data.DataTable table;
        DataSet set;
        OleDbConnection con;
        public Form1()
        {
            //RemoveFirstRowOfExcel(@"d:\documents and settings\axkhan2\desktop\excel.xls");
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source='d:\documents and settings\axkhan2\desktop\excel.xls'; Extended Properties=Excel 8.0;");
            con.Open();
            table = new System.Data.DataTable();
            adapter = new OleDbDataAdapter("select id, col2, col3, col4, col5 from [data$]", con);
            //adapter.InsertCommand = new OleDbCommand("insert into [data$](col1, col2, col3, col4, col5) values(?, ?, ?, ?, ?)",con);
            set = new DataSet();
            adapter.Fill(set);
            adapter = CreateInsertQuery("", set.Tables[0]);//new OleDbCommand("insert into [data$](id, col2, col3, col4, col5) values(?, ?, ?, ?,?)", con);

            InitializeComponent();
            //dataGridView1.DataSource = table;
            //axSpreadsheet1.DataSource = (msdatasrc.DataSource)table;
            dataGridView1.DataSource = set.Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }
        public void ShowDataInDataGrid()
        {
        }
        public static OleDbDataAdapter CreateInsertQuery(string filePath, System.Data.DataTable resultSet)
        {
            string parameters = string.Empty;
            string fields = string.Empty;
            OleDbDataAdapter targetDbfDataAdapter = new OleDbDataAdapter();
            foreach (DataColumn TrnDbfColumn in resultSet.Columns)
            {
                parameters += ",?";
                fields = fields + "," + "[" + TrnDbfColumn.ColumnName + "]";
            }
            string updateString = string.Empty;
            foreach (DataColumn column in resultSet.Columns)
            {
                updateString += ", [" + column.ColumnName + "] = ? ";
            }
            targetDbfDataAdapter.SelectCommand = new OleDbCommand();

            targetDbfDataAdapter.InsertCommand = new OleDbCommand();
            targetDbfDataAdapter.UpdateCommand = new OleDbCommand();
            targetDbfDataAdapter.InsertCommand.Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source='d:\documents and settings\axkhan2\desktop\excel.xls'; Extended Properties=Excel 8.0;");
            targetDbfDataAdapter.SelectCommand.Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source='d:\documents and settings\axkhan2\desktop\excel.xls'; Extended Properties=Excel 8.0;");
            targetDbfDataAdapter.UpdateCommand.Connection = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;Data Source='d:\documents and settings\axkhan2\desktop\excel.xls'; Extended Properties=Excel 8.0;");

            targetDbfDataAdapter.InsertCommand.CommandText = "insert into [data$]" + "(" + fields.TrimStart(',') + ") values(" + parameters.TrimStart(',') + ")";
            targetDbfDataAdapter.SelectCommand.CommandText = "select " + fields.TrimStart(',') + " from [data$]";
            targetDbfDataAdapter.UpdateCommand.CommandText = "update [data$] set " + updateString.TrimStart(',') + " where [id] = ?";
            // targetDbfDataAdapter.InsertCommand.CommandText = "insert into [data$] values(" + parameters.TrimStart(',') + ")";
            foreach (DataColumn TrnDbfColumn in resultSet.Columns)
            {
                switch (TrnDbfColumn.DataType.FullName)
                {
                    case "System.String":
                        TrnDbfColumn.DefaultValue = "";
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.VarChar, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.SelectCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.VarChar, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.UpdateCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.VarChar, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);

                        break;
                    case "System.DateTime":
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Date, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.SelectCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Date, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.UpdateCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.VarChar, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);

                        break;
                    case "System.Int16":
                    case "System.Int32":
                    case "System.Int64":
                    case "System.Decimal":
                    case "System.Double":
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Decimal, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.SelectCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Decimal, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.UpdateCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Decimal, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);

                        TrnDbfColumn.DefaultValue = 0;
                        break;
                    case "System.Boolean":
                        targetDbfDataAdapter.InsertCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Boolean, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.SelectCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Boolean, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);
                        targetDbfDataAdapter.UpdateCommand.Parameters.Add(TrnDbfColumn.ColumnName, OleDbType.Decimal, TrnDbfColumn.MaxLength, TrnDbfColumn.ColumnName);


                        TrnDbfColumn.DefaultValue = false;
                        break;
                    default:
                        throw new Exception("Intialisation not provided for data type " + TrnDbfColumn.DataType.FullName + " Column Name :" + TrnDbfColumn.ColumnName);
                }
            }
            return targetDbfDataAdapter;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                foreach(object cmd in CreateUpdateCommandFromGrid(set.Tables[0]))
                {
                    adapter.UpdateCommand = (OleDbCommand)cmd;
                    adapter.UpdateCommand.ExecuteNonQuery();
        
                }
        }
        ~Form1()
        {
            con.Close();
        }
        public object [] CreateUpdateCommandFromGrid(System.Data.DataTable resultSet)
        {
            ArrayList list = new ArrayList();
            string updateString = string.Empty;
            foreach (DataColumn column in resultSet.Columns)
            {
                if (column.ColumnName == "id")
                {
                    continue;
                }
                updateString += ", [" + column.ColumnName + "] = ? ";
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string upString = string.Empty;
                string wherecondition = string.Empty;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.Name == "id")
                    {
                        wherecondition = " where [" + column.Name + "] = ?;";
                        continue;
                    }
                    upString += ", [" + column.Name + "] = ?";
                }
                OleDbCommand command = new OleDbCommand("update [data$] set " + upString.TrimStart(',') + wherecondition, con);
                int count = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null)
                    {
                        break;
                    }
                    if (cell.ColumnIndex == 0)
                    {
                        continue;
                    }

                    OleDbParameter parameter = new OleDbParameter("A"+count++.ToString(), OleDbType.VarChar);
                    if(cell.Value != null)
                    parameter.Value = cell.Value.ToString();
                    command.Parameters.Add(parameter);
                }
                OleDbParameter whereParam = new OleDbParameter("where", OleDbType.VarChar);
                if (row.Cells[0].Value != null)
                {
                    whereParam.Value = row.Cells[0].Value.ToString();
                    command.Parameters.Add(whereParam);
                    list.Add(command);
                }
            }

            return list.ToArray();
        }
        private bool RemoveFirstRowOfExcel(string excelPath, string findWhatInHeader, string findWhatInRow)
        {
            ApplicationClass myMastinvExcel = new ApplicationClass();
            bool removed = false;
            try
            {
                WorkbookClass myWorkbook = (WorkbookClass)myMastinvExcel.Workbooks.Open(excelPath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                Worksheet myWorksheet; //= (Worksheet)myWorkbook.Worksheets.Count;
                int countVar = 0;
                while( countVar <= myWorkbook.Worksheets.Count)
                {
                    Worksheet tempWorkSheet = (Worksheet)myWorkbook.Worksheets.get_Item(countVar);
                    if (tempWorkSheet.Name == "data")
                    {
                        myWorksheet = tempWorkSheet;
                    }
                    countVar++;
                }
                Range HeaderColumns = myWorksheet.get_Range("A1", "");
                HeaderColumns.Select();
                HeaderColumns.get_End(XlDirection.xlToRight);
                HeaderColumns.Select();
                HeaderColumns.Find(findWhatInHeader, Missing.Value, false, XlLookAt.xlWhole, XlSearchOrder.xlByColumns, XlSearchDirection.xlNext, false, false, 
                Range rowTodelete = myWorksheet.get_Range("A2", "A2");
                rowTodelete.EntireRow.Delete(Missing.Value);
                myWorksheet.get_Range("A2", "A2").Select();
                myWorkbook.Save();
                myMastinvExcel.Quit();
                myWorkbook = null;
                myMastinvExcel = null;
                removed = true;
            }
            catch (Exception ex)
            {
                myMastinvExcel.Quit();
            }
            return removed;
        }
    }
}
