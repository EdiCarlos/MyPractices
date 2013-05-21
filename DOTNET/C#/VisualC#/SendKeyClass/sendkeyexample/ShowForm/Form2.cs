using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShowForm
{
    public partial class Form2 : Form
    {
        IntPtr p;
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hwnd);
      
        public Form2()
        {
        }
        public Form2(IntPtr hwnd)
        {
            p = hwnd;
            InitializeComponent();
       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetForegroundWindow(p);
        }
    }
}
