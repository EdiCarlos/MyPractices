using System;
interface IMyDataSet
{
    void FillDataSet(string query);
    System.Data.Odbc.OdbcConnection MyConnection { get; set; }
    System.Data.DataSet Mytbset { get; set; }
    System.Data.Odbc.OdbcConnection OpenConnection();
}
