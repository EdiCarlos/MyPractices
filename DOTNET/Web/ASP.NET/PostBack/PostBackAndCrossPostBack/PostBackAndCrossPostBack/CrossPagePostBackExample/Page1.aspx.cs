using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackAndCrossPostBack.CrossPagePostBackExample
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculatePostBack_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(txtNumber1.Text) + Convert.ToInt32(txtNumber2.Text);
            txtResult.Text = result.ToString();
        }

        protected void btnCalculateCrossPostBack_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertScript", "alert('Cross post back button clicked')", true);
            
        }
    }
}