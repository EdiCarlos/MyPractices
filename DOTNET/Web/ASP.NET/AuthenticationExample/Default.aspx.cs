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
    static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["mytbconnectionString"].ToString();
    static string retUrl;

    public string RetUrl
    {
        get { return _Default.retUrl; }
        set { _Default.retUrl = value != null ? value : String.Empty; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["ReturnUrl"] != null)
        {
            RetUrl = Request["ReturnUrl"].ToString();
        }
        else
        {
            RetUrl = String.Empty;
        }
        Response.Write(RetUrl);
    }
    public void Authenticate_login1(object sender, AuthenticateEventArgs e)
    {

        if (AuthenticateUser())
        {
            e.Authenticated = true;
            
            FormsAuthentication.RedirectFromLoginPage(Login1.UserName, false);
            if (RetUrl != String.Empty | RetUrl != null)
            {
                Response.Redirect(retUrl);
            }
            else
            {
                Response.Redirect("Aboutus.aspx");
            }
        }
        else
        {
            Login1.FailureText = "Login failed this is my login failure";
        }

    }

    private bool AuthenticateUser()
    {
        string query = "Select * from mytb";
        bool userAutheticate = false;
        using (OdbcConnection con = new OdbcConnection(constr))
        {
            con.Open();

            OdbcCommand cmd = new OdbcCommand(query, con);
            OdbcDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read["username"].Equals(Login1.UserName.Trim()) & read["userpass"].Equals(Login1.Password.Trim()))
                {
                    userAutheticate = true;
                    return userAutheticate;
                }
            }
        }
        return userAutheticate;
    }
}
