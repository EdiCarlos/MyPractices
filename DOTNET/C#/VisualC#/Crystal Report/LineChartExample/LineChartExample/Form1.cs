using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LineChartExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.DataSet2.Employee);
            // TODO: This line of code loads data into the 'DataSet2.Orders_Detail' table. You can move, or remove it, as needed.
            this.Orders_DetailTableAdapter.Fill(this.DataSet2.Orders_Detail);

            this.reportViewer1.RefreshReport();
        }
    }
}
