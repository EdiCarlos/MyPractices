using System;
using System.Data;
using System.Data.OleDb;
using System.Xml;

class Savexml
{
	public static void Main()
	{
		OleDbConnection con = new OleDbConnection("Provider=VFPOLEDB.1;Data Source=D:\\");
try
{
con.Open();
OleDbCommand cmd = new OleDbCommand(@"select * from d:\temp\mtab.dbf", con);

//OleDbDataAdapter ad = new OleDbDataAdapter(@"select * from d:\temp\prac.dbf", con);
//DataSet set = new DataSet();
//ad.Fill(set);
//this.grid.DataSource = set.Tables[0];
//this.grid.DataBind();
//grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

XmlReader read = cmd.ExecuteXmlReader();

XmlDocument doc = new XmlDocument();
doc.Load(read);
doc.Save(Console.Out);

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