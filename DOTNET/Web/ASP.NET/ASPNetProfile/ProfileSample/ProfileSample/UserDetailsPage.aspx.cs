using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfileSample
{
    public partial class UserDetailsPage : System.Web.UI.Page
    {
        public const string PERSONKEY = "PERSON";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && Session[PERSONKEY] != null) 
            {
                Person person = (Person)Session[PERSONKEY];
                txtFirstName.Text = person.FristName;
                txtLastName.Text = person.LastName;
                txtEmail.Text = person.EmailAddress;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session[PERSONKEY] == null)
            {
                Person person = new Person();
                person.FristName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.EmailAddress = txtEmail.Text;
                Session[PERSONKEY] = person;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            if (Session[PERSONKEY] != null)
            {
                Session.Remove(PERSONKEY);
                txtFirstName.Text = "";
                txtFirstName.Text = "";
                txtEmail.Text = "";
            }
        }


    }
}