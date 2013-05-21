using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindWinControls
{
    static class FindControls
    {
        public static IEnumerable<Control> FindAll(this Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                yield return item;
                if (item.HasChildren)
                {
                    foreach(Control cntr in item.Controls.FindAll())
                    {
                        yield return cntr;
                    }
                }
            }
        }
        public static bool HasControls(this Control item)
        {
            if (item.HasChildren)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
