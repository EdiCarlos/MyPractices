using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace AssemblyExtensionMethods
{
    public static class Util
    {
        public static int GetInt(this string txt)
        {
            return Convert.ToInt32(txt);
        }
    }
}
