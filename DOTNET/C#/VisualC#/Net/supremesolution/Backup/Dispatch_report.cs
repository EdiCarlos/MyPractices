using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraEditors;

namespace SupremeTransport
{
    public partial class Dispatch_report : Form
    {
       
        public Dispatch_report()
        {
            InitializeComponent();
        }

        private void Dispatch_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dispatchDataSet.SelectDispatchReport' table. You can move, or remove it, as needed.
            this.selectDispatchReportTableAdapter.Fill(this.dispatchDataSet.SelectDispatchReport);
            
            
        }


        #region Fields Variables
        private string dpNumber, truckNumber, vatNumber, partyName, station, goods,
     bags, mt, remarks;
        decimal rate, advance, total, balance, expense;

        

        int gcNumber, chalanNumber;
        int billId;

        public int BillId
        {
            get { return billId; }
            set { billId = value; }
        }
        DateTime enteredDate;

        #region Datetime getSetter
        public DateTime EnteredDate
        {
            get { return enteredDate; }
            set { enteredDate = value; }
        }
        #endregion


        #region String Fields
        public string PartyName
        {
            get { return partyName; }
            set { partyName = value; }
        }

        public string Station
        {
            get { return station; }
            set { station = value; }
        }

        public string Goods
        {
            get { return goods; }
            set { goods = value; }
        }

        public string Bags
        {
            get { return bags; }
            set { bags = value; }
        }

