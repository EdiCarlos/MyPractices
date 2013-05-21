using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace LWithDatabase
{
    public partial class Form1 : Form
    {
        mydbsqlDataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new mydbsqlDataContext();
            var datasource = from dt in db.dets join condt in db.condets on dt.conzip equals condt.zip select new {dt.empid, dt.fname, dt.lname, dt.mname, condt.city, condt.state, condt.town, condt.zip };
            dataGridView1.DataSource = datasource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != String.Empty)
            {
                int id = Convert.ToInt32(textBox1.Text);
                var datasource = from dt in db.dets join condt in db.condets on dt.conzip equals condt.zip select new { dt.empid, dt.fname, dt.lname, dt.mname, condt.city, condt.state, condt.town, dt.conzip }; 
                dataGridView1.DataSource = datasource;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var dt = from tdet in db.dets where tdet.empid == id select tdet;
            foreach (var v in dt)
            {
                v.fname = textBox2.Text;
                v.lname = textBox3.Text;
                v.mname = textBox4.Text;
                v.conzip = textBox5.Text;
            }
            db.SubmitChanges();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["empid"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["fname"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["mname"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["lname"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["zip"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table<det> tb = db.GetTable<det>();
            det dt = new det();

            dt.fname = textBox2.Text;
            dt.lname = textBox3.Text;
            dt.mname = textBox4.Text;
            dt.conzip = textBox5.Text;
            db.dets.InsertOnSubmit(dt);
            db.SubmitChanges();
            var data = from t in tb select t;
            dataGridView1.DataSource = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IQueryable<det> det = from t1 in db.dets where t1.empid == Convert.ToInt32(textBox1.Text) select t1;
            db.dets.DeleteOnSubmit(det.First());
            db.SubmitChanges();
            var data = from t in db.dets select t;
            dataGridView1.DataSource = data;
        }
    }
}
