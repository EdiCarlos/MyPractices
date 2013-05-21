//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net


using System;
using System.Net.Mail;
using SlickTicketExtensions;

public partial class contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = Resources.Common.Contact;
    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            string userName = Utils.UserName();
            dbDataContext db = new dbDataContext();
            user u = Users.Get(db, userName);
            string strBody = u.userName + " (" + u.sub_unit1.unit.unit_name + " - " + u.sub_unit1.sub_unit_name + ") " +  GetLocalResourceObject("SentText").ToString() + 
                ":\n\n" + txtSubject.Text + "\n\n" + txtBody.Text;
            MailMessage message = new MailMessage(u.email, Utils.Settings.Get("admin_email"), Utils.Settings.Get("title") + " " + Resources.Common.Contact, strBody);
            SmtpClient smtp = new SmtpClient(Utils.Settings.Get("smtp"));
            smtp.Send(message);
            lblReport.report(true, GetLocalResourceObject("MessageSent").ToString(), null);
        }
        catch(Exception ex)
        {
            lblReport.report(false, Resources.Common.EmailError , ex);
        }
        pnlInput.Visible = false;
        pnlOutput.Visible = true;
    }
}
