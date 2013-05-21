//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using SlickTicketExtensions;

public partial class search : System.Web.UI.Page
{
    dbDataContext db;
    public Dictionary<int, string> urgency = new Dictionary<int, string>();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Search;
        db = new dbDataContext();
        urgency.Add(1, "transparent");
        urgency.Add(2, "#ffe800");
        urgency.Add(3, "#ff7700");
        urgency.Add(4, "#ff2f00");
        if (!IsPostBack)
        {
            var units = Groups.List(db, 10);
            foreach (unit u in units.OrderBy(p => p.unit_name))
                ddlUnit.Items.Add(new ListItem(u.unit_name, u.id.ToString()));
            ddlUnit.Items.Insert(0, new ListItem(Resources.Common.Any, "0"));
            Utils.PopulateSubUnits(db, ddlUnit, ddlSubUnit, 10);
            ddlSubUnit.Items.Insert(0, new ListItem(Resources.Common.Any, "0"));

            System.Drawing.Color alt_color = System.Drawing.ColorTranslator.FromHtml(Themes.Current(db).alt_rows);
            gvResults.HeaderStyle.BackColor = alt_color;
            gvResults.AlternatingRowStyle.BackColor = alt_color;

            queryStringSearch();
        }
    }

    protected void queryStringSearch()
    {
        bool autoSearch = false;
        if (Request.QueryString["from"] != null)
        {
            txtFrom.Text = Request.QueryString["from"].ToString();
            autoSearch = true;
        }
        if (Request.QueryString["to"] != null)
        {
            txtTo.Text = Request.QueryString["to"].ToString();
            autoSearch = true;
        }
        if (Request.QueryString["group"] != null)
        {
            ddlUnit.set(Request.QueryString["group"].ToString());
            ddlUnit_SelectedIndexChanged(null, null);
            autoSearch = true;
        }
        if (Request.QueryString["subgroup"] != null)
        {
            ddlSubUnit.set(Request.QueryString["subgroup"].ToString());
            autoSearch = true;
        }
        if (Request.QueryString["onlyopen"] != null)
        {
            bool onlyOpen = false;
            bool.TryParse(Request.QueryString["onlyopen"].ToString(), out onlyOpen);
            chkOpenOnly.Checked = onlyOpen;
            autoSearch = true;
        }
        if (autoSearch) btnSearch_Click(null, null);
    }

    protected void ddlUnit_SelectedIndexChanged(object sender, EventArgs e)
    {
        Utils.PopulateSubUnits(db, ddlUnit, ddlSubUnit, 10);
        ddlSubUnit.Items.Insert(0, new ListItem("Any", "0"));
        ddlUnit.Focus();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int usr, prty, stat, u, su;
        DateTime dtFrom, dtTo;
        bool onlyOpen = chkOpenOnly.Checked;

        int wordLimit = 10;
        string[] keywords = new string[wordLimit];
        for (int i = 0; i < wordLimit; i++) keywords[i] = string.Empty;
        string[] inputKeywords = txtTitle.Text.Split(new char[] { ' ', ',', ';' }, wordLimit + 1, StringSplitOptions.RemoveEmptyEntries);
        int max = inputKeywords.Length > wordLimit ? wordLimit : inputKeywords.Length; 
        for (int i = 0; i < max; i++)
            keywords[i] = inputKeywords[i];

        try { dtFrom = DateTime.Parse(txtFrom.Text); }
        catch { dtFrom = DateTime.Parse("1/2/2001"); }
        try { dtTo = DateTime.Parse(txtTo.Text); }
        catch { dtTo = DateTime.Now.AddDays(1); }

        if(String.IsNullOrEmpty(txtUser.Text)) usr = -1;
        else
        {
            try { usr = Users.Get(db, txtUser.Text).id; }
            catch { usr = 0; }
        }

        prty = Int32.Parse(ddlPriority.SelectedValue);
        stat = Int32.Parse(ddlStatus.SelectedValue);
        u = Int32.Parse(ddlUnit.SelectedValue);
        su = Int32.Parse(ddlSubUnit.SelectedValue);

        gvResults.EmptyDataText = "<h5>" + GetLocalResourceObject("NoResults") + "</h5>";
        var results = Tickets.Search(db, keywords, usr, dtFrom, dtTo, prty, stat, onlyOpen, u, su);
        gvResults.DataSource = results;
        Session["searchResults"] = results;
        gvResults.DataBind();
    }

    protected void gv_Sorting(object sender, GridViewSortEventArgs e)
    {
        IEnumerable<ticket> searchResults = (IEnumerable<ticket>)Session["searchResults"];
        GridView gv = (GridView)sender;
        if (Session[e.SortExpression] == null || Session[e.SortExpression].ToString().Equals("+"))
        {
            Session[e.SortExpression] = "-";
            switch (e.SortExpression)
            {
                case "priority": searchResults = searchResults.OrderBy(p => p.priority1.level); break;
                case "title": searchResults = searchResults.OrderBy(p => p.title); break;
                case "submitted": searchResults = searchResults.OrderBy(p => p.submitted); break;
                case "status": searchResults = searchResults.OrderBy(p => p.statuse.status_order); break;
                default: break;
            }
        }
        else
        {
            Session[e.SortExpression] = "+";
            switch (e.SortExpression)
            {
                case "priority": searchResults = searchResults.OrderByDescending(p => p.priority1.level); break;
                case "title": searchResults = searchResults.OrderByDescending(p => p.title); break;
                case "submitted": searchResults = searchResults.OrderByDescending(p => p.submitted); break;
                case "status": searchResults = searchResults.OrderByDescending(p => p.statuse.status_order); break;
                default: break;
            }
        }
        gv.DataSource = searchResults;
        gv.DataBind();
    }
}