        public string Mt
        {
            get { return mt; }
            set { mt = value; }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        public string VatNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; }
        }

        public string TruckNumber
        {
            get { return truckNumber; }
            set { truckNumber = value; }
        }
        public string DpNumber
        {
            get { return dpNumber; }
            set { dpNumber = value; }
        }

        #endregion

        #region Int GetSetter
        public int GcNumber
        {
            get { return gcNumber; }
            set { gcNumber = value; }
        }

        public int ChalanNumber
        {
            get { return chalanNumber; }
            set { chalanNumber = value; }
        }
        #endregion

        #region Decimal getSetter
        public decimal ExpenseProperty
        {
            get { return expense; }
            set { expense = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public decimal Advance
        {
            get { return advance; }
            set { advance = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

#endregion

        #endregion

        #region DataGridView Events

        private void dataDispatchGrid_MouseClick(object sender, MouseEventArgs e)
        {
            dpDateEdit.Text = DateTime.Parse(dataDispatchGrid.CurrentRow.Cells["EnteredDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtdpPNo.Text = dataDispatchGrid.CurrentRow.Cells["PNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtDpGcnumber.Text = dataDispatchGrid.CurrentRow.Cells["GcNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckNumber.Text = dataDispatchGrid.CurrentRow.Cells["TruckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtChalanNumber.Text = dataDispatchGrid.CurrentRow.Cells["ChalanNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtVatNumber.Text = dataDispatchGrid.CurrentRow.Cells["VatNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtPartyName.Text = dataDispatchGrid.CurrentRow.Cells["PartyNameDataGridViewTextBoxColumn"].Value.ToString();
            txtStation.Text = dataDispatchGrid.CurrentRow.Cells["StationDataGridViewTextBoxColumn"].Value.ToString();
            txtGoods.Text = dataDispatchGrid.CurrentRow.Cells["GoodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBags.Text = dataDispatchGrid.CurrentRow.Cells["BagsDataGridViewTextBoxColumn"].Value.ToString();
            txtMT.Text = dataDispatchGrid.CurrentRow.Cells["MTDataGridViewTextBoxColumn"].Value.ToString();
            txtRateRMT.Text = dataDispatchGrid.CurrentRow.Cells["RateDataGridViewTextBoxColumn"].Value.ToString();
            txtAdvance.Text = dataDispatchGrid.CurrentRow.Cells["AdvanceDataGridViewTextBoxColumn"].Value.ToString();
            //txtAdvance.Text = dataDispatchGrid.CurrentRow.Cells["totalDataGridViewTextBoxColumn"].Value.ToString();
            txtRemark.Text = dataDispatchGrid.CurrentRow.Cells["RemarksDataGridViewTextBoxColumn"].Value.ToString();
            txtTotal.Text = dataDispatchGrid.CurrentRow.Cells["totalDataGridViewTextBoxColumn"].Value.ToString();
            txtBalance.Text = dataDispatchGrid.CurrentRow.Cells["BalanceDataGridViewTextBoxColumn"].Value.ToString();
            txtExpense.Text = dataDispatchGrid.CurrentRow.Cells["expenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalAdvance.Enabled = true;
            if (dataDispatchGrid.CurrentRow.Cells["Billreceived"].Value.GetType() != typeof(DBNull))
            {
                if ((bool)dataDispatchGrid.CurrentRow.Cells["Billreceived"].Value == true)
                {
                    chkBillreceived.Checked = true;

                }
                else
                {
                    chkBillreceived.Checked = false;
                }
            }
            else
            {
                chkBillreceived.Checked = false;
            }
            //txtTotalAdvance.Text = this.selectDispatchReportTableAdapter.ScalarQuery(dataDispatchGrid.CurrentRow.Cells["PNumberDataGridViewTextBoxColumn"].Value.ToString()).ToString();
            FillTotalAdvance();
            
            txtTotalAdvance.Enabled = false;
            BillId = int.Parse(dataDispatchGrid.CurrentRow.Cells["dIdDataGridViewTextBoxColumn"].Value.ToString());
            ChalanNumber = int.Parse(dataDispatchGrid.CurrentRow.Cells["ChalanNumberDataGridViewTextBoxColumn"].Value.ToString());

            rdDpUpdate.Enabled = true;
            rdDpUpdate.Checked = true;
        }

        private void FillTotalAdvance()
        {
            decimal total = 0;
            for(int i = 0; i < dataDispatchGrid.Rows.Count; i++)
            {
                //total += decimal.Parse(dataDispatchGrid["AdvanceDataGridViewTextBoxColumn", i].Value.ToString());
                total += decimal.Parse(dataDispatchGrid["totalDataGridViewTextBoxColumn", i].Value.ToString());
            }
            txtTotalAdvance.Text = Convert.ToString(total);
        }
        #endregion

        #region Button Click Events
        #region Data Insert Event on Button Click
        private void btnEnter_Click(object sender, EventArgs e)
        {
            InitializeFields();
            string message = String.Empty;
            string exists = String.Empty;
            if (!ValidateFieldsBeforeInsert(ref message))
            {
                if (!IfChalanAndGcExist(ref exists))
                {
                    int rows = 0;


                    rows = this.selectDispatchReportTableAdapter.Insert(UserLogin.Usergroup.ToString(), EnteredDate, DpNumber, GcNumber, TruckNumber, ChalanNumber, VatNumber, PartyName, Station, Goods, Bags, Mt, Rate, Advance, Remarks, Total, Balance, ExpenseProperty);
                    this.selectDispatchReportTableAdapter.Fill(dispatchDataSet.SelectDispatchReport);
                    dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
                    if (rows != 0)
                    {
                        MessageBox.Show("Dispatch Report Inserted into database");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please correct the errors \n\r" + exists, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All The Fields \n\r" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Close the Form Event on Button Click
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Data Delete Event on Button Click
        private void btnDelete_Click(object sender, EventArgs e)
        {

            int rows = this.selectDispatchReportTableAdapter.Delete(BillId, ChalanNumber);

            if (rows != 0)
            {
                ClearAllField();
                MessageBox.Show("Bill number With This Chalan Number " + ChalanNumber.ToString() + " Deleted", "Dispatch Report Deleted");
            }
            this.selectDispatchReportTableAdapter.Fill(dispatchDataSet.SelectDispatchReport);
            dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
        }
        #endregion
        #region Data UPdate Event on Button Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InitializeFields();
            
            int rows = this.selectDispatchReportTableAdapter.Update(BillId, UserLogin.Usergroup.ToString(), EnteredDate, DpNumber, TruckNumber, VatNumber, PartyName, Station, Goods, Bags, Mt, Rate, Advance, Remarks, Total, Balance, ExpenseProperty);

            if (rows != 0)
            {
                MessageBox.Show("Dispatch Report Updated");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }

            this.selectDispatchReportTableAdapter.Fill(dispatchDataSet.SelectDispatchReport);
            dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllField();
        }

        #endregion

        #region Validation Functions

        private bool ValidateFieldsBeforeInsert(ref string message)
        {
            ArrayList list = new ArrayList();
            if (dpDateEdit.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "Date Cannot Be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            if (txtChalanNumber.Text.Equals("0") | txtChalanNumber.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "Chalan Cannot Be Empty \n\r";

            }
            else
            {
                list.Add(false);
            }
            if (txtRateRMT.Text.Equals("0") | txtRateRMT.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "Rate Cannot Be Empty Or Zero \n\r";
            }
            else
            {
                list.Add(false);
            }

            if (txtAdvance.Text.Equals("0") | txtAdvance.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "Advance Cannot Be Empty Or Zero \n\r";
            }
            else
            {
                list.Add(false);
            }
            if (txtBalance.Text.Equals("0") | txtBalance.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "Balance Cannot Be Empty Or Zero \n\r";
            }
            else
            {
                list.Add(false);
            }

            if (txtTotal.Text.Equals("0") | txtTotal.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "Total Cannot Be Empty 0r Zero\n\r";
            }
            else
            {
                list.Add(false);
            }
            if (txtdpPNo.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "P Number Cannot Be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }

            if (txtDpGcnumber.Text.Equals("0") | txtDpGcnumber.Text.Equals(String.Empty))
            {
                list.Add(true);
                message += "G.C.Number Cannot Be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            return list.Contains(true);
        }
        private bool IfChalanAndGcExist(ref string message)
        {
            ArrayList list = new ArrayList();
            bool gcCheck = false;
            bool chCheck = false;
            if (!txtDpGcnumber.Text.Equals(String.Empty))
            {
                gcCheck = (bool)this.selectDispatchReportTableAdapter.lclGcExists(int.Parse(txtDpGcnumber.Text.Trim()));
            }

            if (gcCheck)
            {
                list.Add(false);
                message += "\n\r* G.C. Number Already There \n\rPlease Choose Another G.C. Number";
            }
            else
            {
                list.Add(true);
            }
            //Checking Chalan number
            if (!txtChalanNumber.Text.Equals(String.Empty))
            {
                chCheck = (bool)this.selectDispatchReportTableAdapter.lclChalanExists(int.Parse(txtChalanNumber.Text.Trim()));
            }

            if (chCheck)
            {
                list.Add(false);
                message += "\n\r*Chalan Number Already There \n\r Please Choose Another Chalan Number \n\r";
            }
            else
            {
                list.Add(true);
            }
            return list.Contains(false);
        }
        #endregion

        #region Initialization of fields Function
        private void InitializeFields()
        {
            //Initializing string fields 
            DpNumber = txtdpPNo.Text.Trim();
            TruckNumber = txtTruckNumber.Text.Trim();
            VatNumber = txtVatNumber.Text.Trim();
            PartyName = txtPartyName.Text.Trim();
            Station = txtStation.Text.Trim();
            Goods = txtGoods.Text.Trim();
            Bags = txtBags.Text.Trim();
            Mt = txtMT.Text.Trim();
            Remarks = txtRemark.Text.Trim();

            //Initializing Integer fields
            ChalanNumber = int.Parse(txtChalanNumber.Text.Trim() == String.Empty ? "0" : txtChalanNumber.Text.Trim());
            GcNumber = int.Parse(txtDpGcnumber.Text.Trim() == String.Empty ? "0" : txtDpGcnumber.Text.Trim());

            //Initializing Decimal fields

            Rate = decimal.Parse(txtRateRMT.Text.Trim() == String.Empty ? "0" : txtRateRMT.Text.Trim());
            Advance = decimal.Parse(txtAdvance.Text.Trim() == string.Empty ? "0" : txtAdvance.Text.Trim());
            Total = decimal.Parse(txtTotal.Text.Trim() == String.Empty ? "0" : txtTotal.Text.Trim());
            Balance = decimal.Parse(txtBalance.Text.Trim() == String.Empty ? "0" : txtBalance.Text.Trim());
            ExpenseProperty = decimal.Parse(txtExpense.Text.Trim() == String.Empty ? "0" : txtExpense.Text.Trim());
            //datetime fields
            EnteredDate = DateTime.Parse(dpDateEdit.Text.Trim() == String.Empty ? DateTime.Now.ToShortDateString() : dpDateEdit.Text.Trim());
        }
        #endregion
 
        /// <summary>
        /// Clears all the fields on Button Clear Click Event
        /// </summary>

        #region Function To clear all the fields

        private void ClearAllField()
        {
            IEnumerator en = tableLayoutPanel1.Controls.GetEnumerator();
            while (en.MoveNext())
            {
                if (en.Current is TextBox)
                {
                    TextBox text = en.Current as TextBox;
                    text.Text = String.Empty;
                }
                if (en.Current is TextEdit)
                {
                    TextEdit edit = en.Current as TextEdit;
                    edit.Text = String.Empty;
                }
                
            }
            dpDateEdit.Text = String.Empty;
            txtdpPNo.Text = String.Empty;
            IEnumerator EnSearch = groupBoxSearch.Controls.GetEnumerator();

            while (EnSearch.MoveNext())
            {
                if (en.Current is TextBox)
                {
                    TextBox text = en.Current as TextBox;
                    text.Text = String.Empty;
                }
                if (en.Current is TextEdit)
                {
                    TextEdit edit = en.Current as TextEdit;
                    edit.Text = String.Empty;
                }
                if (en.Current is DateEdit)
                {
                    DateEdit edit = en.Current as DateEdit;
                    edit.Text = string.Empty;
                }
            }
            txtExpense.Text = string.Empty;
            txtBalance.Text = String.Empty;
            txtTotalAdvance.Text = String.Empty;
            txtRemark.Text = String.Empty;
            txtTotalMT.Text = String.Empty;
        }
        #endregion

        #region Radion Button Events

        private void rdInsert_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInsert.Checked.Equals(true))
            {
                chkBillreceived.Enabled = false;
                btnUpdate.Enabled = false;
                btnEnter.Enabled = true;
                btnDelete.Enabled = false;
                btnClear.Enabled = true;
                txtChalanNumber.Enabled = true;
                txtDpGcnumber.Enabled = true;

            }
        }

        private void rdInsert_Click(object sender, EventArgs e)
        {
            ClearAllField();
        }

        private void rdDpUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDpUpdate.Checked.Equals(true))
            {
                chkBillreceived.Enabled = true;
                btnUpdate.Enabled = true;
                btnEnter.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                txtChalanNumber.Enabled = false;
                txtDpGcnumber.Enabled = false;

            }
        }

        private void rdDpDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDpDelete.Checked.Equals(true))
            {
                chkBillreceived.Enabled = false;
                btnUpdate.Enabled = false;
                btnEnter.Enabled = false;
                btnDelete.Enabled = true;
                btnClear.Enabled = true;
                txtChalanNumber.Enabled = true;
                txtDpGcnumber.Enabled = true;

            }
        }

        #endregion

        #region Search button Click Search Validation
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (IfSearchBoxFieldsEmpty())
            {
                if (!deSearchDateEdit.Text.Equals(String.Empty) & (txtSearchChalan.Text.Equals(String.Empty) & txtSearchGcno.Text.Equals(String.Empty) & txtSearchPartyname.Text.Equals(String.Empty) & txtSearchPNumber.Text.Equals(String.Empty)))
                {
                    this.selectDispatchReportTableAdapter.FillByDisSearchByDate(dispatchDataSet.SelectDispatchReport, DateTime.Parse(deSearchDateEdit.Text.Trim()));
                    dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
                    FillTotalMT();
                }

                if (!txtSearchChalan.Text.Equals(String.Empty) & (deSearchDateEdit.Text.Equals(String.Empty) & txtSearchGcno.Text.Equals(String.Empty) & txtSearchPartyname.Text.Equals(String.Empty) & txtSearchPNumber.Text.Equals(String.Empty)))
                {
                    this.selectDispatchReportTableAdapter.FillByDisSearchByChalanNumber(dispatchDataSet.SelectDispatchReport, int.Parse(txtSearchChalan.Text.Trim()));
                    dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
                    FillTotalMT();
                }

                if (!txtSearchGcno.Text.Equals(String.Empty) & (deSearchDateEdit.Text.Equals(String.Empty) & txtSearchChalan.Text.Equals(String.Empty) & txtSearchPartyname.Text.Equals(String.Empty) & txtSearchPNumber.Text.Equals(String.Empty)))
                {
                    this.selectDispatchReportTableAdapter.FillByDisSearchByGcNumber(dispatchDataSet.SelectDispatchReport, int.Parse(txtSearchGcno.Text.Trim()));
                    dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
                    FillTotalMT();
                }

                if (!txtSearchPartyname.Text.Equals(String.Empty) & (deSearchDateEdit.Text.Equals(String.Empty) & txtSearchChalan.Text.Equals(String.Empty) & txtSearchGcno.Text.Equals(String.Empty) & txtSearchPNumber.Text.Equals(String.Empty)))
                {
                    this.selectDispatchReportTableAdapter.FillByDisSearchByPartyName(dispatchDataSet.SelectDispatchReport, txtSearchPartyname.Text.Trim());
                    dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
                    FillTotalMT();
                }

                if (!txtSearchPNumber.Text.Equals(String.Empty) & (deSearchDateEdit.Text.Equals(String.Empty) & txtSearchChalan.Text.Equals(String.Empty) & txtSearchGcno.Text.Equals(String.Empty) & txtSearchPartyname.Text.Equals(String.Empty)))
                {
                    this.selectDispatchReportTableAdapter.FillByDisSearchByPNumber(dispatchDataSet.SelectDispatchReport, txtSearchPNumber.Text.Trim());
                    dataDispatchGrid.DataSource = dispatchDataSet.SelectDispatchReport;
                    FillTotalMT();
                }


            }
            else
            {
                MessageBox.Show("Enter Only One Field for Proper search \n In Search Group Box", "Search Error");
            }

        }

        private bool IfSearchBoxFieldsEmpty()
        {
            int track = 0;
            ArrayList list = new ArrayList();
            IEnumerator en = groupBoxSearch.Controls.GetEnumerator();
            while (en.MoveNext())
            {
                if (en.Current is TextBox)
                {
                    TextBox text = en.Current as TextBox;
                    if (text.Text.Equals(String.Empty))
                    {
                        list.Add(true);
                        track++;
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
                if (en.Current is DateEdit)
                {
                    DateEdit edit = en.Current as DateEdit;
                    if (edit.Text.Equals(String.Empty))
                    {
                        list.Add(true);
                        track++;
                    }
                    else
                    {
                        list.Add(false);
                    }
                }
            }
            if (track == 4)
            {
                return true;
            }
            else
            {
                return false;
            }

            //return true;
        }
        #endregion

        #region Automatic Total Fill on Text Leave Event
        private void txtTotal_Leave(object sender, EventArgs e)
            {
                if (!txtAdvance.Text.Equals(String.Empty) & !ValidationClass.IsTextEditEmpty(txtMT) & !ValidationClass.IsTextEditZero(txtMT))
            {
                decimal mt = decimal.Parse(txtMT.Text.Trim());
                decimal rate = decimal.Parse(txtRateRMT.Text.Trim());
                txtTotal.Text = Convert.ToString(mt * rate);

                decimal advance = decimal.Parse(txtAdvance.Text.Trim());
                decimal total = decimal.Parse(txtTotal.Text.Trim());
                txtBalance.Text = Convert.ToString(total - advance);
            }
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           //this.Load +=new EventHandler(Dispatch_report_Load);
            this.selectDispatchReportTableAdapter.Fill(this.dispatchDataSet.SelectDispatchReport);
            ClearAllField();
        }

        #region Automatic Fill Total Field using RateRMT Leave Event
        private void txtRateRMT_Leave(object sender, EventArgs e)
        {
            if (!ValidationClass.IsTextEditEmpty(txtMT) & !ValidationClass.IsTextEditZero(txtMT))
            {

                decimal mt = decimal.Parse(txtMT.Text.Trim());
                decimal rate = decimal.Parse(txtRateRMT.Text.Trim());
                txtTotal.Text = Convert.ToString(mt * rate);
            }
            else
            {
                MessageBox.Show("Please Enter The M.T Field First for Proper Calculation");
            }
        }
        #endregion
        
        private void txtExpense_Leave(object sender, EventArgs e)
        {
            if (!ValidationClass.IsTextEditEmpty(txtBalance) & !ValidationClass.IsTextEditZero(txtBalance) & !txtAdvance.Text.Equals(String.Empty) & !ValidationClass.IsTextEditEmpty(txtMT))
            {
                decimal mt = decimal.Parse(txtMT.Text.Trim());
                decimal rate = decimal.Parse(txtRateRMT.Text.Trim());
                txtTotal.Text = Convert.ToString(mt * rate);

                decimal advance = decimal.Parse(txtAdvance.Text.Trim());
                decimal total = decimal.Parse(txtTotal.Text.Trim());
                txtBalance.Text = Convert.ToString(total - advance);


                decimal balance = decimal.Parse(txtBalance.Text.Trim());
                decimal expense = decimal.Parse(txtExpense.Text.Trim());
                txtBalance.Text = Convert.ToString(balance - expense);
            }
        }

        private void selectDispatchReportBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void FillTotalMT()
        {
            decimal total = 0;
            for (int i = 0; i < dataDispatchGrid.Rows.Count; i++)
            {
                total += decimal.Parse(dataDispatchGrid["mTDataGridViewTextBoxColumn", i].Value.ToString());
            }
            txtTotalMT.Text = Convert.ToString(total);
        }

        private void chkBillreceived_Click(object sender, EventArgs e)
        {
            if (chkBillreceived.Checked.Equals(true))
            {
                int i = this.selectDispatchReportTableAdapter.FillByDispatchBillReceived(this.dispatchDataSet.SelectDispatchReport, BillId, true);
                if (i != 0)
                {
                    MessageBox.Show("Bill Received for Bill Id " + BillId);
                }
            }
            else
            {
                int i = this.selectDispatchReportTableAdapter.FillByDispatchBillReceived(this.dispatchDataSet.SelectDispatchReport, BillId, false);
                if (i != 0)
                {
                    MessageBox.Show("Bill Received Cancelled for Bill Id " + BillId);
                }
            }
        }
    }
}