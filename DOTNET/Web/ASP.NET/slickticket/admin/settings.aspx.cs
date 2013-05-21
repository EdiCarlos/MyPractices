//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.IO;
using System.Text;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using SlickTicketExtensions;

public partial class admin_settings : System.Web.UI.Page
{
    dbDataContext db;

    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Admin + " - " + Resources.Common.Settings;
        db = new dbDataContext();

        if (!IsPostBack)
        {
            chkRestrictDomains.Checked = Utils.Settings.EmailIsRestricted();
            chkEmail.Checked = bool.Parse(Utils.Settings.Get("email_notification"));
            txtAttachment.Text = Utils.Settings.Get("attachments");
            txtTitle.Text = Utils.Settings.Get("title");
            txtImage.Text = Utils.Settings.Get("image");
            txtAdminEmail.Text = Utils.Settings.Get("admin_email");
            txtSysEmail.Text = Utils.Settings.Get("system_email");
            txtDC.Text = Utils.Settings.Get("domain_controller");
            txtSmtp.Text = Utils.Settings.Get("smtp");
            resetTheme();

            if (Utils.Settings.Get("sidebar").Equals("left")) left.Checked = true;
            else right.Checked = true;
        }
        pnlDomains.Visible = chkRestrictDomains.Checked;
        btnDomainPopup.Visible = chkRestrictDomains.Checked;
    }

    protected void resetTheme()
    {
        clear();
        setThemeColorsToCurrent(1);
        System.Drawing.Color alt_color = System.Drawing.ColorTranslator.FromHtml(Themes.Current(db).alt_rows);
        gvDomains.AlternatingRowStyle.BackColor = alt_color;
        gvDomains.HeaderStyle.BackColor = alt_color;
        gvAccessLevels.AlternatingRowStyle.BackColor = alt_color;
        gvAccessLevels.HeaderStyle.BackColor = alt_color;
    }

    protected void setThemeColorsToCurrent(int theme)
    {
        style current = Themes.Get(db, theme);
        styleText.Text = current.text_color;
        styleBody.Text = current.body;
        styleBorders.Text = current.borders;
        styleButtonText.Text = current.button_text;
        styleLink.Text = current.links;
        styleLinkHover.Text = current.hover;
        styleAlternatingRows.Text = current.alt_rows;
        styleHeader.Text = current.header;
        styleBg.Text = current.background;
    }
        
    protected void chkRestrictDomains_CheckedChanged(object sender, EventArgs e)
    {
        clear();
        Utils.Settings.Update("restrict_email_addresses", (!Utils.Settings.EmailIsRestricted()).ToString());
    }

    protected void chkEmail_CheckedChanged(object sender, EventArgs e)
    {
        clear();
        Utils.Settings.Update("email_notification", (!(bool.Parse(Utils.Settings.Get("email_notification")))).ToString());
    }
    
    protected void btnAddDomain_Click(object sender, EventArgs e)
    {
        clear();
        try
        {
            Dbi.Domains.Add(db, txtDomainAdd.Text);
             lblEmail.report(true, Resources.Common.Updated, null);
            txtDomainAdd.Text = string.Empty;
            gvDomains.DataBind();
        }
        catch (Exception ex)
        {
            lblEmail.report(false, Resources.Common.Error, ex);
        }
    }
    
    protected void btnApplyAppearance_Click(object sender, EventArgs e)
    {
        string sidebarLocation = "right";
        if (left.Checked == true) sidebarLocation = "left";
        Utils.Settings.Update("sidebar", sidebarLocation);
        Themes.Set(db, styleText.Text, styleBorders.Text, styleBody.Text, styleLink.Text, styleLinkHover.Text, styleButtonText.Text, styleAlternatingRows.Text, styleHeader.Text, styleBg.Text);
        reWriteCss(styleText.Text, styleBorders.Text, styleBody.Text, styleLink.Text, styleLinkHover.Text, styleButtonText.Text, styleAlternatingRows.Text, styleHeader.Text, styleBg.Text);
        resetTheme();
        Response.Redirect(Request.Url.ToString());
    }
    
    protected void btnCssReset_Click(object sender, EventArgs e)
    {
        Themes.Reset(db);
        style d = Themes.Current(db);
        reWriteCss(d.text_color, d.borders, d.body, d.links, d.hover, d.button_text, d.alt_rows, d.header, d.background);
        resetTheme();
    }

    protected void reWriteCss(string text, string borders, string body, string links, string hover, string buttonText, string alt, string header, string bg)
    {
        string cssThemeFile = Server.MapPath("~") + "\\css\\theme.css";
        StringBuilder sb = new StringBuilder();
        sb.Append("html, .divider{background:"+bg+";}");
        sb.Append("li.current_tab { background:"+bg+"; }");
        sb.Append("li.current_tab a{ background:" + bg + "; }");
        sb.Append("a{color:" + links + ";}");
        sb.Append("a:hover{color:" + hover + ";}");
        sb.Append(".button:hover{background-color:"+hover+";}");
        sb.Append(".button{background:" + links + ";color:" + buttonText + ";}");
        sb.Append(".border_color{background-color:" + borders + ";}");
        sb.Append(".inner_color{background-color:" + body + ";}");
        sb.Append(".base_text{color:" + text + ";}");
        sb.Append(".alt_row{background-color:" + alt + ";}");
        sb.Append(".header{color:" + header + ";}");
        sb.Append("#nav > ul span a{background-color:"+body+";}");
        sb.Append("#nav > ul li.current_tab span a{background-color:"+bg+";}");
        

        File.Delete(cssThemeFile);
        TextWriter tw = new StreamWriter(cssThemeFile);
        tw.WriteLine(sb.ToString());
        tw.Close();

    }
    protected void btnAttachment_Click(object sender, EventArgs e)
    {
        clear();
        try
        {
            string path = txtAttachment.Text;
            path = path.EndsWith("\\") ? path : path + "\\";
            Utils.Settings.Update("attachments", path);
            txtAttachment.Text = path;
            lblAttachmentReport.report(true, Resources.Common.Updated, null);
        }
        catch (Exception ex)
        {
            lblAttachmentReport.report(false, Resources.Common.Error, ex);
        }
    }

    protected void clear()
    {
        Label[] lbls = new Label[] { lblEmail, lblCAppearance, lblAttachmentReport, lblAccessReport };
        foreach(Label lbl in lbls) lbl.Text = string.Empty;
    }
    protected void gvDomains_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        clear();
        if(e.Exception == null)
        {
            lblEmail.report(true, Resources.Common.Deleted, null);
            gvDomains.DataBind();
        }
        else
            lblEmail.report(false, Resources.Common.Error, e.Exception);
    }

    protected void updateSettings_Click(object sender, EventArgs e)
    {
        try
        {
            Button clicked = (Button)sender;
            TextBox txt = (TextBox)pnlSettings.FindControl(clicked.CommandName);
            Utils.Settings.Update(clicked.CommandArgument, txt.Text);
            lblAttachmentReport.report(true, clicked.CommandArgument.Replace("_", " ") + " " + Resources.Common.Updated, null);
        }
        catch(Exception ex)
        { lblAttachmentReport.report(true, Resources.Common.Error, ex); }

    }
    
    protected void ddlThemes_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlThemes.Items[0].Value.Equals("0")) ddlThemes.Items.Remove(ddlThemes.Items[0]);
        setThemeColorsToCurrent(Int32.Parse(ddlThemes.SelectedValue.ToString()));
        btnThemeDelete.Visible = true;
    }
    
    protected void btnNewTheme_Click(object sender, EventArgs e)
    {
        try
        {
            Themes.Add(db, txtNewTheme.Text, styleText.Text, styleBorders.Text,
                styleBody.Text, styleLink.Text, styleLinkHover.Text, styleButtonText.Text, styleHeader.Text,
                styleAlternatingRows.Text, styleBg.Text);
            resetThemes();
            lblNewTheme.report(true, txtNewTheme.Text + " " + Resources.Common.Saved, null);
            lblThemeDelete.Text = string.Empty;
        }
        catch(Exception ex)
        {
            lblNewTheme.report(false, "Error", ex);
            lblThemeDelete.Text = string.Empty;
        }
    }

    protected void btnImport_Click(object sender, EventArgs e)
    {
        Button clicked = (Button)sender;
        switch (clicked.ID)
        {
            case "btnStyleImport": lblImportReport.Text = Styles.Import(fuImport.FileContent); break;
            case "btnFaqImport": lblImportReport.Text = Faqs.Import(fuImport.FileContent); break;
            default: lblImportReport.Text = "<div class='error'>" + Resources.Common.Error + "</div>"; break;
        }

    }

    protected void btnExport_Click(object sender, EventArgs e)
    {
        try
        {
            Button clicked = (Button)sender;
            string filename;
            XDocument x;
            if (clicked.ID.Equals("btnExportStyles"))
            {
                x = Styles.Export();
                filename = "SlickTicketThemes.xml";
            }
            else
            {
                x = Faqs.Export();
                filename = "SlicktTicketFaqs.xml";
            }
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=" + filename);
            Response.ContentType = "application/xml";
            Response.Write(x.ToString());
            Response.End();
        }
        catch (Exception ex)
        {
            lblImportReport.report(false, Resources.Common.Error, ex);
        }
    }
    protected void btnThemeDelete_Click(object sender, EventArgs e)
    {
        try
        {
            Themes.Delete(db, Int32.Parse(ddlThemes.SelectedValue));
            lblThemeDelete.report(true, Resources.Common.Deleted, null);
            lblNewTheme.Text = string.Empty;
            resetThemes();
        }
        catch (Exception ex)
        {
            lblThemeDelete.report(false, Resources.Common.Error, ex);
            lblNewTheme.Text = string.Empty;
        }

    }

    protected void resetThemes()
    {
        ddlThemes.Items.Clear();
        ddlThemes.Items.Add(new ListItem(GetLocalResourceObject("ListItemResource1.Text").ToString(), "0"));
        ddlThemes.DataBind();
    }

}
