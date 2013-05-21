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
        Page.ClientScript.RegisterStartupScript(this.GetType(), "show", "showAddition();", true);
    }
    public void Button1_Click(object sender, EventArgs e)
    {
//        string script = @"<script type='text/javascript'> function all(){
//    alert('alert function called');
//    }all();</script>";

//        //ClientScript.RegisterClientScriptBlock("Button1_Click", script);
//        if (!ClientScript.IsClientScriptBlockRegistered(Page.GetType(), "Button1_Click"))
//        {
//            ClientScript.RegisterClientScriptBlock(this.GetType(), "Button1_Click", script);
//        }
        
    }
}
