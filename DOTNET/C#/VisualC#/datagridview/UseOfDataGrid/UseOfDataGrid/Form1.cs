using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace UseOfDataGrid
{
    public partial class Form1 : Form
    {
        DataTable table, newTable;
        int rowIndex = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
     
        }
      
      
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet.temp1' table. You can move, or remove it, as needed.
            //this.temp1TableAdapter.Fill(this.mydbDataSet.temp1);
            //table = this.mydbDataSet.Tables["temp1"];
            //dataGridView1.DataSource = table;
            backgroundWorker1.RunWorkerAsync();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //newTable = table.GetChanges();
            DateTime dt1 = DateTime.Now;
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=mydb;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from temp", con);
            //SqlDataReader read = cmd.ExecuteReader();
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from temp1", con);
            DataSet set = new DataSet("tempset");
            adap.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            Thread.Sleep(100);
            label3.Text = (DateTime.Now - dt1).ToString();
            //   this.table.AcceptChanges();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(rowIndex);
            this.temp1TableAdapter.Update(this.mydbDataSet.temp1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //button1.Enabled = true;
            ////DataGridViewRow row = new DataGridViewRow();
            //dataGridView1.AllowUserToAddRows = true;
            backgroundWorker1.RunWorkerAsync();
        }
        delegate void SetDataSourceOfGrid(DataTable table);
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=mydb;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand("select * from temp", con);
            //SqlDataReader read = cmd.ExecuteReader();
            backgroundWorker1.ReportProgress(0, "Opening Connection");
            con.Open();
            backgroundWorker1.ReportProgress(0, "Connection Opened");
            SqlDataAdapter adap = new SqlDataAdapter("select * from temp1", con);
            backgroundWorker1.ReportProgress(0, "Adapter Filled");
            DataSet set = new DataSet("tempset");
            backgroundWorker1.ReportProgress(0, "Filling DataSet");
            adap.Fill(set);
            backgroundWorker1.ReportProgress(0, "DataSet Filled");
            backgroundWorker1.ReportProgress(0, set.Tables[0]);
            backgroundWorker1.ReportProgress(0, dt1);
            backgroundWorker1.ReportProgress(0, "filling datagrid");
            
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState.GetType() == typeof(DataTable))
            {
                dataGridView1.DataSource = e.UserState;
            }
            label1.Text = e.UserState.ToString();
           
            if (e.UserState.GetType() == typeof(DateTime))
            {
                DateTime dt1 = (DateTime)e.UserState ;
                label2.Text = (DateTime.Now - dt1).ToString();
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "complete";
        }

        
    }
}
