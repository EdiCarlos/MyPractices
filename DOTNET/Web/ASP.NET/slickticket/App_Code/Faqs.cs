//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

/// <summary>
/// Summary description for Faqs
/// </summary>
public static class Faqs
{
    public static void Add(dbDataContext db, string q, string a)
    {
        faq f = new faq();
        f.title = q;
        f.body = a;
        db.faqs.InsertOnSubmit(f);
        db.SubmitChanges();
    }

    public static void Delete(dbDataContext db, int id)
    {
        db.faqs.DeleteOnSubmit(Get(db, id));
        db.SubmitChanges();
    }

    public static faq Get(dbDataContext db, int id)
    {
        return db.faqs.First(f => f.id == id);
    }

    public static IEnumerable<faq> List(dbDataContext db)
    {
        return from p in db.faqs select p;
    }

    public static void Edit(dbDataContext db, int id, string q, string a)
    {
        faq f = Get(db, id);
        f.title = q;
        f.body = a;
        db.SubmitChanges();
    }

    public static string Import(Stream xmlFile)
    {
        string output = string.Empty;
        try
        {
            TextReader rdr = new StreamReader(xmlFile);
            XElement x = XElement.Load(rdr);
            var faqs = from p in x.Descendants("faq") select p;

            foreach (XElement xe in faqs)
            {
                dbDataContext db = new dbDataContext();
                faq f = new faq();
                f.title = xe.FirstAttribute.Value;
                f.body = xe.Value;
                db.faqs.InsertOnSubmit(f);
                try
                {
                    db.SubmitChanges(); //inefficient to submit each time, *but* this will tell which faqs got inserted and which didn't
                    output += "<div class='success'>-" + xe.FirstAttribute.Value + " " + Resources.Common.Updated + "</div>";
                }
                catch// (Exception ex)
                {
                    output += "<div class='error'>" + Resources.Common.Error + " " + xe.FirstAttribute.Value + "</div>";
                }
            }
        }
        catch (Exception ex)
        {
            output = "<div class='error'>" + Resources.Common.Error + ": <div class='sub_error'>" + ex.Message + "</div></div>";
        }
        return output;
    }

    public static XDocument Export()
    {
        var faqs = Faqs.List(new dbDataContext());
        XDocument xDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
        XElement root = new XElement("faqs");
        foreach (faq f in faqs)
        {
            XElement xeFaq = new XElement("faq");
            xeFaq.Add(new XAttribute("name", f.title));
            xeFaq.SetValue(f.body);
            root.Add(xeFaq);
        }
        xDoc.Add(root);
        return xDoc;
    }
}
