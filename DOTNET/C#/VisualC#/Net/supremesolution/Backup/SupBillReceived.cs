using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SupremeTransport
{
    public partial class SupBillReceived : Form
    {
        public SupBillReceived()
        {
            InitializeComponent();
            dtPaymentDate.Text = DateTime.Now.ToShortDateString();
        }

        int debitBillNumber, chequeNumber;
        bool paymentRecieved;
        DateTime chequeDate, paymentDate;
        decimal tds_amount, otherExpense, totalrcvamount;
        static decimal totalAmount;

        public static decimal TotalAmount
        {
            get { return SupBillReceived.totalAmount; }
            set { SupBillReceived.totalAmount = value; }
        }

        public decimal Tds_amount
        {
            get { return tds_amount; }
            set { tds_amount = value; }
        }

        public decimal OtherExpense
        {
            get { return otherExpense; }
            set { otherExpense = value; }
        }

        public decimal Totalrcvamount
        {
            get { return totalrcvamount; }
            set { totalrcvamount = value; }
        }

        public DateTime ChequeDate
        {
            get { return chequeDate; }
            set { chequeDate = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        
        public bool PaymentRecieved
        {
            get { return paymentRecieved; }
            set { paymentRecieved = value; }
        }
        
        public int DebitBillNumber
        {
            get { return debitBillNumber; }
            set { debitBillNumber = value; }
        }

        public int ChequeNumber
        {
            get { return chequeNumber; }
            set { chequeNumber = value; }
        }

        private void SupBillReceived_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maindataset.mainbill' table. You can move, or remove it, as needed.
            this.mainbillTableAdapter.Fill(this.maindataset.mainbill);
            DataTable table = this.maindataset.Tables["mainbill"];
            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (CheckIfFieldsEmpty(ref message))
            {
                InitializeAllFields();
                int i = this.mainbillTableAdapter.FillByPaymentRecievedDetails(maindataset.mainbill, DebitBillNumber, ChequeNumber, ChequeDate, PaymentDate, PaymentRecieved, Tds_amount, OtherExpense, Totalrcvamount);
                if (i != 0)
                {
                    MessageBox.Show("Payment Received for the Debit Bill Number " + DebitBillNumber.ToString());
                    ClearAllTheFields();
                }
                else
                {
                    MessageBox.Show("Payment could not be updated");
                }
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeAllFields()
        {
            DebitBillNumber = int.Parse(comboDebitBillNumber.Text.Trim());
            ChequeNumber = int.Parse(txtChequeNumber.Text.Trim() == String.Empty ? "0" : txtChequeNumber.Text.Trim());
            PaymentRecieved = comPaymentRecieved.Text.Trim().ToUpper() == "YES" ? true : false;
            PaymentDate = DateTime.Parse(dtPaymentDate.Text.Trim() == String.Empty ? new DateTime(1999, 1, 1).ToShortDateString() : DateTime.Parse(dtPaymentDate.Text.Trim()).ToShortDateString());
            ChequeDate = DateTime.Parse(dtChequeDate.Text.Trim() == String.Empty ? new DateTime(1999, 1, 1).ToShortDateString() : DateTime.Parse(dtChequeDate.Text.Trim()).ToShortDateString());
            Tds_amount = decimal.Parse(txtTDSAmount.Text);
            OtherExpense = decimal.Parse(txtOtherExpense.Text);
            Totalrcvamount = decimal.Parse(txtAmountReceived.Text);


        }

        private bool CheckIfFieldsEmpty(ref string message)
        {
            ArrayList list = new ArrayList();
            bool retVal = true;

            if (ValidationClass.IsTextEditEmpty(txtChequeNumber))
            {
                message += "Cheque Number Cannot be Empty \n\r";
                list.Add(true);
            }
            else if (txtChequeNumber.Text == "0")
            {
                message += "Cheque Number Cannot be 0 \n\r";
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsDateEditEmpty(dtChequeDate))
            {
                message += "Cheque Date Cannot be Empty \n\r";
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsDateEditEmpty(dtPaymentDate))
            {
                message += "Payment Date Cannot be Empty \n\r";
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsComboEditSelectedIndexZero(comboDebitBillNumber))
            {
                message += "Please Select Debit Bill Number \r\n";
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsComboEditSelectedIndexZero(comPaymentRecieved))
            {
                message += "Please Select Payment Received Option \n\r";
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsTextEditEmpty(txtTDSAmount))
            {
                message += "TDS Amount cannot be Empyt";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsTextEditEmpty(txtOtherExpense))
            {
                message += "Other Expense Amount cannot be Empty";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsTextEditEmpty(txtAmountReceived))
            {
                message += "Total Amount Received Cannot be Empty";
            }
            else
            {
                list.Add(false);
            }
            IEnumerator ie = list.GetEnumerator();
            while (ie.MoveNext())
            {
                if ((bool)ie.Current == true)
                {
                    retVal = false;
                }
            }
            return retVal;
        }

        private bool CheckIfFieldsEmptyForUpdate(ref string message)
        {
            ArrayList list = new ArrayList();
            bool retVal = true;
            if (ValidationClass.IsComboEditSelectedIndexZero(comPaymentRecieved))
            {
                message += "Please Select Payment Received Option \n\r";
                list.Add(true);
            }
            else
            {
                list.Add(false);
            }
            IEnumerator ie = list.GetEnumerator();
            while (ie.MoveNext())
            {
                if ((bool)ie.Current == true)
                {
                    retVal = false;
                }
            }
            return retVal;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.mainbillTableAdapter.FillBySelectAll(this.maindataset.mainbill);
            this.mainbillBindingSource.DataSource = this.maindataset;
            FillComDebitbillIdsIsTrue();
        }

        private void FillComDebitBillIdIsFalse()
        {
            this.mainbillTableAdapter.Fill(this.maindataset.mainbill);
            DataTable table = this.maindataset.Tables["mainbill"];
            DataTableReader read = new DataTableReader(table);
            comboDebitBillNumber.Properties.Items.Clear();
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
            }
        }

        private void FillComDebitbillIdsIsTrue()
        {
            comboDebitBillNumber.Properties.Items.Clear();

            this.mainbillTableAdapter.FillBySelectAll(this.maindataset.mainbill);
            DataTable table = this.maindataset.Tables["mainbill"];
            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
            }
        }

        private void WhenBillUnPaidIsChecked()
        {
            comboDebitBillNumber.Properties.Items.Clear();

            this.mainbillTableAdapter.Fill(this.maindataset.mainbill);
            DataTable table = this.maindataset.Tables["mainbill"];
            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
            }
        }

        private void WhenBillPaidIsChecked()
        {
            comboDebitBillNumber.Properties.Items.Clear();

            this.mainbillTableAdapter.FillBySelectAllPaid(this.maindataset.mainbill);
            DataTable table = this.maindataset.Tables["mainbill"];
            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTheFields();
        }

        private void ClearAllTheFields()
        {
            txtChequeNumber.Text = String.Empty;
            dtChequeDate.Text = String.Empty;
            //dtPaymentDate.Text = String.Empty;
            comPaymentRecieved.SelectedIndex = -1;
            comboDebitBillNumber.SelectedIndex = -1;
            txtTDSAmount.Text = "0";
            txtOtherExpense.Text = "0";
            txtAmountReceived.Text = "0";

        }

        #region Button  Click events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (CheckIfFieldsEmptyForUpdate(ref message))
            {
                InitializeAllFields();
                int i = this.mainbillTableAdapter.FillByPaymentRecievedDetails(maindataset.mainbill, DebitBillNumber, ChequeNumber, ChequeDate, PaymentDate, PaymentRecieved, Tds_amount, OtherExpense, Totalrcvamount);
                if (i != 0)
                {
                    MessageBox.Show("Payment Received for the Debit Bill Number " + DebitBillNumber.ToString());
                    ClearAllTheFields();
                }
                else
                {
                    MessageBox.Show("Payment could not be updated");
                }
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!comboDebitBillNumber.SelectedItem.Equals(String.Empty))
            {
                this.mainbillTableAdapter.FillByBillSearchById(this.maindataset.mainbill, int.Parse(comboDebitBillNumber.SelectedItem.ToString()));
            }
        }
        
        #endregion

        private void comboDebitBillNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTotalAmountField();

        }

        private void FillTotalAmountField()
        {
            if (checkIfUpdate.Checked.Equals(true))
            {
                this.mainbillTableAdapter.FillBySelectAll(this.maindataset.mainbill);
                this.mainbillBindingSource.DataSource = this.maindataset;
                FillComDebitbillIdsIsTrue();
            
            }
            else if (checkPaidBills.Checked.Equals(true))
            {
                WhenBillPaidIsChecked();
            }
            else if (checkUnPaidBills.Checked.Equals(true))
            {
                WhenBillUnPaidIsChecked();
            }
            else
            {
                WhenBillUnPaidIsChecked();
            }
            DataTable table = maindataset.Tables[0];

            if (comboDebitBillNumber.SelectedIndex != -1)
            {
                DataRow[] ArrRow = table.Select("debitbillno = " + comboDebitBillNumber.SelectedItem);
                if (ArrRow.Length > 0)
                {
                    DataRow row = ArrRow[0];
                    txtAmountReceived.Text = row["total"].ToString();
                    TotalAmount = decimal.Parse(txtAmountReceived.Text);
                }
            }
            else
            {
                txtAmountReceived.Text = "0.00";
            }
        }

        private void txtTDSAmount_Leave(object sender, EventArgs e)
        {
            FillTotalAmountWhenTdsLeaves();
        }

        private void FillTotalAmountWhenTdsLeaves()
        {
            FillTotalAmountField();
            if (txtAmountReceived.Text != String.Empty && txtAmountReceived.Text != "0.00" && txtAmountReceived.Text != "0")
            {
                decimal tdsAmount = decimal.Parse(txtTDSAmount.Text);
                if (TotalAmount != 0)
                {
                    txtAmountReceived.Text = Convert.ToString(TotalAmount - tdsAmount);
                    TotalAmount = decimal.Parse(txtAmountReceived.Text);
                }
            }
        }

        private void txtOtherExpense_Leave(object sender, EventArgs e)
        {
            FillTotalAmountWhenTdsLeaves();
            if (txtAmountReceived.Text != String.Empty && txtAmountReceived.Text != "0.00" && txtAmountReceived.Text != "0")
            {
                decimal otherExpense = decimal.Parse(txtOtherExpense.Text);
                if (TotalAmount != 0)
                {
                    txtAmountReceived.Text = Convert.ToString(TotalAmount - otherExpense);
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboDebitBillNumber.SelectedItem = dataGridView1.CurrentRow.Cells["debitBillNoDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void comboDebitBillNumber_Leave(object sender, EventArgs e)
        {
            FillTotalAmountField();

        }

        #region Radio button Click events

        private void checkIfUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIfUpdate.Checked == true)
            {
                btnEnter.Enabled = false;
                btnUpdate.Enabled = true;
                FillComDebitbillIdsIsTrue();
            }
            else
            {
                btnEnter.Enabled = true;
                btnUpdate.Enabled = false;
                FillComDebitBillIdIsFalse();
            }
        }

        private void checkPaidBills_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPaidBills.Checked == true)
            {
                this.mainbillTableAdapter.FillBySelectAllPaid(this.maindataset.mainbill);
                DataTable table = this.maindataset.Tables["mainbill"];
                DataTableReader read = new DataTableReader(table);
                dataGridView1.DataSource = this.maindataset.Tables["mainbill"];
                while (read.Read())
                {
                    comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
                }

            }
            else
            {
                this.mainbillTableAdapter.Fill(this.maindataset.mainbill);
                DataTable table = this.maindataset.Tables["mainbill"];
                DataTableReader read = new DataTableReader(table);
                while (read.Read())
                {
                    comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
                }

            }
        }

        private void checkUnPaidBills_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUnPaidBills.Checked == true)
            {

                this.mainbillTableAdapter.Fill(this.maindataset.mainbill);
                DataTable table = this.maindataset.Tables["mainbill"];
                DataTableReader read = new DataTableReader(table);
                while (read.Read())
                {
                    comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
                }
            }
        }

        #endregion


    }
}