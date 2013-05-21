using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;

namespace ExecutingWeblogQueries
{
    class Program
    {
        public AutoResetEvent[] autoEvent;
        public Program()
        {
            int cnt = 0;
            QueriesListTableAdapters.QueriesListTableAdapter adap = new ExecutingWeblogQueries.QueriesListTableAdapters.QueriesListTableAdapter();
            QueriesList.QueriesListDataTable qtable = new QueriesList.QueriesListDataTable();
            adap.Fill(qtable);
            autoEvent = new AutoResetEvent[1];
            foreach (QueriesList.QueriesListRow row in qtable.Rows)
            {
                autoEvent[0] = new AutoResetEvent(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(RunQuery), row);
            }
            Console.ReadLine();
        }
        static int count = 0;
        static void Main(string[] args)
        {
            Program prog = new Program();
            WaitHandle.WaitAll(prog.autoEvent);
        }
        public void RunQuery(object obj)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "SVBMN14GLBSM4K";
            builder.Pooling = true;
            builder.MaxPoolSize = 300;
            builder.InitialCatalog = "Metrics";
            builder.IntegratedSecurity = true;
            builder.ConnectTimeout = 1000;
            SqlConnection con = new SqlConnection(builder.ConnectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.Add("@DATE", System.Data.SqlDbType.DateTime);
            cmd.CommandTimeout = 1200;
            QueriesList.QueriesListRow rowObj = (QueriesList.QueriesListRow)obj;
            cmd.CommandText = rowObj.Query;
            cmd.Parameters["@DATE"].Value = "8/19/2010";
            Console.WriteLine("{0} = {1} = {2}", rowObj.ReportRowID, cmd.ExecuteScalar(), count);
            Monitor.Enter(this);
            count++;
            if (count == 67)
            {
                autoEvent[0].Set();
            }
            Monitor.Exit(this);
            con.Close();
        }
    }
}
//class ExecuteWithThread
//{
//    QueriesList.QueriesListRow row;
//    public ExecuteWithThread(QueriesList.QueriesListDataTable qtable)
//    {
//        //row = qtable.Rows;
//        //ThreadPool.QueueUserWorkItem(new WaitCallback(RunQuery), row);

//    }
//    public void RunQuery(object obj)
//    {

//    }
//}

