using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;
using System.Text;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StringBuilder builder = new StringBuilder();
        foreach (string item in GlobalClass.FileList)
        {
            builder.Append(item);
            builder.Append("<br />");
        }
        Label1.Text = builder.ToString();
    }
}
