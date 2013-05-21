using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TextBoxV
{
    public class TextBox1 : TextBox
    {
        Font fnt;
        public TextBox1()
        {
        }
        public TextBox1(string txt)
        {
            fnt = new Font("Arial", 10, FontStyle.Bold);
            base.ForeColor = Color.Red;
            base.Font = fnt;
        }
        
        public override System.Drawing.Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
            }
        }
        public override int MaxLength
        {
            get
            {
                return base.MaxLength;
            }
            set
            {
                base.MaxLength = value;
            }
        }
    }
}
