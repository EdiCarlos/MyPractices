using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SupremeTransport
{
    public partial class Supreme_local_pending : Form
    {
        DataTable table;
        DateTime dt = DateTime.Now;

        public Supreme_local_pending()
        {
            InitializeComponent();
        }

        private void Supreme_local_pending_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lclsupset.selectlocalbill' table. You can move, or remove it, as needed.
            this.selectlocalbillTableAdapter.Fill(this.lclsupset.selectlocalbill);
            NotifyWithColor();
        }

        private void NotifyWithColor()
        {
            table = lclsupset.Tables["selectlocalbill"];
            DataColumn colDaysLft = new DataColumn("daysleft", typeof(int));
            DataColumn colDaysGne = new DataColumn("daysgone", typeof(int));
            DataColumn colttlDays = new DataColumn("totaldays", typeof(int));

            table.Columns.Add(colDaysLft);
            table.Columns.Add(colDaysGne);
            table.Columns.Add(colttlDays);

            
            dataGridView1.DataSource = table;

            dataGridView1.Columns["billrecieve"].HeaderText = "Bill Recieved";
            dataGridView1.Columns["StartDate"].HeaderText = "Start Date";
            dataGridView1.Columns["endDate"].HeaderText = "End Date";
            dataGridView1.Columns["Billno"].HeaderText = "Bill Number";
            dataGridView1.Columns["chequeno"].HeaderText = "Cheque Number";
            dataGridView1.Columns["localbillid"].HeaderText = "Bill Id";
            dataGridView1.Columns["billrcdate"].HeaderText = "Bill Recieved Date";
            dataGridView1.Columns["cheque_date"].HeaderText = "Cheque Date";
            
            dataGridView1.Columns["daysleft"].HeaderText = "Days Left";
            dataGridView1.Columns["daysgone"].HeaderText = "Days Gone";
            dataGridView1.Columns["totaldays"].HeaderText = "Total Days";
            FillDaysLeft();
            FillDaysGone();
            FillTotalDays();
            dataGridView1.Sort(dataGridView1.Columns["daysleft"], ListSortDirection.Ascending);


        }
        
        public void DefaultStyle()
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            Font fnt1 = new Font("Arial", 8, FontStyle.Bold);
            style1.Font = fnt1;
            dataGridView1.ColumnHeadersDefaultCellStyle = style1;
            int rows = dataGridView1.RowCount;
            dataGridView1.Refresh();
            for (int i = 0; i < rows; i++)
            {
                int val = int.Parse(dataGridView1["daysleft", i].Value.ToString());

                if (val < 0)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    Font fnt = new Font("Arial", 10, FontStyle.Bold);
                    style.Font = fnt;
                    style.ForeColor = Color.Black;
                    style.BackColor = Color.Brown;
                    style.SelectionBackColor = Color.Teal;
                    dataGridView1.Rows[i].DefaultCellStyle = style;
                }
                if (val >= 0 & val <= 5)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    Font fnt = new Font("Arial", 10, FontStyle.Bold);
                    style.Font = fnt;
                    style.ForeColor = Color.Black;
                    style.BackColor = Color.Red;
                    style.SelectionBackColor = Color.Teal;
                    dataGridView1.Rows[i].DefaultCellStyle = style;
                }
                if (val >= 6 & val <= 10)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    Font fnt = new Font("Arial", 10, FontStyle.Bold);
                    style.Font = fnt;
                    style.ForeColor = Color.Black;
                    style.BackColor = Color.Orange;
                    style.SelectionBackColor = Color.Teal;
                    dataGridView1.Rows[i].DefaultCellStyle = style;
                }
                if (val >= 11 & val <= 15)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    Font fnt = new Font("Arial", 10, FontStyle.Bold);

                    style.Font = fnt;
                    style.ForeColor = Color.Black;
                    style.BackColor = Color.Green;
                    style.SelectionBackColor = Color.Teal;

                    //dataGridView1.RowsDefaultCellStyle = style;
                    dataGridView1.Rows[i].DefaultCellStyle = style;
                }
                if (val > 15)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    Font fnt = new Font("Arial", 10, FontStyle.Bold);

                    style.Font = fnt;
                    style.ForeColor = Color.Black;
                    style.BackColor = Color.Bisque;
                    style.SelectionBackColor = Color.Teal;

                    //dataGridView1.RowsDefaultCellStyle = style;
                    dataGridView1.Rows[i].DefaultCellStyle = style;

                }
            }
        }

        private void FillTotalDays()
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int daysleft = int.Parse(dataGridView1["daysleft", i].Value.ToString());
                int daysgone = int.Parse(dataGridView1["daysgone", i].Value.ToString());
                DataRow row = table.Rows[i];
                row["totaldays"] = daysleft + daysgone;
            }
        }

        private void FillDaysGone()
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime t1 = DateTime.Parse(dataGridView1["StartDate", i].Value.ToString());
                DataRow row = table.Rows[i];
                row["daysgone"] = (DateTime.Now - t1).Days;
            }
        }

        private void FillDaysLeft()
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime t1 = DateTime.Parse(dataGridView1["enddate", i].Value.ToString());
                DataRow row = table.Rows[i];
                row["daysleft"] = (t1 - DateTime.Now).Days + 1;
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            DefaultStyle();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            System.Collections.IEnumerator ie = groupBox1.Controls.GetEnumerator();
            while (ie.MoveNext())
            {
                if (ie.Current is TextBox)
                {
                    TextBox txt = ie.Current as TextBox;
                    txt.Text = String.Empty;
                }
                if (ie.Current is DevExpress.XtraEditors.DateEdit)
                {
                    DevExpress.XtraEditors.DateEdit edit = ie.Current as DevExpress.XtraEditors.DateEdit;
                    edit.Text = String.Empty;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!dateEditstlc.Text.Equals(String.Empty) & (txtBillNumberstlc.Text == String.Empty & txtMsstlc.Text == String.Empty))
            {
                this.selectlocalbillTableAdapter.FillBylclBillDate(lclsupset.selectlocalbill, DateTime.Parse(dateEditstlc.Text));
                table = lclsupset.Tables["selectlocalbill"];
                NotifyWithColor(table);
            }
            else if (!txtBillNumberstlc.Text.Equals(String.Empty) & (txtMsstlc.Text.Equals(String.Empty) & txtMsstlc.Text.Equals(String.Empty)))
            {
                this.selectlocalbillTableAdapter.FillByLocalBillId(lclsupset.selectlocalbill, int.Parse(txtBillNumberstlc.Text.Trim()));
                table = lclsupset.Tables["selectlocalbill"];
                NotifyWithColor(table);
            }
            else if (!txtMsstlc.Text.Equals(String.Empty) & (txtBillNumberstlc.Text.Equals(String.Empty) & dateEditstlc.Text.Equals(String.Empty)))
            {
                this.selectlocalbillTableAdapter.FillBylclName(lclsupset.selectlocalbill, txtMsstlc.Text);
                dataGridView1.DataSource = lclsupset.selectlocalbill;
                table = lclsupset.Tables["selectlocalbill"];
                NotifyWithColor(table);
            }
            else
            {
                MessageBox.Show("Search By Any One Field", "Message");
            
            }
        }

        private void NotifyWithColor(DataTable table)
        {
            dataGridView1.DataSource = table;

            dataGridView1.Columns["billrecieve"].HeaderText = "Bill Recieved";
            dataGridView1.Columns["StartDate"].HeaderText = "Start Date";
            dataGridView1.Columns["endDate"].HeaderText = "End Date";
            dataGridView1.Columns["Billno"].HeaderText = "Bill Number";
            dataGridView1.Columns["chequeno"].HeaderText = "Cheque Number";
            dataGridView1.Columns["localbillid"].HeaderText = "Bill Id";
            dataGridView1.Columns["billrcdate"].HeaderText = "Bill Recieved Date";
            dataGridView1.Columns["cheque_date"].HeaderText = "Cheque Date";
            
            dataGridView1.Columns["daysleft"].HeaderText = "Days Left";
            dataGridView1.Columns["daysgone"].HeaderText = "Days Gone";
            dataGridView1.Columns["totaldays"].HeaderText = "Total Days";
            FillDaysLeft();
            FillDaysGone();
            FillTotalDays();
            dataGridView1.Sort(dataGridView1.Columns["daysleft"], ListSortDirection.Ascending);
        }

    }
}