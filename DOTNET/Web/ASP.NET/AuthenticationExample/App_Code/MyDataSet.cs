using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Odbc;

/// <summary>
/// Summary description for MyDataSet
/// </summary>
public class MyDataSet : IMyDataSet
{
    static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["mytbconnectionString"].ToString();
    
    private DataSet mytbset;
    private OdbcConnection myConnection;
    public MyDataSet()
    {
        MyConnection = OpenConnection();
    }

    /// <summary>
    /// This is connection property for this class inherited from IMyDataSet
    /// </summary>
    public OdbcConnection MyConnection
    {
        get { return myConnection; }
        set { myConnection = value; }
    }

    public DataSet Mytbset
    {
        get { return mytbset; }
        set { mytbset = value; }
    }
    
    public void FillDataSet(string query)
    {
        OdbcDataAdapter adapter = new OdbcDataAdapter(query, MyConnection);
        adapter.Fill(Mytbset);
    }

    public OdbcConnection OpenConnection()
    {
        OdbcConnection con = new OdbcConnection(constr);
        con.Open();
        return con;
    }
    ~MyDataSet()
    {
        MyConnection.Close();
    }
}
