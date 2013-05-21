using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SupremeTransport
{

    public partial class Supreme_Pend : Form
    {
        #region Variable For this form
        DataTable table;
        DateTime dt = DateTime.Now;
        
#endregion

        #region Constructor For this class
        public Supreme_Pend()
        {
            InitializeComponent();

        }
        #endregion

        #region Form Event Load Event
        private void Supreme_Pend_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maindataset.Pending' table. You can move, or remove it, as needed.
            this.pendingTableAdapter.Fill(this.maindataset.Pending);
            
            // TODO: This line of code loads data into the 'maindataset.mainbill' table. You can move, or remove it, as needed.
            //this.mainbillTableAdapter.FillBySupr(this.maindataset.mainbill);
           
            FillPartyName();
            NotifyWithColor();

        }
        #endregion

        #region Fill Party Name
        private void FillPartyName()
        {
            DataTableReader read = new DataTableReader(this.maindataset.Pending);
            while (read.Read())
            {
                txtPartyName.Items.Add(read.GetString(3));
            }
        }
        #endregion

        #region NotifyWithColor Functions
        private void NotifyWithColor()
        {
            table = this.maindataset.Tables["pending"];
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Sort(dataGridView1.Columns["daysleftDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
            CountTotalAmountPending();
        }
       
        private void NotifyWithColor(DataTable table)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CountTotalAmountPending();
            dataGridView1.Sort(dataGridView1.Columns["daysleftDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
        }
        #endregion

        #region Function To count total Bill
        private void CountTotalAmountPending()
        {
            decimal total = 0;
            int totalRows = dataGridView1.Rows.Count;
            for (int i = 0; i < totalRows; i++)
            {
                total += decimal.Parse(dataGridView1["totalDataGridViewTextBoxColumn", i].Value.ToString());
            }
            txtTotalPendingAmount.Text = Convert.ToString(total);
        }
        #endregion

        #region RefreshPending Report
        private void RefreshPendingReport()
        {
            this.pendingTableAdapter.Fill(this.maindataset.Pending);
            table = this.maindataset.Tables["pending"];
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Sort(dataGridView1.Columns["daysleftDataGridViewTextBoxColumn"], ListSortDirection.Ascending);
            CountTotalAmountPending();
        }
        #endregion

        #region Playing Style To Forms
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
                int val = int.Parse(dataGridView1["daysleftDataGridViewTextBoxColumn", i].Value.ToString());

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
        #endregion


        #region datagridview Sort events
        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            DefaultStyle();
        }
        #endregion

        #region All button Click Events in SupremeTemp
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string PartyName = txtPartyName.Text.Trim();
            int BillNumber = int.Parse(txtDebitBillNo.Text.Trim() == String.Empty ? "0" : txtDebitBillNo.Text.Trim());
            DateTime BillDate = DateTime.Parse(dtBilMain.Text.ToString() == String.Empty ? new DateTime(2010, 01, 01).ToString() : DateTime.Parse(dtBilMain.Text).ToShortDateString());
            string Station = txtStation.Text.Trim() != String.Empty ? txtStation.Text.Trim() : "N.A";


            if (txtPartyName.Text.Length != 0 & (txtDebitBillNo.Text == "0" & txtStation.Text.Length == 0 & dtBilMain.Text.Length == 0))
            {
                this.pendingTableAdapter.FillByPenMainSearchPartyName(this.maindataset.Pending, PartyName);
                table = maindataset.Tables["pending"];
                NotifyWithColor(table);
                DefaultStyle();

            }
            else if (txtDebitBillNo.Text != "0" & (txtPartyName.Text.Length == 0 & txtStation.Text.Length == 0 & dtBilMain.Text.Length == 0))
            {
                this.pendingTableAdapter.FillByPenSearchByDebitBillNo(this.maindataset.Pending, BillNumber);
                table = maindataset.Tables["pending"];
                NotifyWithColor(table);
                DefaultStyle();

            }
            else if (dtBilMain.Text.Length != 0 & (txtDebitBillNo.Text == "0" & txtStation.Text.Length == 0 & txtPartyName.Text.Length == 0))
            {
                this.pendingTableAdapter.FillByPenSearchByBillDate(this.maindataset.Pending, BillDate);
                table = maindataset.Tables["pending"];
                NotifyWithColor(table);
                DefaultStyle();

            }
            else if (txtStation.Text.Length != 0 & (txtDebitBillNo.Text == "0" & txtPartyName.Text.Length == 0 & dtBilMain.Text.Length == 0))
            {
                this.pendingTableAdapter.FillByPenMainSearchByStation(this.maindataset.Pending, Station);
                table = maindataset.Tables["pending"];
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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPendingReport();

        }
        #endregion
    }
}