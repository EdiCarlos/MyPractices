//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

/// <summary>
/// Summary description for Styles
/// </summary>
public static class Styles
{
    public static string Import(Stream xmlFile)
    {
        string output = string.Empty;
        try
        {
            TextReader rdr = new StreamReader(xmlFile);
            XElement x = XElement.Load(rdr);
            var styles = from p in x.Descendants("style") select p;

            foreach (XElement xe in styles)
            {
                dbDataContext db = new dbDataContext();
                Dictionary<string, string> styleAttributes = new Dictionary<string, string>();
                style s = new style();
                foreach (XAttribute xa in xe.Attributes())
                {
                    styleAttributes.Add(xa.Name.ToString(), xa.Value);
                }
                s.alt_rows = styleAttributes["alt_rows"];
                s.background = styleAttributes["background"];
                s.body = styleAttributes["body"];
                s.borders = styleAttributes["borders"];
                s.button_text = styleAttributes["button_text"];
                s.header = styleAttributes["header"];
                s.hover = styleAttributes["hover"];
                s.links = styleAttributes["links"];
                s.style_name = styleAttributes["style_name"];
                s.text_color = styleAttributes["text_color"];
                db.styles.InsertOnSubmit(s);
                try
                {
                    db.SubmitChanges(); //inefficient to submit each time, *but* this will tell which styles got inserted and which didn't
                    output += "<div class='success'>-" + styleAttributes["style_name"] + " " + Resources.Common.Updated + "</div>";
                }
                catch// (Exception ex)
                {
                    output += "<div class='error'>" + Resources.Common.Error + " " + styleAttributes["style_name"] + " - <span class='smaller'>most likely a duplicate</span></div>";
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
        var styles = Themes.List(new dbDataContext());
        XDocument xDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"));
        XElement root = new XElement("styles");
        foreach (style s in styles)
        {
            XElement xeStyle = new XElement("style");
            xeStyle.Add(new XAttribute("style_name", s.style_name));
            xeStyle.Add(new XAttribute("text_color", s.text_color));
            xeStyle.Add(new XAttribute("borders", s.borders));
            xeStyle.Add(new XAttribute("body", s.body));
            xeStyle.Add(new XAttribute("links", s.links));
            xeStyle.Add(new XAttribute("hover", s.hover));
            xeStyle.Add(new XAttribute("button_text", s.button_text));
            xeStyle.Add(new XAttribute("header", s.header));
            xeStyle.Add(new XAttribute("alt_rows", s.alt_rows));
            xeStyle.Add(new XAttribute("background", s.background));
            root.Add(xeStyle);
        }
        xDoc.Add(root);
        return xDoc;
    }
}
