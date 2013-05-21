using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Odbc;

public partial class _Default : System.Web.UI.Page 
{
    odbcclass odbc;
    OdbcConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        //odbc = new odbcclass();
        //con = odbc.Getconnection();
        //OdbcDataAdapter da = new OdbcDataAdapter("select * from mytb", con);
        //DataSet set = new DataSet();
        //da.Fill(set);
        //GridView3.DataSource = set.Tables[0];
        //GridView3.DataBind();


    }
 
}
