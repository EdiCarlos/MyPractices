using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImplementsSample
{
    public partial class Default : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
           
        //}
        string fname, lname;
        public void SetFirstName(string fName)
        {
            fname = fName;
        }
        public void SetLastName(string lname)
        {
            this.lname = lname;
        }
        public string FullName()
        {
            return this.fname + " " + this.lname;
        }
    }
}