using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace SendEmailApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAddress from = new MailAddress("mail@arifkhan.com");
            MailAddress to = new MailAddress("arif788@gmail.com");
            MailMessage mailmsg = new MailMessage(from, to);
            mailmsg.Subject = "Test Mail";
            mailmsg.Body = "This is test mail";
            SmtpClient client = new SmtpClient("127.0.0.1");
            client.Send(mailmsg);
        }
    }
}
