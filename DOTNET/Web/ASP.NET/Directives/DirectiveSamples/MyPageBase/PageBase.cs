using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Web.UI;

namespace MyPageBase
{
    public class PageBase : System.Web.UI.Page
    {
        protected HtmlGenericControl genericControl;
        protected virtual void Page_Load(object sender, EventArgs e)
        {
            genericControl = new HtmlGenericControl();
            genericControl.InnerHtml = "My Header";
            this.Controls.Add(genericControl);
            LiteralControl control = new LiteralControl("<a href='Default.aspx'>Blank</a>");
            this.Controls.Add(control);
        }
    }
}
