//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class my_issues : System.Web.UI.Page
{
    dbDataContext db;
    string userName;
    int securityLevel;
    bool userIsRegistered;
    int accessLevel;
    IEnumerable<ticket> myTickets, groupTickets;
    public Dictionary<int, string> urgency = new Dictionary<int, string>();

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.MyIssues;
        GridView[] gvs = new GridView[] { gvMy, gvGroup };
        db = new dbDataContext();
        userName = Utils.UserName();
        userIsRegistered = Users.Exists(db, userName);
        user me = Users.Get(db, userName);
        lblMyGroup.Text = me.sub_unit1.unit.unit_name + " - " + me.sub_unit1.sub_unit_name;
        txtSubmitter.Text = me.id.ToString();
        txtGroup.Text = me.sub_unit.ToString();

        urgency.Add(1, "transparent");
        urgency.Add(2, "#ffe800;color:#666666;");
        urgency.Add(3, "#ff7700");
        urgency.Add(4, "#ff2f00");

        myTickets = Tickets.MyTickets(db, me.id);
        groupTickets = Tickets.MyGroupsTickets(db, me);

        if (!IsPostBack)
        {
            System.Drawing.Color alt_color = System.Drawing.ColorTranslator.FromHtml(Themes.Current(db).alt_rows);
            foreach (GridView gv in gvs)
            {
                gv.HeaderStyle.BackColor = alt_color;
                gv.AlternatingRowStyle.BackColor = alt_color;
            }
            gvMy.DataSource = myTickets;
            gvMy.DataBind();
            gvGroup.DataSource = groupTickets;
            gvGroup.DataBind();
        }
    }

    protected void gv_Sorting(object sender, GridViewSortEventArgs e)
    {
        GridView gv = (GridView)sender;
        IEnumerable<ticket> sortedGroup;
        if (gv.ID.Equals("gvMy")) sortedGroup = myTickets;
        else sortedGroup = groupTickets;
        if (Session[e.SortExpression] == null || Session[e.SortExpression].ToString().Equals("+"))
        {
            Session[e.SortExpression] = "-";
            switch (e.SortExpression)
            {
                case "priority": sortedGroup = sortedGroup.OrderBy(p => p.priority1.level); break;
                case "title": sortedGroup = sortedGroup.OrderBy(p => p.title); break;
                case "submitted": sortedGroup = sortedGroup.OrderBy(p => p.submitted); break;
                case "status": sortedGroup = sortedGroup.OrderBy(p => p.statuse.status_order); break;
                default: break;
            }
        }
        else
        {
            Session[e.SortExpression] = "+";
            switch (e.SortExpression)
            {
                case "priority": sortedGroup = sortedGroup.OrderByDescending(p => p.priority1.level); break;
                case "title": sortedGroup = sortedGroup.OrderByDescending(p => p.title); break;
                case "submitted": sortedGroup = sortedGroup.OrderByDescending(p => p.submitted); break;
                case "status": sortedGroup = sortedGroup.OrderByDescending(p => p.statuse.status_order); break;
                default: break;
            }
        }
        
        gv.DataSource = sortedGroup;
        gv.DataBind();
    }

    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView gv = (GridView)sender;
        gv.PageIndex = e.NewPageIndex;
        gv.DataBind();
    }
}
