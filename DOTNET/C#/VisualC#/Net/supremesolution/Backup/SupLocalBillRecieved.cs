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
    public partial class SupLocalBillRecieved : Form
    {
        int billNumber, chequeNumber;


        bool paymentRecieved;
        DateTime chequeDate, paymentDate;

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
        public int BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }

        public int ChequeNumber
        {
            get { return chequeNumber; }
            set { chequeNumber = value; }
        }
        public SupLocalBillRecieved()
        {
            InitializeComponent();
            dtPaymentDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.selectlocalbillTableAdapter.FillBylclSelectall(this.lclsupset.selectlocalbill);

        }

        private void SupLocalBillRecieved_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lclsupset.selectlocalbill' table. You can move, or remove it, as needed.
            this.selectlocalbillTableAdapter.Fill(this.lclsupset.selectlocalbill);
            DataTable table = this.lclsupset.Tables["selectlocalbill"];
            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(1).ToString());
            }

        }

        private void FillComDebitBillIdIsFalse()
        {
            this.selectlocalbillTableAdapter.Fill(this.lclsupset.selectlocalbill);
            DataTable table = this.lclsupset.Tables["selectlocalbill"];
            DataTableReader read = new DataTableReader(table);
            comboDebitBillNumber.Properties.Items.Clear();
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(1).ToString());
            }
        }

        private void FillComDebitbillIdsIsTrue()
        {
            comboDebitBillNumber.Properties.Items.Clear();

            this.selectlocalbillTableAdapter.Fill(this.lclsupset.selectlocalbill);
            DataTable table = this.lclsupset.Tables["selectlocalbill"];

            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(1).ToString());
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (CheckIfFieldsEmpty(ref message))
            {
                InitializeAllFields();
                int i = this.selectlocalbillTableAdapter.FillBylclPaymentRecieved(lclsupset.selectlocalbill, BillNumber, ChequeNumber, PaymentDate, ChequeDate, PaymentRecieved); 
                if (i != 0)
                {
                    MessageBox.Show("Payment Received for the Debit Bill Number " + BillNumber.ToString());
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
            BillNumber = int.Parse(comboDebitBillNumber.Text.Trim());
            ChequeNumber = int.Parse(txtChequeNumber.Text.Trim());
            PaymentRecieved = comPaymentRecieved.Text.Trim().ToUpper() == "YES" ? true : false;
            PaymentDate = DateTime.Parse(dtPaymentDate.Text.Trim());
            ChequeDate = DateTime.Parse(dtChequeDate.Text.Trim());
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (CheckIfFieldsEmpty(ref message))
            {
                InitializeAllFields();
                int i = this.selectlocalbillTableAdapter.FillBylclPaymentRecieved(lclsupset.selectlocalbill, BillNumber, ChequeNumber, PaymentDate, ChequeDate, PaymentRecieved);
                if (i != 0)
                {
                    MessageBox.Show("Payment Received for the Debit Bill Number " + BillNumber.ToString());
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
    }
}