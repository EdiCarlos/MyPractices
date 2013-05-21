using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections;

namespace Report1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MyDataBaseDataSet1.mainbilll' table. You can move, or remove it, as needed.
            this.mainbilllTableAdapter.Fill(this.MyDataBaseDataSet1.mainbilll);
            DataTable table = this.MyDataBaseDataSet1.Tables[1];

            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboBox1.Items.Add(read.GetInt32(0));
            }
            read.Close();
            this.reportViewer1.RefreshReport();

            //Microsoft.Reporting.WinForms.ReportPageSettings settings = this.reportViewer1.LocalReport.GetDefaultPageSettings();
            //settings.Margins.Bottom = 25;
            //settings.Margins.Top = 25;
            //settings.Margins.Left = 25;
            //settings.Margins.Right = 25;
            //Microsoft.Reporting.WinForms.
           

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mnbillid = Convert.ToInt32(this.comboBox1.SelectedItem.ToString());
            this.billTableAdapter1.Fill(this.MyDataBaseDataSet1.bill, mnbillid);
            this.reportViewer1.RefreshReport();
        }

    }
}
