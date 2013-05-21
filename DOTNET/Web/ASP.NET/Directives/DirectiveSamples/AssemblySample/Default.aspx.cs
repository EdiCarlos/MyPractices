using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssemblyExtensionMethods;
using AssemblyCalc;

namespace AssemblySample
{
    public partial class _Default : System.Web.UI.Page
    {
        int result;
        public void btn_Result(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "+":
                    txtNum1.Text.GetInt(); 
                    break;
                case "-":
                    break;
                case"/":
                    break;
                case "*":
                    break;
                case "Invalid Option":
                    break;
            }
        }
    }
}
