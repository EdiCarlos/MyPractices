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
    public partial class ZahBillRecieved : Form
    {
        int debitBillNumber, chequeNumber;
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
        public ZahBillRecieved()
        {
            InitializeComponent();
            dtPaymentDate.Text = DateTime.Now.ToShortDateString();
        
        }

        private void ZahBillRecieved_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zmaindataset.zmainbill' table. You can move, or remove it, as needed.
            this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            // TODO: This line of code loads data into the 'zmaindataset.zmainbill' table. You can move, or remove it, as needed.
            this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            DataTable table = this.zmaindataset.Tables["zmainbill"];
            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(3).ToString());
            }
        }
        private void InitializeAllFields()
        {
            DebitBillNumber = int.Parse(comboDebitBillNumber.Text.Trim());
            ChequeNumber = int.Parse(txtChequeNumber.Text.Trim());
            PaymentRecieved = comPaymentRecieved.Text.Trim().ToUpper() == "YES" ? true : false;
            PaymentDate = DateTime.Parse(dtPaymentDate.Text.Trim());
            ChequeDate = DateTime.Parse(dtChequeDate.Text.Trim());
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (CheckIfFieldsEmpty(ref message))
            {
                InitializeAllFields();
                int i = 0;
                //int i = this.zmainbillTableAdapter.FillByPaymentRecieved(zmaindataset.zmainbill, DebitBillNumber, ChequeNumber, ChequeDate, PaymentDate, PaymentRecieved);
                if (i != 0)
                {
                    MessageBox.Show("Payment Received for the Debit Bill Number " + DebitBillNumber.ToString());
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
        private void FillComDebitBillIdIsFalse()
        {
            this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            DataTable table = this.zmaindataset.Tables["zmainbill"];
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

            this.zmainbillTableAdapter.FillBySelectAll(this.zmaindataset.zmainbill);
            DataTable table = this.zmaindataset.Tables["zmainbill"];
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
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.zmainbillTableAdapter.FillBySelectAll(this.zmaindataset.zmainbill);
            this.zmainbillBindingSource.DataSource = this.zmaindataset;
            FillComDebitbillIdsIsTrue();
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

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (CheckIfFieldsEmpty(ref message))
            {
                InitializeAllFields();
                //int i = this.zmainbillTableAdapter.FillByPaymentRecieved(zmaindataset.zmainbill, DebitBillNumber, ChequeNumber, ChequeDate, PaymentDate, PaymentRecieved);
                int i = 0;
                if (i != 0)
                {
                    MessageBox.Show("Payment Received for the Debit Bill Number " + DebitBillNumber.ToString());
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

    }
}