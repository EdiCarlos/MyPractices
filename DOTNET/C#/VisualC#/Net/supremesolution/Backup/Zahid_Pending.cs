using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SupremeTransport
{
    public partial class Zahid_Pending : Form
    {
        DataTable table;
        DateTime dt = DateTime.Now;
        public Zahid_Pending()
        {
            InitializeComponent();
        }

        private void Zahid_Pending_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zmaindataset.zmainbill' table. You can move, or remove it, as needed.
            this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            //dataGridView1.DataSource = this.zmaindataset.zmainbill;
            FillPartyName();
            NotifyWithColor();
        }

        private void FillPartyName()
        {
            DataTableReader read = new DataTableReader(this.zmaindataset.zmainbill);
            while (read.Read())
            {
                txtPartyName.Items.Add(read.GetString(5));
            }
        }
       
        private void NotifyWithColor()
        {
            table = this.zmaindataset.Tables["zmainbill"];
            DataColumn colDaysLft = new DataColumn("daysleft", typeof(int));
            DataColumn colDaysGne = new DataColumn("daysgone", typeof(int));
            DataColumn colttlDays = new DataColumn("totaldays", typeof(int));

            table.Columns.Add(colDaysLft);
            table.Columns.Add(colDaysGne);
            table.Columns.Add(colttlDays);

            //table.Columns.Remove("billrecieve");
            //table.Columns.Remove("chequeno");
            //table.Columns.Remove("billrcvdate");
            table.Columns.Remove("billid");
            table.Columns.Remove("userid");

            dataGridView1.DataSource = table;

            dataGridView1.Columns["partyName"].HeaderText = "Party Name";
            dataGridView1.Columns["enddate"].HeaderText = "End Date";
            dataGridView1.Columns["billdate"].HeaderText = "Start Date";
            dataGridView1.Columns["enddate"].HeaderText = "End Date";
            dataGridView1.Columns["station"].HeaderText = "Station";
            dataGridView1.Columns["surcharge"].HeaderText = "Sur Charge";
            dataGridView1.Columns["tax"].HeaderText = "Tax";
            dataGridView1.Columns["mnbillid"].HeaderText = "Bill Id";
            dataGridView1.Columns["serviceCharge"].HeaderText = "Service Charge";
            dataGridView1.Columns["hsServiceCharge"].HeaderText = "H.S.Service Charge";
            dataGridView1.Columns["total"].HeaderText = "Total";
            dataGridView1.Columns["debitBillno"].HeaderText = "Debit Bill Number";
            dataGridView1.Columns["daysleft"].HeaderText = "Days Left";
            dataGridView1.Columns["daysgone"].HeaderText = "Days Gone";
            dataGridView1.Columns["totaldays"].HeaderText = "Total Days";

            dataGridView1.Columns["surcharge"].HeaderText = "Sur Charge";
            dataGridView1.Columns["billrecieve"].HeaderText = "Bill Recieved";
            dataGridView1.Columns["chequeno"].HeaderText = "Cheque Number";
            dataGridView1.Columns["billrcvdate"].HeaderText = "Bill Receive Date";

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            FillDaysLeft();
            FillDaysGone();
            FillTotalDays();
            dataGridView1.Sort(dataGridView1.Columns["daysleft"], ListSortDirection.Ascending);
            CountTotalAmountPending();
        }
        private void NotifyWithColor(DataTable table)
        {
            //table.Columns.Remove("billrecieve");
            //table.Columns.Remove("chequeno");
            //table.Columns.Remove("billrcvdate");
            table.Columns.Remove("billid");
            table.Columns.Remove("userid");

            dataGridView1.DataSource = table;

            dataGridView1.Columns["partyName"].HeaderText = "Party Name";
            dataGridView1.Columns["enddate"].HeaderText = "End Date";
            dataGridView1.Columns["billdate"].HeaderText = "Start Date";
            dataGridView1.Columns["enddate"].HeaderText = "End Date";
            dataGridView1.Columns["station"].HeaderText = "Station";
            dataGridView1.Columns["surcharge"].HeaderText = "Sur Charge";
            dataGridView1.Columns["tax"].HeaderText = "Tax";
            dataGridView1.Columns["mnbillid"].HeaderText = "Bill Id";
            dataGridView1.Columns["serviceCharge"].HeaderText = "Service Charge";
            dataGridView1.Columns["hsServiceCharge"].HeaderText = "H.S.Service Charge";
            dataGridView1.Columns["total"].HeaderText = "Total";
            dataGridView1.Columns["debitBillno"].HeaderText = "Debit Bill Number";
            dataGridView1.Columns["daysleft"].HeaderText = "Days Left";
            dataGridView1.Columns["daysgone"].HeaderText = "Days Gone";
            dataGridView1.Columns["totaldays"].HeaderText = "Total Days";

            dataGridView1.Columns["surcharge"].HeaderText = "Sur Charge";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            FillDaysLeft();
            FillDaysGone();
            FillTotalDays();
            dataGridView1.Sort(dataGridView1.Columns["daysleft"], ListSortDirection.Ascending);
            CountTotalAmountPending();
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
                DateTime t1 = DateTime.Parse(dataGridView1["billdate", i].Value.ToString());
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
            // dataGridView1.DataSource = table;
        }

        private void CountTotalAmountPending()
        {
            decimal total = 0;
            int totalRows = dataGridView1.Rows.Count;
            for (int i = 0; i < totalRows; i++)
            {
                total += decimal.Parse(dataGridView1["total", i].Value.ToString());
            }
            txtTotalPendingAmount.Text = Convert.ToString(total);
        }
        
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            DefaultStyle();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string PartyName = txtPartyName.Text.Trim();
            int BillNumber = int.Parse(txtDebitBillNo.Text.Trim() == String.Empty ? "0" : txtDebitBillNo.Text.Trim());
            DateTime BillDate = DateTime.Parse(dtBilMain.Text.ToString() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtBilMain.Text.ToString());
            string Station = txtStation.Text.Trim() != String.Empty ? txtStation.Text.Trim() : "N.A";

            //if (txtPartyName.Text.Length != 0 & txtDebitBillNo.Text.Length != 0 & txtStation.Text.Length != 0 & dtBilMain.Text.Length != 0)
            //{
            //    this.zmainbillTableAdapter.FillByMainSearch(zmaindataset.zmainbill, PartyName, Station, BillNumber, BillDate);
            //}
            //else if (txtPartyName.Text.Length != 0 & txtStation.Text.Length != 0)
            //{
            //    this.zmainbillTableAdapter.FillByMainSearchPartyAndStation(zmaindataset.zmainbill, PartyName, Station);
            //}
            //else if (txtPartyName.Text.Length != 0 & txtStation.Text.Length != 0 & txtDebitBillNo.Text.Length != 0)
            //{
            //    this.zmainbillTableAdapter.FillByMainSearchPartyStationAndDbno(zmaindataset.zmainbill, PartyName, Station, BillNumber);
            //}
            if (txtPartyName.Text.Length != 0 && (txtDebitBillNo.Text == "0" & txtStation.Text.Length == 0 & dtBilMain.Text.Length == 0))
            {
                this.zmainbillTableAdapter.FillByMainSearchPartyName(this.zmaindataset.zmainbill, PartyName);
                table = this.zmaindataset.Tables["zmainbill"];
                NotifyWithColor(table);
                DefaultStyle();
            }
            else if (txtDebitBillNo.Text != "0" & (txtPartyName.Text.Length == 0 & txtStation.Text.Length == 0 & dtBilMain.Text.Length == 0))
            {
                this.zmainbillTableAdapter.FillByMainSearchDebitBillNo(this.zmaindataset.zmainbill, BillNumber);
                table = this.zmaindataset.Tables["zmainbill"];
                NotifyWithColor(table);
                DefaultStyle();
            }
            else if (dtBilMain.Text.Length != 0 & (txtDebitBillNo.Text == "0" & txtStation.Text.Length == 0 & txtPartyName.Text.Length == 0))
            {
                this.zmainbillTableAdapter.FillMainSearchByBillDate(this.zmaindataset.zmainbill, BillDate);
                table = this.zmaindataset.Tables["zmainbill"];
                NotifyWithColor(table);
                DefaultStyle();
            }
            else if (txtStation.Text.Length != 0 & (txtDebitBillNo.Text == "0" & txtPartyName.Text.Length == 0 & dtBilMain.Text.Length == 0))
            {
                this.zmainbillTableAdapter.FillByMainSearchStation(this.zmaindataset.zmainbill, Station);
                table = this.zmaindataset.Tables["zmainbill"];
                NotifyWithColor(table);
                DefaultStyle();
            }
            else
            {
                MessageBox.Show("Search By Any One Field", "Message");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            System.Collections.IEnumerator ie = groupBySearchBox.Controls.GetEnumerator();
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
                if (ie.Current is ComboBox)
                {
                    ComboBox box = ie.Current as ComboBox;
                    box.Text = String.Empty;
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_Sorted_1(object sender, EventArgs e)
        {
            DefaultStyle();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPendingReport();
        }

        private void RefreshPendingReport()
        {
            table.Clear();
            this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            table = this.zmaindataset.Tables["zmainbill"];
           
            table.Columns.Remove("billid");
            table.Columns.Remove("userid");

            dataGridView1.DataSource = table;

            dataGridView1.Columns["partyName"].HeaderText = "Party Name";
            dataGridView1.Columns["enddate"].HeaderText = "End Date";
            dataGridView1.Columns["billdate"].HeaderText = "Start Date";
            dataGridView1.Columns["enddate"].HeaderText = "End Date";
            dataGridView1.Columns["station"].HeaderText = "Station";
            dataGridView1.Columns["surcharge"].HeaderText = "Sur Charge";
            dataGridView1.Columns["tax"].HeaderText = "Tax";
            dataGridView1.Columns["mnbillid"].HeaderText = "Bill Id";
            dataGridView1.Columns["serviceCharge"].HeaderText = "Service Charge";
            dataGridView1.Columns["hsServiceCharge"].HeaderText = "H.S.Service Charge";
            dataGridView1.Columns["total"].HeaderText = "Total";
            dataGridView1.Columns["debitBillno"].HeaderText = "Debit Bill Number";
            dataGridView1.Columns["daysleft"].HeaderText = "Days Left";
            dataGridView1.Columns["daysgone"].HeaderText = "Days Gone";
            dataGridView1.Columns["totaldays"].HeaderText = "Total Days";

            dataGridView1.Columns["surcharge"].HeaderText = "Sur Charge";
            dataGridView1.Columns["billrecieve"].HeaderText = "Bill Recieved";
            dataGridView1.Columns["chequeno"].HeaderText = "Cheque Number";
            dataGridView1.Columns["billrcvdate"].HeaderText = "Bill Receive Date";

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            FillDaysLeft();
            FillDaysGone();
            FillTotalDays();
            dataGridView1.Sort(dataGridView1.Columns["daysleft"], ListSortDirection.Ascending);
            CountTotalAmountPending();
        }
    }
}