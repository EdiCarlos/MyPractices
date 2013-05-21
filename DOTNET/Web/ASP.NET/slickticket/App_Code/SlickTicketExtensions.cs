//Slick-Ticket v2.0 - 2009
//http://slick-ticket.com :: http://naspinski.net
//Developed by Stan Naspinski - stan@naspinski.net

using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// extensions for calling from dbml objects
/// </summary>
 
namespace SlickTicketExtensions
{
    public static class tickets
    {
        public static double averageAge(this IEnumerable<ticket> tix)
        {
            var ages = (from p in tix select new { days = (DateTime.Now - p.submitted).Days }).ToList();
            List<int> lstAges = new List<int>();
            foreach (var v in ages) lstAges.Add(v.days);
            return lstAges.Average();
        }

        public static IEnumerable<ticket> olderThan(this IEnumerable<ticket> tix, int days)
        {
            return from p in tix where (DateTime.Now - p.submitted).Days > days select p;
        }

        public static double averageCloseTime(this IEnumerable<ticket> tix)
        {
            try
            {
                var times = (from p in tix select new { days = (p.closed - p.submitted).Days }).ToList();
                List<int> lstTimes = new List<int>();
                foreach (var v in times) lstTimes.Add(v.days);
                return lstTimes.Average();
            }
            catch
            { return 0.0; }
        }
    }

    public static class dropdowns
    {
        public static void set(this DropDownList ddl, string findByVal)
        {
            ddl.SelectedIndex = ddl.Items.IndexOf(ddl.Items.FindByValue(findByVal));
        }

        public static int SelectedValueToInt(this DropDownList ddl)
        {
            return Convert.ToInt32(ddl.SelectedValue);
        }
    }

    public static class strings 
    {
        public static string capitalize(this string s)
        {
            if (s.Length > 1) return s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1).ToLower();
            else if (s.Length == 1) return s.ToUpper();
            else return string.Empty;
        }
    }

    public static class labels
    {
        public static void report(this Label lbl, bool successful, string message, Exception ex)
        {
            lbl.CssClass = successful ? "success top_error" : "error top_error";
            lbl.Text = message.capitalize();
            if (ex != null) lbl.Text += "<div class='sub_error'>" + ex.Message.capitalize() + "</div>";
        }
    }
}
