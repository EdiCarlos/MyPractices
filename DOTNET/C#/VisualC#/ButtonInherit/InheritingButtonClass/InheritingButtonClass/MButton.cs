using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace InheritingButtonClass
{
   [ToolboxBitmap(typeof(MButton), "MButton.ico")]
    class MButton : Button
    {
        private string _id;
       [Category("Apperance")]
       [Description("Gets the id for MButton")]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
       [Category("Apperance")]
       [Description("Enter mouse Event")]
       public event MouseEventHandler MouseDownHandler;
        public virtual void OnMDown()
        {
            RaiseOnMDown(new MouseEventArgs(MouseButtons.Left, 1, 10, 10, 10));

        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            RaiseOnMDown(mevent);
        }
        public virtual void RaiseOnMDown(MouseEventArgs e)
        {
            if (MouseDownHandler != null)
            {
                MouseDownHandler(this, e);
            }
        }
    }
}
