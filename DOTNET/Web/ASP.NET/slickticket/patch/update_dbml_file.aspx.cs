//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;

public partial class patch_update_dbml_file : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool done = bool.Parse(Setup.Patch.Get("dbml"));
        btnUpdate.Enabled = !done;
        lblFinished.Visible = done;
        lnkNext.Visible = done;
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            Setup.Patch.Update("dbml", "True");
            lblOutput.Text += ".dbml files updated successfully";
            lblOutput.CssClass = "success";
            lblFinished.Visible = true;
            btnUpdate.Enabled = false;
            lnkNext.Visible = true;
        }
        catch (Exception ex)
        {
            lblOutput.Text = "An error occured: " + ex.ToString();
            lblOutput.CssClass = "error";
        }
    }
}
