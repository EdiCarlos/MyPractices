//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Users
/// </summary>
public static class Users
{
    public static bool Exists(dbDataContext db, string _user)
    {
        bool exists = (from p in db.users where p.userName.Equals(_user) select p).Count() > 0;
        HttpContext.Current.Session["isUser"] = exists.ToString();
        if (!exists)
        {
            string url = HttpContext.Current.Request.Url.ToString();
            if (!url.EndsWith("profile.aspx") && !url.Contains("help.aspx")) HttpContext.Current.Response.Redirect("~/profile.aspx");
        }
        return exists;
    }

    public static void Add(dbDataContext db, string name, string email, string phone, int _sub_unit)
    {
        user newUser = new user();
        newUser.userName = name;
        newUser.email = email;
        newUser.phone = phone;
        newUser.sub_unit = _sub_unit;
        db.users.InsertOnSubmit(newUser);
        db.SubmitChanges();
        if (newUser.id == 1) newUser.is_admin = true;
        db.SubmitChanges();
    }

    public static void Update(dbDataContext db, string name, string email, string phone, int _sub_unit)
    {
        user thisUser = db.users.First(u => u.userName.Equals(name));
        thisUser.userName = name;
        thisUser.email = email;
        thisUser.phone = phone;
        thisUser.sub_unit = _sub_unit;
        db.SubmitChanges();
    }

    public static user Get(dbDataContext db, string name)
    {
        return db.users.First(u => u.userName.Equals(name));
    }

    public static IEnumerable<user> allInUnit(dbDataContext db, int unitID)
    {
        return from p in db.users where p.sub_unit1.unit_ref == unitID select p;
    }

    public static void FlipAdmin(dbDataContext db, int userID)
    {
        user u = db.users.First(p => p.id == userID);
        u.is_admin = !u.is_admin;
        db.SubmitChanges();
    }
}
