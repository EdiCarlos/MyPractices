//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Text;
using System.Web.UI.WebControls;
using SlickTicketExtensions;

public partial class admin_users : System.Web.UI.Page
{
    string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public string userName;

    protected void Page_Load(object sender, EventArgs e)
    {
        userName = Utils.UserName();
        if(!IsPostBack)
        {
            System.Drawing.Color alt_color = System.Drawing.ColorTranslator.FromHtml(Themes.Current(new dbDataContext()).alt_rows);
            gvUsers.HeaderStyle.BackColor = alt_color;
            gvUsers.AlternatingRowStyle.BackColor = alt_color;
        }
        char[] alphabet = Alphabet.ToCharArray();
        for (int i = 0; i < 26; i++)
        {
            LinkButton lb = new LinkButton() { Text = "&nbsp;" + Alphabet[i].ToString() + "&nbsp;", CommandArgument = Alphabet[i].ToString() };
            lb.Click += new EventHandler(btnStartsWith_Click);
            lblSearchBar.Controls.Add(lb);
        }
        LinkButton lbAll = new LinkButton() { Text = "ALL", CommandArgument = string.Empty };
        lbAll.Click += new EventHandler(btnStartsWith_Click);
        lblSearchBar.Controls.Add(lbAll);
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            GridViewRow row = (GridViewRow)((CheckBox)sender).NamingContainer;
            int userID = Int32.Parse(gvUsers.DataKeys[row.RowIndex].Value.ToString());
            Users.FlipAdmin(new dbDataContext(), userID);
        }
        catch (Exception ex)
        {
            lblReport.report(false, "Error setting user to Admin", ex);
        }
    }
    protected void gvUsers_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        if (e.Exception != null)
        {
            lblReport.report(false, "Error Deleting", e.Exception);
            e.ExceptionHandled = true;
        }
        else
        {
            lblReport.report(true, "User Profile Deleted", null);
        }
    }
    protected void btnStartsWith_Click(object sender, EventArgs e)
    {
        Session["contains"] = null;
        Session["startswith"] = ((LinkButton)sender).CommandArgument;
        gvUsers.DataBind();
        txtSearch.Text = string.Empty;
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["startswith"] = null;
        Session["contains"] = txtSearch.Text;
        gvUsers.DataBind();
    }
}
