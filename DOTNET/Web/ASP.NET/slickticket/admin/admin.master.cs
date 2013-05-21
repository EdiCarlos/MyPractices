//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class admin_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Users.Get(new dbDataContext(), Utils.UserName()).is_admin)
            Response.Redirect("~/");
        if (Request.Url.ToString().ToLower().Contains("default.aspx"))
            pnlAdminMenu.Visible = false;

        buildMenu();
    }

    protected void buildMenu()
    {
        string[] url = Request.Url.ToString().Split(new char[] { '/' });
        string page = url[url.Length - 1];
        int aspx = page.IndexOf('.');
        page = aspx > 0 ? page.Substring(0, aspx) : page;

        foreach (XElement xe in Utils.Menus.Admin())
        {
            string xmlPage = xe.Value.ToLower().Replace("~/admin/", string.Empty).Replace(".aspx", string.Empty);
            if (xmlPage.Equals(page.ToLower())) lblAdminMenu.Controls.Add(new LiteralControl("<li class='current_tab'>"));
            else lblAdminMenu.Controls.Add(new LiteralControl("<li>"));
            HyperLink hl = new HyperLink() { Text = GetGlobalResourceObject("Common", xe.FirstAttribute.Value).ToString(), NavigateUrl = xe.Value };
            lblAdminMenu.Controls.Add(hl);
            lblAdminMenu.Controls.Add(new LiteralControl("</li>"));
        }
    }
}
