//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using SlickTicketExtensions;

public partial class admin_units : System.Web.UI.Page
{
    dbDataContext db;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Admin + " - " + Resources.Common.Groups;
        db = new dbDataContext();
        if (!IsPostBack)
        {
            System.Drawing.Color alt_color = System.Drawing.ColorTranslator.FromHtml(Themes.Current(db).alt_rows);
            gvSubUnits.HeaderStyle.BackColor = alt_color;
            gvSubUnits.AlternatingRowStyle.BackColor = alt_color;
            gvUnits.HeaderStyle.BackColor = alt_color;
            gvUnits.AlternatingRowStyle.BackColor = alt_color;
            foreach (security_level sl in Dbi.AccessLevels.List(db, 0))
                ddlSecurityLevel.Items.Add(new ListItem("[" + sl.id.ToString() + "] " + sl.security_level_name, sl.id.ToString()));
        }
    }

    protected void gvUnits_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        clear();
        if (e.Exception != null)
        {
            lblUnitReport.CssClass = "error top_error";
            lblUnitReport.Text = GetLocalResourceObject("HasSubUnits").ToString() + "<div class='sub_error'>" + e.Exception.Message + "</div>";
            e.ExceptionHandled = true;
        }
        else
        {
            lblUnitReport.report(true, Resources.Common.Deleted, null);
            updateDdls();
        }
    }

    protected void gvSubUnits_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        clear();
        if (e.Exception != null)
        {
            lblSubUnitReport.report(false, Resources.Common.Error + " - <span class='smaller'>" + GetLocalResourceObject("UsersAssigned").ToString() + "</span>", e.Exception);
            e.ExceptionHandled = true;
            ddlUnitSelected.DataBind();
        }
        else
        {
            lblSubUnitReport.report(true, Resources.Common.Deleted, null);
        }
    }

    protected void updateDdls()
    {
        ddlUnitSelected.DataBind();
        ddlNewSubUnit.DataBind();
    }

    protected void gvUnits_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        updateDdls();
    }

    protected void btnNewUnitSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Groups.Add(db, txtNewUnit.Text);
            lblUnitReport.report(true, "group Added", null);

            gvUnits.DataBind();
            updateDdls();
            txtNewUnit.Text = string.Empty;
            lblSubUnitReport.Text = string.Empty;
        }
        catch (Exception ex)
        {
            lblUnitReport.report(false, "error", ex);
        }
        lblSubUnitReport.Text = string.Empty;
        clear();
    }
    protected void btnNewSubUnitSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            Groups.SubGroups.Add(db, txtNewSubUnit.Text, Int32.Parse(ddlNewSubUnit.SelectedValue), Int32.Parse(ddlSecurityLevel.SelectedValue), txtMailto.Text);
            lblSubUnitReport.report(true, "Sub-group added", null);
            gvSubUnits.DataBind();
        }
        catch (Exception ex)
        {
            lblSubUnitReport.report(false, "error", ex);
            ddlUnitSelected.DataBind();
        }
        clear();
    }
    protected void ddlUnitSelected_SelectedIndexChanged(object sender, EventArgs e)
    {
        clear();
        ddlNewSubUnit.SelectedIndex = ddlUnitSelected.SelectedIndex;
    }

    protected void clear()
    {
        Control[] ctrls = new Control[] { lblReport, lblUnitReport, lblSubUnitReport, txtNewSubUnit, txtNewUnit, txtMailto, ddlSecurityLevel, ddlNewSubUnit };
        foreach (Control l in ctrls)
        {
            try { ((Label)l).Text = string.Empty; }
            catch
            {
                try { ((TextBox)l).Text = string.Empty; }
                catch { ((DropDownList)l).SelectedIndex = 0; }
            }
        }
    }
}
