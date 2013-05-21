//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Collections;
using System.Linq;
using System.Web.UI.WebControls;

public partial class setup_active_directory : System.Web.UI.Page
{
    dbDataContext db;
    protected void Page_Load(object sender, EventArgs e)
    {
        bool done = bool.Parse(Setup.Settings.Get("active_directory"));
        lnkNext.Visible = done;
        lblFinished.Visible = done;

        db = new dbDataContext();
        if (!IsPostBack)
        {
            foreach (security_level s in (from p in db.security_levels where p.id > 1 select p))
                ddlLevels.Items.Add(new ListItem(s.id.ToString() + " " + s.security_level_name, s.id.ToString()));

            foreach (string v in Groups().ToArray())
            {
                string[] split = v.Split(new char[] { '\\' });
                ddlAD.Items.Add(new ListItem((split.Length == 1 ? v : split[1])));
            }
        }
    }

    public ArrayList Groups()
    {
        ArrayList groups = new ArrayList();
        foreach (System.Security.Principal.IdentityReference group in
            System.Web.HttpContext.Current.Request.LogonUserIdentity.Groups)
        {
            groups.Add(group.Translate(typeof
                (System.Security.Principal.NTAccount)).ToString());
        }
        return groups;
    }
    protected void btnCommit_Click(object sender, EventArgs e)
    {
        try
        {
            Permissions.AddGroup(db, ddlAD.SelectedValue, Int32.Parse(ddlLevels.SelectedValue));
            gvADGroups.DataBind();
            lblError.Text = string.Empty;
            lnkNext.Visible = true;
            lblFinished.Visible = true;
            Setup.Settings.Update("active_directory", "True");
            Utils.Settings.Update("installed", "True");
        }
        catch (Exception ex)
        {
            lblError.Text = " - " + ex.Message;
        }
    }
}
