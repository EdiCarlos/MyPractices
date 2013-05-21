//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Web.UI.WebControls;
using SlickTicketExtensions;

public partial class admin_user_groups : System.Web.UI.Page
{
    dbDataContext db;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Admin + " - " + Resources.Common.Permissions;
        db = new dbDataContext();
        if (!IsPostBack)
        {
            System.Drawing.Color alt_color = System.Drawing.ColorTranslator.FromHtml(Themes.Current(db).alt_rows);
            gvADGroups.HeaderStyle.BackColor = alt_color;
            gvADGroups.AlternatingRowStyle.BackColor = alt_color;
            foreach (security_level sl in Dbi.AccessLevels.List(db, 0))
                ddlSecurityLevel.Items.Add(new ListItem("[" + sl.id.ToString() + "] " + sl.security_level_name, sl.id.ToString()));
        }
    }
    protected void btnNewSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Permissions.AddGroup(db, txtADGroup.Text, Int32.Parse(ddlSecurityLevel.SelectedValue));
            lblReport.report(true, Resources.Common.Updated, null);
            txtADGroup.Text = string.Empty;
            ddlSecurityLevel.set("1");
            gvADGroups.DataBind();
        }
        catch (Exception ex)
        {
            lblReport.report(false, Resources.Common.Error, ex);
        }
    }
    protected void btnResetADxml_Click(object sender, EventArgs e)
    {
        try
        {
            int numberOfGroups = Utils.ADGroupListUpdate();
            lblReport.report(true, Resources.Common.Updated +" [" + numberOfGroups + "]", null);
            lblReport.CssClass = "success top_error";
            Utils.Settings.Update("ad_groups", numberOfGroups.ToString());
        }
        catch (Exception ex)
        {
            lblReport.report(false, GetLocalResourceObject("ADRefreshError").ToString(), ex);
        }
    }

}
