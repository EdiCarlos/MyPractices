using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace SupremeTransport
{
    class SqlBillId
    {
        static string constr = "Data Source=.;Initial Catalog=supremetemp;Integrated Security=True";
        public SqlBillId()
        {
        }
        public static void getBillID(out int id)
        {
            id = 0;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select sup.getbillid()", con);
                id = (int)cmd.ExecuteScalar();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
       
    }
}
