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
using web = PT.ExpenseDistribution.BL;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(TextBox1.Text);
        int num2 = Convert.ToInt32(TextBox2.Text);
        Trace.Write("Value of num1 " + num1);
        Trace.Write("Value of num2 " + num2);
        int num3 = num1 + num2;
        TextBox3.Text = num3.ToString();
        Trace.Write("Value of num3 " + num3);
    }
}
