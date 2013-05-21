using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageAttributes
{
    public partial class AutoEventWireUpSample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("This is Page Load event inside AutoEventWireUpSample");
        }
    }
}