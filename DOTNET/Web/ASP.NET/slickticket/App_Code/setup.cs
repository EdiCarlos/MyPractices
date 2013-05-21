//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System.Linq;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Used initially for setup
/// </summary>

public static class Setup
{
    public class Settings
    {
        public static string Get(string setting)
        {
            XElement x = XElement.Load(HttpContext.Current.Server.MapPath(".") + "\\setup_Data\\setup.xml");
            return (from p in x.Descendants(setting) select p).First().Value;
        }

        public static void Update(string setting, string value)
        {
            string file_location = HttpContext.Current.Server.MapPath(".") + "\\setup_Data\\setup.xml";
            XElement x = XElement.Load(file_location);
            XElement xe = (from p in x.Descendants(setting) select p).First();
            xe.Value = value;
            x.Save(file_location);
        }
    }

    public class Patch
    {
        public static string Get(string setting)
        {
            XElement x = XElement.Load(HttpContext.Current.Server.MapPath(".") + "\\patch_Data\\patch.xml");
            return (from p in x.Descendants(setting) select p).First().Value;
        }

        public static void Update(string setting, string value)
        {
            string file_location = HttpContext.Current.Server.MapPath(".") + "\\patch_Data\\patch.xml";
            XElement x = XElement.Load(file_location);
            XElement xe = (from p in x.Descendants(setting) select p).First();
            xe.Value = value;
            x.Save(file_location);
        }
    }
}
