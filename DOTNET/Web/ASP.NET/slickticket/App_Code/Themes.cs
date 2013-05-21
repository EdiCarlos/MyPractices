//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for Themes
/// </summary>
public static class Themes
{
    public static void Set(dbDataContext db, string text, string borders, string body, string links, string hover, string buttonText, string alt, string header, string bg)
    {
        style _style = db.styles.First(s => s.id == 1);
        _style.text_color = text;
        _style.borders = borders;
        _style.body = body;
        _style.links = links;
        _style.hover = hover;
        _style.button_text = buttonText;
        _style.alt_rows = alt;
        _style.header = header;
        _style.background = bg;
        db.SubmitChanges();
    }

    public static IEnumerable<style> List(dbDataContext db)
    {
        return from p in db.styles select p;
    }

    public static style Get(dbDataContext db, int theme)
    {
        return db.styles.First(t => t.id == theme);
    }

    public static void Delete(dbDataContext db, int theme)
    {
        db.styles.DeleteOnSubmit(Get(db, theme));
        db.SubmitChanges();
    }

    public static style Current(dbDataContext db)
    {
        return Get(db, 1);
    }

    public static void Reset(dbDataContext db)
    {
        style _default = db.styles.First(s => s.id == 2); //index of the default template
        Set(db, _default.text_color, _default.borders, _default.body, _default.links, _default.hover, _default.button_text, _default.alt_rows, _default.header, _default.background);
        db.SubmitChanges();
    }

    public static void Add(dbDataContext db, string name, string text, string borders, string body, string links, string hover, string button, string headers, string alt, string background)
    {
        style s = new style();
        s.style_name = name;
        s.text_color = text;
        s.borders = borders;
        s.body = body;
        s.links = links;
        s.hover = hover;
        s.button_text = button;
        s.header = headers;
        s.alt_rows = alt;
        s.background = background;
        db.styles.InsertOnSubmit(s);
        db.SubmitChanges();
    }
}
