using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace SampleDataBlock
{
    class Program
    {
        public static string GetConnectionString()
        {
            return @"Data Source=wd-xpa6gcaej037;Initial Catalog=SyncadaDB;Integrated Security=True";
        }
        static void Main(string[] args)
        {
           
        }
        public void UseOfDataSet()
        {
            SqlDatabase sqlDb = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(GetConnectionString());
            //IDataReader reader =  sqlDb.ExecuteReader(CommandType.Text, "Select * from Syncada.Location");
            DbCommand command = new System.Data.SqlClient.SqlCommand();
            command.CommandText = "select * from Syncada.Location";
            command.CommandType = CommandType.Text;
            DataSet locationSet = new DataSet();
            sqlDb.LoadDataSet(command, locationSet, "Location");
            //var tb = locationSet.Tables[0].AsEnumerable().Select(field => field);
            var tb1 = from loc in locationSet.Tables[0].AsEnumerable().Select(field => field) select new { LocationID = loc["LocationID"].ToString(), Street1 = loc["Street1"].ToString() };
            foreach (var item in tb1)
            {
                Console.WriteLine(item.LocationID);
            }
        }
    }
    static class SingleTonEDB
    {
        static readonly SqlDatabase database = new SqlDatabase();
        
        SingleTonEDB()
        {

        }
        
    }
}
