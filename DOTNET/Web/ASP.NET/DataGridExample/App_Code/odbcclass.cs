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
/// Summary description for odbcclass
/// </summary>
public class odbcclass
{
    public static string constr = "DSN=Mytb";
    OdbcConnection con;
    public odbcclass()
    {
        
    }
    public OdbcConnection Getconnection()
    {
        con = new OdbcConnection(constr);
        return con;
    }
    
}
