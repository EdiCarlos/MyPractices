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
using System.Reflection;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.User.Identity.IsAuthenticated)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = Profile.FirstName;
                TextBox2.Text = Profile.LastName;
                TextBox4.Text = Profile.LastVisitedPage.ToString();
                TextBox3.Text = Profile.Age.ToString();
                RadioButton1.Checked = Profile.Member == true ? true : false;
            }
        }
    }
   

    protected void CreateUserWizard1_CreatingUser(object sender, LoginCancelEventArgs e)
    {

    }
    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {

    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        if (Page.User.Identity.IsAuthenticated)
        {
            Profile.FirstName = TextBox1.Text;
            Profile.LastName = TextBox2.Text;
            Profile.Age = Convert.ToInt32(TextBox3.Text);
            Profile.LastVisitedPage = DateTime.Now;
            Profile.Member = RadioButton1.Checked == false ? false : true;
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void loginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        FormsAuthentication.SignOut();
    }
   
}
