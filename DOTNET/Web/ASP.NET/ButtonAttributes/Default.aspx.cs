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
        //Button1.Attributes.Add();
        Button2.ID = "Button2";
        Button2.Attributes.Add("onclick", "alert('Ok');");
        Button2.Attributes.Add("style", "background-color: red;");

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Output.Write("Hello from {0}", Button1.ID);
    }
    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    Response.Output.Write("Hello from {0}", Button2.ID);
    //}

}
