using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBackAndCrossPostBack.PostBackExample
{
    public partial class PostbackSamplePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            colorPanel.BackColor = System.Drawing.Color.Black;
        }

        protected void postBackDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (postBackDropDown.SelectedValue)
            {
                case "Red":
                    colorPanel.BackColor = System.Drawing.Color.Red;
                    break;
                case "Yellow":
                    colorPanel.BackColor = System.Drawing.Color.Yellow;
                    break;
                case "Green":
                    colorPanel.BackColor = System.Drawing.Color.Green;
                    break;
                default:
                    colorPanel.BackColor = System.Drawing.Color.Black;
                    break;
            }
        }
    }
}