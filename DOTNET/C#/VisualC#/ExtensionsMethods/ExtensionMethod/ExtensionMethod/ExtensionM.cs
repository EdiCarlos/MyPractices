using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExtensionMethod
{
    static class ExtensionM
    {
        public static Control FindAll(this Control.ControlCollection controls, Type type)
        {
            foreach (Control item in controls)
            {
                yield return item;
                if (item.GetType() == type)
                {
                    if (item.HasChildren)
                    {
                        foreach(Control cntr in item.Controls.FindAll(type))
                        {
                            yield return cntr;
                        }
                    }
                }
            }
        }
    }
}
