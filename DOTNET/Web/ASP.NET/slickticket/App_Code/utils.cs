//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

/// <summary>
///  App Utilities
/// </summary>
public class Utils
{
    public static List<string> UserGroups()
    {
        List<string> groups = new List<string>();
        List<string> groups_share = new List<string>();
        foreach (System.Security.Principal.IdentityReference group in System.Web.HttpContext.Current.Request.LogonUserIdentity.Groups)
        {
            string fullGroupName = group.Translate(typeof(System.Security.Principal.NTAccount)).ToString();
            int slashIndex = fullGroupName.IndexOf("\\");
            if (slashIndex > -1)
                fullGroupName = fullGroupName.Substring(slashIndex + 1, fullGroupName.Length - slashIndex - 1);
            groups.Add(fullGroupName);
            groups_share.Add(fullGroupName);
        }
        return groups;
    }

    public static string UserName()
    {
        try { return (HttpContext.Current.User.Identity.Name.Split(new char[] { '\\' }))[1]; }
        catch { return HttpContext.Current.User.Identity.Name; } // if the user is not on a domain
    }

    public static string TrimForSideBar(string trimThis, int toLength)
    {
        if (trimThis.Length > toLength) trimThis = trimThis.Substring(0, toLength) + "...";
        return trimThis;
    }

    public static int ADGroupListUpdate()
    {
        string file_location = HttpContext.Current.Server.MapPath("~") + "\\App_Data\\ADGroups.xml";
        int GroupCount = 0;

        DirectoryEntry dirEnt = new DirectoryEntry("LDAP://" + Utils.Settings.Get("domain_controller") );
        string[] loadProps = new string[] { "name" }; 

        XDocument xDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
        XElement root = new XElement("groups");

        using (DirectorySearcher srch = new DirectorySearcher(dirEnt, "(objectClass=Group)", loadProps))
        {
            srch.PageSize = 6000;
            var results = SafeFindAll(srch);
            foreach (SearchResult sr in results)
            {
                XElement xe = new XElement("group", sr.Properties["name"][0].ToString());
                root.Add(xe);
                GroupCount++;
            }
        }

        xDoc.Add(root);
        if (File.Exists(file_location)) File.Delete(file_location);
        xDoc.Save(file_location);

        return GroupCount;
    }

    public static IEnumerable<SearchResult> SafeFindAll(DirectorySearcher searcher)
    {
        using (SearchResultCollection results = searcher.FindAll())
        {
            foreach (SearchResult result in results)
            {
                yield return result;
            } // SearchResultCollection will be disposed here
        }
    }
    
    public static void SendEmail(string to, string subject, string body)
    {
        MailMessage message = new MailMessage(Utils.Settings.Get("system_email"), to, subject, body);
        SmtpClient smtp = new SmtpClient(Utils.Settings.Get("smtp"));
        smtp.Send(message);
    }
    
    public static user_group AccessLevel()
    {
        dbDataContext db = new dbDataContext();
        try
        {
            try
            { return (from p in Permissions.List(db) where UserGroups().Contains(p.ad_group) orderby p.security_level descending select p).FirstOrDefault(); }
            catch
            { return db.user_groups.First(); }
        }
        catch
        {
            user_group dummy = new user_group();
            dummy.id = 0;
            return dummy;
        }
    }

    public static void PopulateSubUnits(dbDataContext db, DropDownList ddlFrom, DropDownList ddlTo, int accessLevel)
    {
        ddlTo.Items.Clear();
        var sus = Groups.SubGroups.List(db, Int32.Parse(ddlFrom.SelectedValue), accessLevel);
        if (sus.Count() < 1)
            ddlTo.Items.Add(new ListItem("No sub-groups available to you", "0"));
        else
            foreach (sub_unit su in sus) ddlTo.Items.Add(new ListItem(su.sub_unit_name, su.id.ToString()));
    }

    public class Settings
    {
        public static string Get(string setting)
        {
            XElement x = XElement.Load(HttpContext.Current.Server.MapPath("~") + "\\App_Data\\settings.xml");
            return (from p in x.Descendants(setting) select p).First().Value;
        }

        public static void Update(string setting, string value)
        {
            string file_location = HttpContext.Current.Server.MapPath("~") + "\\App_Data\\settings.xml";
            XElement x = XElement.Load(file_location);
            XElement xe = (from p in x.Descendants(setting) select p).First();
            xe.Value = value;
            x.Save(file_location);
        }
        public static bool EmailIsRestricted()
        {
            XElement x = XElement.Load(HttpContext.Current.Server.MapPath("~") + "\\App_Data\\settings.xml");
            return bool.Parse((from p in x.Descendants("restrict_email_addresses") select p).First().Value);
        }
    }

    public class Menus
    {
        public static IEnumerable<XElement> Main()
        {
            XDocument x = XDocument.Load(HttpContext.Current.Server.MapPath("~/") + "/App_Data/main_menu.xml");
            return from p in x.Descendants("page") select p;
        }

        public static IEnumerable<XElement> Admin()
        {
            XDocument x = XDocument.Load(HttpContext.Current.Server.MapPath("~/") + "/App_Data/main_menu.xml");
            return from p in x.Descendants("admin_page") select p;
        }
    }
}
