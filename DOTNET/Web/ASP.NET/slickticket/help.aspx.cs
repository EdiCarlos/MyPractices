//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Web;
using System.Web.UI.WebControls;
using SlickTicketExtensions;

public partial class info : System.Web.UI.Page
{
    dbDataContext db;
    public bool isAdmin;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Help;
        db = new dbDataContext();

        string userName = Utils.UserName();
        try
        {
            user thisUser = Users.Get(db, userName);
            if (thisUser.is_admin) isAdmin = true;
        }
        catch
        { isAdmin = false; }
    }

    public string trimJunk(string fromThis)
    {
        string[] junk = new string[] { " ", "?", "/", "#", "^", "&", "*", ".", ",", "\\", "'", "`" };
        foreach (string s in junk) fromThis = fromThis.Replace(s, string.Empty);
        return fromThis;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        try
        {
            Faqs.Delete(db, Int32.Parse(btn.CommandArgument));
            lblReport.report(true, GetLocalResourceObject("Deleted").ToString() , null);
            rptIndex.DataBind();
            rpt.DataBind();
        }
        catch (Exception ex)
        { lblReport.report(false, Resources.Common.Error, ex); }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int cmdArg = Int32.Parse(btnSubmit.CommandArgument);
        try
        {
            if( cmdArg != 0 )
            {
                Faqs.Edit(db, cmdArg, Server.HtmlEncode(txtQ.Text), txtA.Text);
                lblReport.report(true, GetLocalResourceObject("Updated").ToString(), null);
            }
            else
            {
                Faqs.Add(db, Server.HtmlEncode(txtQ.Text), txtA.Text);
                lblReport.report(true, GetLocalResourceObject("Inserted").ToString(), null);
            }
            rptIndex.DataBind();
            rpt.DataBind();
            txtA.Text = string.Empty;
            txtQ.Text = string.Empty;
        }
        catch (Exception ex)
        { lblReport.report(false, Resources.Common.Error, ex); }
        btnSubmit.CommandArgument="0";
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        faq f = Faqs.Get(db, Int32.Parse(btn.CommandArgument));
        txtQ.Text = f.title;
        txtA.Text = f.body;
        btnSubmit.CommandArgument = btn.CommandArgument.ToString();
        mpe.Show();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtQ.Text = string.Empty;
        txtA.Text = string.Empty;
        btnSubmit.CommandArgument = "0";
    }
}
