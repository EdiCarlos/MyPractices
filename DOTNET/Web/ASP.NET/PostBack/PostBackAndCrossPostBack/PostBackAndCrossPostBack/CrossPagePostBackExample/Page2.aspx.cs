using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackAndCrossPostBack.CrossPagePostBackExample
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox text1 = PreviousPage.FindControl("txtNumber1") as TextBox;
                TextBox text2 = PreviousPage.FindControl("txtNumber2") as TextBox;
                int result = Convert.ToInt32(text1.Text) + Convert.ToInt32(text2.Text);
                txtResult.Text = result.ToString();
            }
        }
    }
}