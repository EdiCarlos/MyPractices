using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FindControls
{
    class EnableButton
    {
        public static void Enable(Control.ControlCollection frm, string name)
        {
            //(FindControl.GetControl(frm, name)).Enabled = true;
        }
        public static void Disable(Control.ControlCollection frm, string name)
        {
            FindControl.GetControl(frm, name);
            FindControl.MyControl.Enabled = false;
        }
    }
    class FindControl
    {
        private static Control myControl;

        public static Control MyControl
        {
            get { return FindControl.myControl; }
            set { FindControl.myControl = value; }
        }
        public static void GetControl(Control.ControlCollection control, string controlName)
        {
            foreach (Control tempcontrol in control)
            {
                if (tempcontrol.HasChildren)
                {
                    GetControl(tempcontrol.Controls, controlName);
                }
                else if (tempcontrol.Name == controlName)
                {
                    MyControl = tempcontrol;
                    return;
                }
            }
        }
    }
}
