//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using SlickTicketExtensions;

public partial class admin_stats : System.Web.UI.Page
{
    dbDataContext db;
    int max;
    public string thisUnit, thisSubUnit;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Admin + " - " + Resources.Common.Statistics;
        db = new dbDataContext();
        if (!IsPostBack)
        {
            this.groups();
        }
    }

    protected void groups()
    {
        max = 0;
        DataTable dt = new DataTable();
        dt.Columns.Add(new DataColumn("name", typeof(string)));
        dt.Columns.Add(new DataColumn("id", typeof(int)));
        dt.Columns.Add(new DataColumn("count", typeof(int)));
        foreach (unit u in Groups.List(db, 10))
        {
            IEnumerable<ticket> tix = Groups.OpenTickets(db, u.id);
            if (tix.Count() > max) max = tix.Count();
            DataRow row = dt.NewRow();
            try
            {
                row["count"] = tix.Count();
            }
            catch
            {
                row["count"] = 0;
            }
            finally
            {
                row["name"] = u.unit_name;
                row["id"] = u.id;
                dt.Rows.Add(row);
            }
        }
        rptGroups.DataSource = dt;
        rptGroups.DataBind();
        lblSubGroupDetails.Visible = false;

        this.displayStats(Tickets.ListOpen(db), Tickets.ListClosed(db));
    }


    protected void btnGrp_Click(object sender, EventArgs e)
    {
        int unit_ref;
        try { unit_ref = Int32.Parse(((Button)sender).CommandArgument); }
        catch { unit_ref = Int32.Parse(((LinkButton)sender).CommandArgument); }
        currentGroup.Text = unit_ref.ToString();
        currentSubGroup.Text = "0";
        this.sub_groups(unit_ref);
        this.displayStats(Groups.OpenTickets(db, unit_ref), Groups.ClosedTickets(db, unit_ref));
        pnlGroups.Visible = false;
        pnlSubGroups.Visible = true;
        lblSubGroupDetails.Visible = false;
        rptSubGroups.Visible = true;
    }

    protected void sub_groups(int unit_ref)
    {
        unit thisGroup = Groups.GetByID(db, unit_ref);
        thisUnit = thisGroup.unit_name;
        max = 0;
        DataTable dt = new DataTable();
        dt.Columns.Add(new DataColumn("name", typeof(string)));
        dt.Columns.Add(new DataColumn("id", typeof(int)));
        dt.Columns.Add(new DataColumn("count", typeof(int)));
        foreach (sub_unit u in Groups.SubGroups.List(db, unit_ref, 10))
        {
            IEnumerable<ticket> tix = Groups.SubGroups.OpenTickets(db, u.id);
            if (tix.Count() > max) max = tix.Count();
            DataRow row = dt.NewRow();
            try
            {
                row["count"] = tix.Count();
            }
            catch
            {
                row["count"] = 0;
            }
            finally
            {
                row["name"] = u.sub_unit_name;
                row["id"] = u.id;
                dt.Rows.Add(row);
            }
        }
        rptSubGroups.DataSource = dt;
        rptSubGroups.DataBind();
    }

    protected void btnSubGrp_Click(object sender, EventArgs e)
    {
        int sub_unit_ref = Int32.Parse(((Button)sender).CommandArgument);
        currentSubGroup.Text = sub_unit_ref.ToString();
        this.subDetails(sub_unit_ref);
        lblSubGroupDetails.Visible = true;
        rptSubGroups.Visible = false;
    }

    protected void subDetails(int sub_unit_ref)
    {
        sub_unit suClicked = Groups.SubGroups.GetByID(db, sub_unit_ref);
        thisUnit = suClicked.unit.unit_name;
        currentGroup.Text = suClicked.unit.id.ToString();
        thisSubUnit = suClicked.sub_unit_name;

        this.displayStats(Groups.SubGroups.OpenTickets(db, sub_unit_ref), Groups.SubGroups.ClosedTickets(db, sub_unit_ref));
    }

    protected void btnHome_Click(object sender, EventArgs e)
    {
        currentGroup.Text = "0";
        currentSubGroup.Text = "0";
        this.groups();
        pnlSubGroups.Visible = false;
        pnlGroups.Visible = true;
    }

    protected void btnSubHome_Click(object sender, EventArgs e)
    {
        LinkButton lbClicked = (LinkButton)sender;
        thisUnit = lbClicked.CommandArgument;
        int unit_ref = Int32.Parse(currentGroup.Text);
        lblSubGroupDetails.Visible = false;
        rptSubGroups.Visible = true;
        currentSubGroup.Text = "0";
        this.displayStats(Groups.OpenTickets(db, unit_ref), Groups.ClosedTickets(db, unit_ref));
    }

    protected string getWidth(object input)
    {
        int inp = Int32.Parse(input.ToString());
        if (inp != 0)
        {
            return "width:" + (100 * Convert.ToDouble(inp) / Convert.ToDouble(max)).ToString() + "%;";
        }
        else
        {
            return "filter:alpha(opacity=70); opacity:0.7;";
        }
    }

    public string getThisUnit()
    {
        return thisUnit;
    }

    protected void displayStats(IEnumerable<ticket> openTix, IEnumerable<ticket> closedTix)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add(new DataColumn("header", typeof(string)));
        dt.Columns.Add(new DataColumn("data", typeof(string)));

        try
        {
            DataRow row1 = dt.NewRow();
            row1["header"] = "<a style='font-size:1.1em;' href='../search.aspx?group=" + currentGroup.Text + "&subgroup=" + currentSubGroup.Text + "'>" + GetLocalResourceObject("OpenTickets").ToString() + "</a>";
            row1["data"] = openTix.Count().ToString();
            dt.Rows.Add(row1);

            DataRow row2 = dt.NewRow();
            row2["header"] = "&nbsp;<a href='../search.aspx?group=" + currentGroup.Text + "&subgroup=" + currentSubGroup.Text + "&to=" + DateTime.Now.AddDays(-1).ToShortDateString() + "'>" + GetLocalResourceObject("OneDay").ToString() + "</a>";
            row2["data"] = openTix.olderThan(1).Count();
            dt.Rows.Add(row2);

            DataRow row3 = dt.NewRow();
            row3["header"] = "&nbsp;<a href='../search.aspx?group=" + currentGroup.Text + "&subgroup=" + currentSubGroup.Text + "&to=" + DateTime.Now.AddDays(-3).ToShortDateString() + "'>" + GetLocalResourceObject("ThreeDays").ToString() + "</a>";
            row3["data"] = openTix.olderThan(3).Count();
            dt.Rows.Add(row3);

            DataRow row4 = dt.NewRow();
            row4["header"] = "&nbsp;<a href='../search.aspx?group=" + currentGroup.Text + "&subgroup=" + currentSubGroup.Text + "&to=" + DateTime.Now.AddDays(-7).ToShortDateString() + "'>" + GetLocalResourceObject("SevenDays").ToString() + "</a>";
            row4["data"] = openTix.olderThan(7).Count();
            dt.Rows.Add(row4);

            DataRow row5 = dt.NewRow();
            row5["header"] = "&nbsp;" + GetLocalResourceObject("Average").ToString();
            row5["data"] = openTix.averageAge() + " " + GetLocalResourceObject("Days").ToString();
            dt.Rows.Add(row5);
        }
        catch { }

        DataRow blank1 = dt.NewRow();
        blank1["header"] = "<br />";
        blank1["data"] = "<br />";
        dt.Rows.Add(blank1);

        try
        {
            DataRow row6 = dt.NewRow();
            row6["header"] = "<span style='font-size:1.1em;'>" + GetLocalResourceObject("Closed").ToString() +"</span>";
            row6["data"] = closedTix.Count();
            dt.Rows.Add(row6);

            DataRow row7 = dt.NewRow();
            row7["header"] = "&nbsp;" + GetLocalResourceObject("AvgClosure").ToString();
            row7["data"] = closedTix.averageCloseTime() + " " + GetLocalResourceObject("Days").ToString();
            dt.Rows.Add(row7);
        }
        catch { }

        rptDetails.DataSource = dt;
        rptDetails.DataBind();
    }

    public string setTopLevel(string s)
    {
        return s.Length > 0 ? s : GetLocalResourceObject("TopLevel").ToString();
    }
}
