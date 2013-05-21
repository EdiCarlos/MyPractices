using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridEnhancement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns[2].Frozen = true;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
        }
    }
}
