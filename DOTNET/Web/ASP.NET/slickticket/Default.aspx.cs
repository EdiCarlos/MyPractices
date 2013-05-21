//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Dashboard;
        dbDataContext db = new dbDataContext();
        string userName = Utils.UserName();
        bool showAdmin;
        try{ showAdmin = Users.Get(db, userName).is_admin; }
        catch{ showAdmin = false; }
        pnlAdmin.Visible = showAdmin;
    }
}
