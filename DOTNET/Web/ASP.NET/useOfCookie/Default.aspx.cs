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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

        HttpCookie cookie = null;
      
        cookie  = Request.Cookies["local"];
        if (!Page.IsPostBack)
        {
            if (cookie != null)
            {
                login.UserName = cookie.Values[0];
            }
        }

    }


    protected void login_Authenticate(object sender, AuthenticateEventArgs e)
    {
        if (login.UserName.Equals("arif788") && login.Password.Equals("password"))
        {
            e.Authenticated = true;
            if (login.RememberMeSet)
            {
                HttpCookie cookie = new HttpCookie("local");
                cookie.Expires = DateTime.Now.AddDays(1);
                cookie.Value = login.UserName;
                cookie.Domain = "localhost.com";
                Response.Cookies.Add(cookie);
                Response.Cookies["local"]["time"] = DateTime.Now.ToShortTimeString();
            }
            else
            {
                Request.Cookies["local"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("Page2.aspx");
        }
        else
        {
            //login.FailureAction = LoginFailureAction.RedirectToLoginPage;
            login.FailureText = "Login Failed";
        }
    }
}
