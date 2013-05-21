using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Text;

class myexcel
{
public static string constr = "DSN=ground_tariff"; //@"Driver={Microsoft Excel Driver (*.xls)};DriverId=790;Dbq=d:\documents and settings\axkhan2\desktop\437proj\GHEC Rates NL.xls;DefaultDir=d:\documents and settings\axkhan2\desktop\437proj\;";
static void Main()
{
OdbcConnection conxls = new OdbcConnection(constr);
try
{
conxls.Open();
OdbcDataAdapter da = new OdbcDataAdapter("select * from [Sheet1$]", conxls);
DataSet set = new DataSet();
da.Fill(set, "mytariff");
DataTable table = set.Tables[0];
DataView dv = new DataView(table);

// Console.WriteLine(dv[0]);

//InsertData(rdxls);
}
catch(OdbcException od)
{
Console.WriteLine(od.Message);
}
finally
{
conxls.Close();
}
}
public static void InsertData(OdbcDataReader read)
{
string table = @"d:\documents and settings\axkhan2\desktop\437proj\mytariff.dbf";
string query = "insert into " + table + "values (@ln, @orgcity, @destcity, @orgzone, @destzone, @ocountry, @dcountry, @orgcountry, @destcountry)"; //, @origin, @dest, @min, @rate, @rate, @basert, @frmwt, @towt, @cur, @validfrm, @validtill, @filename	
OleDbConnection con = new OleDbConnection(@"Provider=VFPOLEDB.1;Data Source=d:\documents and settings\axkhan2\desktop\437proj\");
try
{
OleDbCommand cmd = new OleDbCommand(query, con);
con.Open();
while(read.Read())
{
cmd.Parameters.Add(new OleDbParameter("@ln", Convert.ToInt32(read[0].ToString())));
cmd.Parameters.Add(new OleDbParameter("@orgcity", read[2].ToString()));
cmd.Parameters.Add(new OleDbParameter("@destcity", read[5].ToString()));
cmd.Parameters.Add(new OleDbParameter("@orgzone", read[4].ToString()));
cmd.Parameters.Add(new OleDbParameter("@destzone", read[7].ToString()));
cmd.Parameters.Add(new OleDbParameter("@ocountry", read[2].ToString()));
cmd.Parameters.Add(new OleDbParameter("@dcountry", read[6].ToString()));
cmd.Parameters.Add(new OleDbParameter("@orgcountry", "NL"));
cmd.Parameters.Add(new OleDbParameter("@destcountry", "FI"));

/*cmd.Parameters.Add(new OleDbParameter("origin", String.Empty));
cmd.Parameters.Add(new OleDbParameter("dest", String.Empty));
cmd.Parameters.Add(new OleDbParameter("min", double.Parse(read[10].ToString())));
cmd.Parameters.Add(new OleDbParameter("basert", null));
cmd.Parameters.Add(new OleDbParameter("rate", null));
cmd.Parameters.Add(new OleDbParameter("frmwt", null));
cmd.Parameters.Add(new OleDbParameter("towt", null));
cmd.Parameters.Add(new OleDbParameter("cur", null));
cmd.Parameters.Add(new OleDbParameter("validfrm", null));
cmd.Parameters.Add(new OleDbParameter("validtill", null));
*/
/*cmd.Parameters.Add(new OleDbParameter("rate", double.Parse(read["rate"].ToString())));
cmd.Parameters.Add(new OleDbParameter("frmwt", double.Parse(read["from_wt"].ToString())));
cmd.Parameters.Add(new OleDbParameter("towt", double.Parse(read["to_wt"].ToString())));
cmd.Parameters.Add(new OleDbParameter("cur", read["currency"].ToString()));
cmd.Parameters.Add(new OleDbParameter("validfrm", DateTime.Parse(read["valid_from"].ToString())));
cmd.Parameters.Add(new OleDbParameter("validtill", DateTime.Parse(read["valid_till"].ToString())));
*/
cmd.Parameters.Add(new OleDbParameter("validtill", "mytariff.xls"));

cmd.ExecuteNonQuery();
}
}
catch(OleDbException ex)
{
Console.WriteLine(ex.Message);
}
finally 
{
con.Close();
}

}
}