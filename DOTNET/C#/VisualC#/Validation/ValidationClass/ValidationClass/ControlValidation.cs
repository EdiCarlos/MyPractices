using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidationClass
{
    class ControlValidation
    {
        public static bool ValidateControl(Control.ControlCollection controls, Form1 frm)
        {
            foreach (Control cntr in controls)
            {
                if (cntr.HasChildren)
                {
                    if (!ValidateControl(cntr.Controls, frm))
                    {
                        break;
                    }
                }
                else
                {
                    cntr.Focus();
                    if (!frm.Validate())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
