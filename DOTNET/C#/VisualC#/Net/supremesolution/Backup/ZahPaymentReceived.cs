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
    public partial class ZahPaymentReceived : Form
    {
        #region Fields
        int mnbillid;
        string[] chequeNumber = new string[10];
        DateTime[] chequedate = new DateTime[10];
        decimal[] chequeAmount = new decimal[10];
        decimal[] tds = new decimal[10];
        decimal[] otherExpense = new decimal[10];
        decimal[] total = new decimal[10];
        #endregion

        #region Properties
        public int Mnbillid
        {
            get { return mnbillid; }
            set { mnbillid = value; }
        }

        #endregion

        #region Form Construct
        public ZahPaymentReceived()
        {
            InitializeComponent();
        }
        #endregion

        #region From Load
        private void ZahPaymentReceived_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zmaindataset.billRcv' table. You can move, or remove it, as needed.
            this.billRcvTableAdapter.FillByBillNotRcv(this.zmaindataset.billRcv);
            FillDebitBillComboBox();
            // TODO: This line of code loads data into the 'zmaindataset.zmainbill' table. You can move, or remove it, as needed.

        }
        #endregion

        #region DataGrid View Events

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //start
            // these lines of code fills datagridview from the zmaindataset
            this.billrcvPaymentDetTableAdapter.ClearBeforeFill = true;
            //Initialized MnBillid property
            Mnbillid = int.Parse(dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString());
            this.billrcvPaymentDetTableAdapter.Fill(this.zmaindataset.billrcvPaymentDet, Mnbillid);
            dataGridView2.DataSource = this.zmaindataset.billrcvPaymentDet;
            txtTotalBillAmount.Text = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
            txtBalance.Text = dataGridView1.CurrentRow.Cells["BalanceAmount"].Value.ToString();


            //end

            FillTextBoxes();
            FillTotalRow();
            comboDebitBillNumber.SelectedItem = dataGridView1.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
            EnableDisableCheckBoxes();
        }

        private void EnableDisableCheckBoxes()
        {
            switch (this.zmaindataset.billrcvPaymentDet.Count)
            {
                case 2:
                    checkRow1.Checked = true;
                    break;
                case 3:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    break;
                case 4:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    checkRow3.Checked = true;
                    break;
                case 5:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    checkRow3.Checked = true;
                    checkRow4.Checked = true;
                    break;
                case 6:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    checkRow3.Checked = true;
                    checkRow4.Checked = true;
                    checkRow5.Checked = true;
                    break;

                case 7:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    checkRow3.Checked = true;
                    checkRow4.Checked = true;
                    checkRow5.Checked = true;
                    checkRow6.Checked = true;
                    break;
                case 8:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    checkRow3.Checked = true;
                    checkRow4.Checked = true;
                    checkRow5.Checked = true;
                    checkRow6.Checked = true;
                    checkRow7.Checked = true;
                    break;
                case 9:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    checkRow3.Checked = true;
                    checkRow4.Checked = true;
                    checkRow5.Checked = true;
                    checkRow6.Checked = true;
                    checkRow7.Checked = true;
                    checkRow8.Checked = true;
                    break;
                case 10:
                    checkRow1.Checked = true;
                    checkRow2.Checked = true;
                    checkRow3.Checked = true;
                    checkRow4.Checked = true;
                    checkRow5.Checked = true;
                    checkRow6.Checked = true;
                    checkRow7.Checked = true;
                    checkRow8.Checked = true;
                    checkRow9.Checked = true;
                    break;

                default:
                    checkRow1.Checked = false;
                    checkRow2.Checked = false;
                    checkRow3.Checked = false;
                    checkRow4.Checked = false;
                    checkRow5.Checked = false;
                    checkRow6.Checked = false;
                    checkRow7.Checked = false;
                    checkRow8.Checked = false;
                    checkRow9.Checked = false;
                    break;
            }
        }

        private void FillTotalRow()
        {
            CalculateChequeAmountTotal();
            CalculatTdsTotalAmount();
            CalculateOtherExpenseTotal();
            CalculateTotalPartPayment();
        }

        #region That fills the text on DataGrid click Event
        #region Fill Total Textbox field
        private void CalculateTotalPartPayment()
        {
            decimal total = decimal.Parse(txtTotalCol5Row0.Text);
            total += decimal.Parse(txtTotalCol5Row1.Text);
            total += decimal.Parse(txtTotalCol5Row2.Text);
            total += decimal.Parse(txtTotalCol5Row3.Text);
            total += decimal.Parse(txtTotalCol5Row4.Text);
            total += decimal.Parse(txtTotalCol5Row5.Text);
            total += decimal.Parse(txtTotalCol5Row6.Text);
            total += decimal.Parse(txtTotalCol5Row7.Text);
            total += decimal.Parse(txtTotalCol5Row8.Text);
            total += decimal.Parse(txtTotalCol5Row9.Text);
            txtTotalPartPayment.Text = total.ToString();
        }

        private void CalculateOtherExpenseTotal()
        {
            decimal otherExp = decimal.Parse(txtOtherExpCol4Row0.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row1.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row2.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row3.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row4.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row5.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row6.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row7.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row8.Text);
            otherExp += decimal.Parse(txtOtherExpCol4Row9.Text);
            txtOtherExpense.Text = otherExp.ToString();
        }

        private void CalculatTdsTotalAmount()
        {
            decimal tds = decimal.Parse(tdsCol3Row0.Text);
            tds += decimal.Parse(tdsCol3Row1.Text);
            tds += decimal.Parse(tdsCol3Row2.Text);
            tds += decimal.Parse(tdsCol3Row3.Text);
            tds += decimal.Parse(tdsCol3Row4.Text);
            tds += decimal.Parse(tdsCol3Row5.Text);
            tds += decimal.Parse(tdsCol3Row6.Text);
            tds += decimal.Parse(tdsCol3Row7.Text);
            tds += decimal.Parse(tdsCol3Row8.Text);
            tds += decimal.Parse(tdsCol3Row9.Text);
            txtTdsTotal.Text = tds.ToString();
        }

        private void CalculateChequeAmountTotal()
        {
            decimal checkAmount = decimal.Parse(txtChequeAmtCol2Row0.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row1.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row2.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row3.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row4.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row5.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row6.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row7.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row8.Text);
            checkAmount += decimal.Parse(txtChequeAmtCol2Row9.Text);
            txtTotalChequeAmount.Text = checkAmount.ToString();
        }
        #endregion

        private void FillTextBoxes()
        {
            if (this.zmaindataset.billrcvPaymentDet.Count == 0)
            {
                ClearAllFunction();
            }
            for (int i = 0; i < this.zmaindataset.billrcvPaymentDet.Count; i++)
            {
                if (i == 0)
                {
                    FillFieldsRow1(i);
                }
                if (i == 1)
                {
                    FillFieldsRow2(i);

                }

                if (i == 2)
                {
                    FillFieldsRow3(i);

                }

                if (i == 3)
                {
                    FillFieldsRow4(i);

                }

                if (i == 4)
                {
                    FillFieldsRow5(i);

                }

                if (i == 5)
                {
                    FillFieldsRow6(i);

                }

                if (i == 6)
                {
                    FillFieldsRow7(i);

                }

                if (i == 7)
                {
                    FillFieldsRow8(i);

                }

                if (i == 8)
                {
                    FillFieldsRow9(i);
                }

                if (i == 10)
                {
                    FillFieldsRow10(i);
                }

            }

            if (this.zmaindataset.billrcvPaymentDet.Count.Equals(0))
            {
                checkRow1.Checked = false;
                checkRow2.Checked = false;
                checkRow3.Checked = false;
                checkRow4.Checked = false;
                checkRow5.Checked = false;
                checkRow6.Checked = false;
                checkRow7.Checked = false;
                checkRow8.Checked = false;
                checkRow9.Checked = false;
            }
        }

        private void FillFieldsRow1(int j)
        {
            txtChequeNumberCol0Row0.Text = dataGridView2.Rows[j].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row0.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row0.Text = dataGridView2.Rows[j].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row0.Text = dataGridView2.Rows[j].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row0.Text = dataGridView2.Rows[j].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row0.Text = dataGridView2.Rows[j].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        private void FillFieldsRow2(int i)
        {
            txtChequeNumberCol0Row1.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row1.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row1.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row1.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row1.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row1.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();

        }


        private void FillFieldsRow3(int i)
        {
            txtChequeNumberCol0Row2.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row2.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row2.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row2.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row2.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row2.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        private void FillFieldsRow4(int i)
        {
            txtChequeNumberCol0Row3.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row3.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row3.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row3.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row3.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row3.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        private void FillFieldsRow5(int i)
        {
            txtChequeNumberCol0Row4.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row4.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row4.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row4.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row4.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row4.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        private void FillFieldsRow6(int i)
        {

            txtChequeNumberCol0Row5.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row5.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row5.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row5.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row5.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row5.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();


        }

        private void FillFieldsRow7(int i)
        {

            txtChequeNumberCol0Row6.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row6.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row6.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row6.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row6.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row6.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        private void FillFieldsRow8(int i)
        {
            txtChequeNumberCol0Row7.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row7.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row1.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row7.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row7.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row7.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        private void FillFieldsRow9(int i)
        {
            txtChequeNumberCol0Row8.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row8.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row8.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row8.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row8.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row8.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        private void FillFieldsRow10(int i)
        {
            txtChequeNumberCol0Row9.Text = dataGridView2.Rows[i].Cells["chequeNumberDataGridViewTextBoxColumn1"].Value.ToString();
            dtChequeDateCol1Row9.Text = DateTime.Parse(dataGridView2.Rows[i].Cells["chequedatedataGridViewTextBoxColumn14"].Value.ToString()).ToShortDateString();
            txtChequeAmtCol2Row9.Text = dataGridView2.Rows[i].Cells["chequeAmountDataGridViewTextBoxColumn"].Value.ToString();
            tdsCol3Row9.Text = dataGridView2.Rows[i].Cells["tDSDataGridViewTextBoxColumn"].Value.ToString();
            txtOtherExpCol4Row9.Text = dataGridView2.Rows[i].Cells["otherExpenseDataGridViewTextBoxColumn1"].Value.ToString();
            txtTotalCol5Row9.Text = dataGridView2.Rows[i].Cells["totaldataGridViewTextBoxColumn15"].Value.ToString();
        }

        #endregion

        #endregion

        #region Radio Button

        private void checkUnPaidBills_CheckedChanged(object sender, EventArgs e)
        {
            comboDebitBillNumber.SelectedIndex = -1;
            if (checkUnPaidBills.Checked == true)
            {
                this.billRcvTableAdapter.FillByBillNotRcv(this.zmaindataset.billRcv);
                FillDebitBillComboBox();
                dataGridView1.DataSource = this.zmaindataset.billRcv;
                ClearAllFunction();

            }

        }
        private void checkPaidBills_CheckedChanged(object sender, EventArgs e)
        {
            comboDebitBillNumber.SelectedIndex = -1;
            if (checkPaidBills.Checked == true)
            {
                this.billRcvTableAdapter.FillByBillRcv(this.zmaindataset.billRcv);
                FillDebitBillComboBox();
                dataGridView1.DataSource = this.zmaindataset.billRcv;
                ClearAllFunction();

            }
            if (checkPaidBills.Checked == true)
            {
                btnEnter.Enabled = false;
                btnUpdate.Enabled = false;
                btnPartPayment.Enabled = false;
            }
            else
            {
                btnEnter.Enabled = true;
                btnUpdate.Enabled = true;
                btnPartPayment.Enabled = true;
            }
        }
        private void checkIfUpdate_CheckedChanged(object sender, EventArgs e)
        {
            comboDebitBillNumber.SelectedIndex = -1;
            if (checkIfUpdate.Checked == true)
            {
                this.billRcvTableAdapter.FillByBillRcvAll(this.zmaindataset.billRcv);
                FillDebitBillComboBox();
                dataGridView1.DataSource = this.zmaindataset.billRcv;
                ClearAllFunction();

            }

            if (checkIfUpdate.Checked == true)
            {
                btnEnter.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        #endregion

        #region Fill ComboBox
        public void FillDebitBillComboBox()
        {
            comboDebitBillNumber.Properties.Items.Clear();
            DataTable table = this.zmaindataset.Tables["billRcv"];
            DataTableReader read = new DataTableReader(table);
            while (read.Read())
            {
                comboDebitBillNumber.Properties.Items.Add(read.GetInt32(2).ToString());
            }
        }
        #endregion

        #region Radio Button Full Payment and Part Payment
        private void rdPartpayment_CheckedChanged(object sender, EventArgs e)
        {
            //comboDebitBillNumber.SelectedIndex = -1;
            if (rdPartpayment.Checked == true)
            {
                btnEnter.Enabled = false;
                if (btnUpdate.Enabled == true)
                {
                    btnUpdate.Enabled = true;
                }
                btnPartPayment.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = true;
                if (btnUpdate.Enabled == false)
                {
                    btnUpdate.Enabled = false;
                }
                btnPartPayment.Enabled = false;
            }
        }
        private void rdFullPayment_CheckedChanged(object sender, EventArgs e)
        {
            //comboDebitBillNumber.SelectedIndex = -1;
        }
        #endregion

        #region Function That Clear's all the fields

        private void Clear_Text_OtherExpense()
        {
            txtOtherExpCol4Row0.Text = "0.00";
            txtOtherExpCol4Row1.Text = "0.00";
            txtOtherExpCol4Row2.Text = "0.00";
            txtOtherExpCol4Row3.Text = "0.00";
            txtOtherExpCol4Row4.Text = "0.00";
            txtOtherExpCol4Row5.Text = "0.00";
            txtOtherExpCol4Row6.Text = "0.00";
            txtOtherExpCol4Row7.Text = "0.00";
            txtOtherExpCol4Row9.Text = "0.00";
            txtOtherExpCol4Row8.Text = "0.00";
            txtOtherExpense.Text = "0.00";
        }

        private void Clear_Text_Tds()
        {
            tdsCol3Row0.Text = "0.00";
            tdsCol3Row1.Text = "0.00";
            tdsCol3Row2.Text = "0.00";
            tdsCol3Row3.Text = "0.00";
            tdsCol3Row4.Text = "0.00";
            tdsCol3Row5.Text = "0.00";
            tdsCol3Row6.Text = "0.00";
            tdsCol3Row7.Text = "0.00";
            tdsCol3Row8.Text = "0.00";
            tdsCol3Row9.Text = "0.00";
            txtTdsTotal.Text = "0.00";
        }

        private void Clear_Text_Total_Payment()
        {
            txtTotalCol5Row0.Text = "0.00";
            txtTotalCol5Row1.Text = "0.00";
            txtTotalCol5Row2.Text = "0.00";
            txtTotalCol5Row3.Text = "0.00";
            txtTotalCol5Row4.Text = "0.00";
            txtTotalCol5Row5.Text = "0.00";
            txtTotalCol5Row6.Text = "0.00";
            txtTotalCol5Row7.Text = "0.00";
            txtTotalCol5Row8.Text = "0.00";
            txtTotalCol5Row9.Text = "0.00";
            txtTotalPartPayment.Text = "0.00";
        }
        private void Clear_Cheque_Amount()
        {
            txtChequeAmtCol2Row0.Text = "0";
            txtChequeAmtCol2Row1.Text = "0";
            txtChequeAmtCol2Row2.Text = "0";
            txtChequeAmtCol2Row3.Text = "0";
            txtChequeAmtCol2Row4.Text = "0";
            txtChequeAmtCol2Row5.Text = "0";
            txtChequeAmtCol2Row6.Text = "0";
            txtChequeAmtCol2Row7.Text = "0";
            txtChequeAmtCol2Row8.Text = "0";
            txtChequeAmtCol2Row9.Text = "0";
            txtTotalChequeAmount.Text = "0";

        }

        private void Clear_OutSide_Fields()
        {
            comboDebitBillNumber.SelectedIndex = -1;
            txtTotalBillAmount.Text = String.Empty;
            txtBalance.Text = String.Empty;
            comPaymentRecieved.SelectedIndex = -1;
            dtPaymentDate.Text = DateTime.Now.ToShortDateString();
        }

        private void Clear_Cheque_Number()
        {
            txtChequeNumberCol0Row0.Text = "0";
            txtChequeNumberCol0Row1.Text = "0";
            txtChequeNumberCol0Row2.Text = "0";
            txtChequeNumberCol0Row3.Text = "0";
            txtChequeNumberCol0Row4.Text = "0";
            txtChequeNumberCol0Row5.Text = "0";
            txtChequeNumberCol0Row6.Text = "0";
            txtChequeNumberCol0Row7.Text = "0";
            txtChequeNumberCol0Row8.Text = "0";
            txtChequeNumberCol0Row9.Text = "0";
        }

        private void Clear_Cheque_Date_Column()
        {
            dtChequeDateCol1Row0.Text = String.Empty;
            dtChequeDateCol1Row1.Text = String.Empty;
            dtChequeDateCol1Row2.Text = String.Empty;
            dtChequeDateCol1Row3.Text = String.Empty;
            dtChequeDateCol1Row4.Text = String.Empty;
            dtChequeDateCol1Row5.Text = String.Empty;
            dtChequeDateCol1Row6.Text = String.Empty;
            dtChequeDateCol1Row7.Text = String.Empty;
            dtChequeDateCol1Row8.Text = String.Empty;
            dtChequeDateCol1Row9.Text = String.Empty;
        }

        #endregion

        #region Button Clicked Events for the from

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPartPayment_Click(object sender, EventArgs e)
        {
            int i = 0;
            string message = String.Empty;
            if (InitializeRow0(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[0], chequedate[0], chequeAmount[0], tds[0], otherExpense[0], total[0]);
            }
            if (checkRow1.Checked == true && InitializeRow1(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[1], chequedate[1], chequeAmount[1], tds[1], otherExpense[1], total[1]);
            }
            if (checkRow2.Checked == true && InitializeRow2(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[2], chequedate[2], chequeAmount[2], tds[2], otherExpense[2], total[2]);
            }
            if (checkRow3.Checked == true && InitializeRow3(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[3], chequedate[3], chequeAmount[3], tds[3], otherExpense[3], total[3]);
            }
            if (checkRow4.Checked == true && InitializeRow4(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[4], chequedate[4], chequeAmount[4], tds[4], otherExpense[4], total[4]);
            }
            if (checkRow5.Checked == true && InitializeRow5(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[5], chequedate[5], chequeAmount[5], tds[5], otherExpense[5], total[5]);
            }
            if (checkRow6.Checked == true && InitializeRow6(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[6], chequedate[6], chequeAmount[6], tds[6], otherExpense[6], total[6]);
            }
            if (checkRow7.Checked == true && InitializeRow7(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[7], chequedate[7], chequeAmount[7], tds[7], otherExpense[7], total[7]);
            }
            if (checkRow8.Checked == true && InitializeRow8(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[8], chequedate[8], chequeAmount[8], tds[8], otherExpense[8], total[8]);
            }
            if (checkRow9.Checked == true && InitializeRow9(ref message))
            {
                i += this.insertintopartpaymentTableAdapter.Fill(this.zmaindataset.insertintopartpayment, Mnbillid, chequeNumber[9], chequedate[9], chequeAmount[9], tds[9], otherExpense[9], total[9]);
            }
            if (message != string.Empty)
            {
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Part payment made for the debit bill no " + Mnbillid);
            }
        }

        private bool InitializeRow9(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row9, dtChequeDateCol1Row9, txtChequeAmtCol2Row9, 10))
            {
                chequeNumber[9] = txtChequeNumberCol0Row9.Text;
                chequedate[9] = DateTime.Parse(dtChequeDateCol1Row9.Text);
                chequeAmount[9] = decimal.Parse(txtChequeAmtCol2Row9.Text);
                tds[9] = decimal.Parse(tdsCol3Row9.Text);
                otherExpense[9] = decimal.Parse(txtOtherExpCol4Row9.Text);
                total[9] = decimal.Parse(txtTotalCol5Row9.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow8(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row8, dtChequeDateCol1Row8, txtChequeAmtCol2Row8, 9))
            {
                chequeNumber[8] = txtChequeNumberCol0Row8.Text;
                chequedate[8] = DateTime.Parse(dtChequeDateCol1Row8.Text);
                chequeAmount[8] = decimal.Parse(txtChequeAmtCol2Row8.Text);
                tds[8] = decimal.Parse(tdsCol3Row8.Text);
                otherExpense[8] = decimal.Parse(txtOtherExpCol4Row8.Text);
                total[8] = decimal.Parse(txtTotalCol5Row8.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow7(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row7, dtChequeDateCol1Row7, txtChequeAmtCol2Row7, 8))
            {
                chequeNumber[7] = txtChequeNumberCol0Row7.Text;
                chequedate[7] = DateTime.Parse(dtChequeDateCol1Row7.Text);
                chequeAmount[7] = decimal.Parse(txtChequeAmtCol2Row7.Text);
                tds[7] = decimal.Parse(tdsCol3Row7.Text);
                otherExpense[7] = decimal.Parse(txtOtherExpCol4Row7.Text);
                total[7] = decimal.Parse(txtTotalCol5Row7.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow6(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row6, dtChequeDateCol1Row6, txtChequeAmtCol2Row6, 7))
            {
                chequeNumber[6] = txtChequeNumberCol0Row6.Text;
                chequedate[6] = DateTime.Parse(dtChequeDateCol1Row6.Text);
                chequeAmount[6] = decimal.Parse(txtChequeAmtCol2Row6.Text);
                tds[6] = decimal.Parse(tdsCol3Row6.Text);
                otherExpense[6] = decimal.Parse(txtOtherExpCol4Row6.Text);
                total[6] = decimal.Parse(txtTotalCol5Row6.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow5(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row5, dtChequeDateCol1Row5, txtChequeAmtCol2Row5, 6))
            {
                chequeNumber[5] = txtChequeNumberCol0Row5.Text;
                chequedate[5] = DateTime.Parse(dtChequeDateCol1Row5.Text);
                chequeAmount[5] = decimal.Parse(txtChequeAmtCol2Row5.Text);
                tds[5] = decimal.Parse(tdsCol3Row5.Text);
                otherExpense[5] = decimal.Parse(txtOtherExpCol4Row5.Text);
                total[5] = decimal.Parse(txtTotalCol5Row5.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow4(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row4, dtChequeDateCol1Row4, txtChequeAmtCol2Row4, 5))
            {
                chequeNumber[4] = txtChequeNumberCol0Row4.Text;
                chequedate[4] = DateTime.Parse(dtChequeDateCol1Row4.Text);
                chequeAmount[4] = decimal.Parse(txtChequeAmtCol2Row4.Text);
                tds[4] = decimal.Parse(tdsCol3Row4.Text);
                otherExpense[4] = decimal.Parse(txtOtherExpCol4Row4.Text);
                total[4] = decimal.Parse(txtTotalCol5Row4.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow3(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row3, dtChequeDateCol1Row3, txtChequeAmtCol2Row3, 4))
            {
                chequeNumber[3] = txtChequeNumberCol0Row3.Text;
                chequedate[3] = DateTime.Parse(dtChequeDateCol1Row3.Text);
                chequeAmount[3] = decimal.Parse(txtChequeAmtCol2Row3.Text);
                tds[3] = decimal.Parse(tdsCol3Row3.Text);
                otherExpense[3] = decimal.Parse(txtOtherExpCol4Row3.Text);
                total[3] = decimal.Parse(txtTotalCol5Row3.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow2(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row2, dtChequeDateCol1Row2, txtChequeAmtCol2Row2, 3))
            {
                chequeNumber[2] = txtChequeNumberCol0Row2.Text;
                chequedate[2] = DateTime.Parse(dtChequeDateCol1Row2.Text);
                chequeAmount[2] = decimal.Parse(txtChequeAmtCol2Row2.Text);
                tds[2] = decimal.Parse(tdsCol3Row2.Text);
                otherExpense[2] = decimal.Parse(txtOtherExpCol4Row2.Text);
                total[2] = decimal.Parse(txtTotalCol5Row2.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow1(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row1, dtChequeDateCol1Row1, txtChequeAmtCol2Row1, 2))
            {
                chequeNumber[1] = txtChequeNumberCol0Row1.Text;
                chequedate[1] = DateTime.Parse(dtChequeDateCol1Row1.Text);
                chequeAmount[1] = decimal.Parse(txtChequeAmtCol2Row1.Text);
                tds[1] = decimal.Parse(tdsCol3Row1.Text);
                otherExpense[1] = decimal.Parse(txtOtherExpCol4Row1.Text);
                total[1] = decimal.Parse(txtTotalCol5Row1.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private bool InitializeRow0(ref string message)
        {
            bool chk = true;
            if (CheckForPartTimeFields(ref message, comboDebitBillNumber, txtChequeNumberCol0Row0, dtChequeDateCol1Row0, txtChequeAmtCol2Row0, 1))
            {
                chequeNumber[0] = txtChequeNumberCol0Row0.Text;
                chequedate[0] = DateTime.Parse(dtChequeDateCol1Row0.Text);
                chequeAmount[0] = decimal.Parse(txtChequeAmtCol2Row0.Text);
                tds[0] = decimal.Parse(tdsCol3Row0.Text);
                otherExpense[0] = decimal.Parse(txtOtherExpCol4Row0.Text);
                total[0] = decimal.Parse(txtTotalCol5Row0.Text);
                chk = true;
            }
            else
            {
                chk = false;
            }
            return chk;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear's total textbox
            ClearAllFunction();

        }

        private void ClearAllFunction()
        {
            Clear_Text_Total_Payment();
            Clear_Text_Tds();
            Clear_Text_OtherExpense();
            Clear_Cheque_Amount();
            Clear_Cheque_Date_Column();
            Clear_Cheque_Number();
            Clear_OutSide_Fields();
        }
        #endregion

        #region Validation Function
        public bool CheckForPartTimeFields(ref string message, ComboBoxEdit billid, TextEdit chequeNumber, DateEdit ChequeDate, TextEdit chequeAmount, int row)
        {
            bool retVal = true;
            ArrayList list = new ArrayList();
            if (ValidationClass.IsComboEditSelectedIndexZero(billid))
            {
                list.Add(true);
                message += "Please select the debit bill number " + "\n\r";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsTextEditEmptyOrSingleZero(chequeNumber))
            {
                list.Add(true);
                message += "Cheque Number Cannot be Empty or Zero for Row " + row.ToString() + "\n\r";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsDateEditEmpty(ChequeDate))
            {
                list.Add(true);
                message += "Cheque Amount Cannot be Empty for Row " + row.ToString() + "\n\r";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsTextEditEmptyOrSingleZero(chequeAmount))
            {
                list.Add(true);
                message += "Cheque Amount Cannot be Empty or Zero for Row " + row.ToString() + "\n\r";
            }
            else
            {
                list.Add(false);
            }

            foreach (bool b in list)
            {
                if (b == true)
                {
                    retVal = false;
                }
            }
            return retVal;
        }
        #endregion

        #region Cheque Amount Fill Functions and Events

        private void txtChequeAmt_Leave(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;

            if (edit.Name.Equals("txtChequeAmtCol2Row0"))
            {
                FillChequeAmountTotal0(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row1"))
            {
                FillChequeAmountTotal1(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row2"))
            {
                FillChequeAmountTotal2(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row3"))
            {
                FillChequeAmountTotal3(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row4"))
            {
                FillChequeAmountTotal4(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row5"))
            {
                FillChequeAmountTotal5(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row6"))
            {
                FillChequeAmountTotal6(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row7"))
            {
                FillChequeAmountTotal7(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row8"))
            {
                FillChequeAmountTotal8(edit);
            }
            if (edit.Name.Equals("txtChequeAmtCol2Row9"))
            {
                FillChequeAmountTotal9(edit);
            }


        }

        private void FillChequeAmountTotal9(TextEdit edit)
        {

            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row9.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row2) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row3) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row4) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row5) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row6) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row7) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row8))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
                total += decimal.Parse(txtChequeAmtCol2Row2.Text);
                total += decimal.Parse(txtChequeAmtCol2Row3.Text);
                total += decimal.Parse(txtChequeAmtCol2Row4.Text);
                total += decimal.Parse(txtChequeAmtCol2Row5.Text);
                total += decimal.Parse(txtChequeAmtCol2Row6.Text);
                total += decimal.Parse(txtChequeAmtCol2Row7.Text);
                total += decimal.Parse(txtChequeAmtCol2Row8.Text);
            }
            txtTotalChequeAmount.Text = total.ToString();
        }

        private void FillChequeAmountTotal8(TextEdit edit)
        {

            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row8.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row2) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row3) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row4) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row5) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row6) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row7))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
                total += decimal.Parse(txtChequeAmtCol2Row2.Text);
                total += decimal.Parse(txtChequeAmtCol2Row3.Text);
                total += decimal.Parse(txtChequeAmtCol2Row4.Text);
                total += decimal.Parse(txtChequeAmtCol2Row5.Text);
                total += decimal.Parse(txtChequeAmtCol2Row6.Text);
                total += decimal.Parse(txtChequeAmtCol2Row7.Text);

            }
            txtTotalChequeAmount.Text = total.ToString();
        }

        private void FillChequeAmountTotal7(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row7.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row2) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row3) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row4) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row5) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row6))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
                total += decimal.Parse(txtChequeAmtCol2Row2.Text);
                total += decimal.Parse(txtChequeAmtCol2Row3.Text);
                total += decimal.Parse(txtChequeAmtCol2Row4.Text);
                total += decimal.Parse(txtChequeAmtCol2Row5.Text);
                total += decimal.Parse(txtChequeAmtCol2Row6.Text);

            }
            txtTotalChequeAmount.Text = total.ToString();
        }

        private void FillChequeAmountTotal6(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row6.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row2) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row3) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row4) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row5))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
                total += decimal.Parse(txtChequeAmtCol2Row2.Text);
                total += decimal.Parse(txtChequeAmtCol2Row3.Text);
                total += decimal.Parse(txtChequeAmtCol2Row4.Text);
                total += decimal.Parse(txtChequeAmtCol2Row5.Text);
            }
            txtTotalChequeAmount.Text = total.ToString();
        }

        private void FillChequeAmountTotal5(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row5.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row2) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row3) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row4))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
                total += decimal.Parse(txtChequeAmtCol2Row2.Text);
                total += decimal.Parse(txtChequeAmtCol2Row3.Text);
                total += decimal.Parse(txtChequeAmtCol2Row4.Text);
            }
            txtTotalChequeAmount.Text = total.ToString();

        }

        private void FillChequeAmountTotal4(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row4.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row2) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row3))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
                total += decimal.Parse(txtChequeAmtCol2Row2.Text);
                total += decimal.Parse(txtChequeAmtCol2Row3.Text);

            }
            txtTotalChequeAmount.Text = total.ToString();

        }

        private void FillChequeAmountTotal3(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row3.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row2))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
                total += decimal.Parse(txtChequeAmtCol2Row2.Text);
            }
            txtTotalChequeAmount.Text = total.ToString();

        }

        private void FillChequeAmountTotal2(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row2.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0) & !ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row1))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
                total += decimal.Parse(txtChequeAmtCol2Row1.Text);
            }
            txtTotalChequeAmount.Text = total.ToString();
        }

        private void FillChequeAmountTotal1(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row1.Text = edit.Text;
            if (!ValidationClass.IsTextEditEmpty(txtChequeAmtCol2Row0))
            {
                total += decimal.Parse(txtChequeAmtCol2Row0.Text);
            }
            txtTotalChequeAmount.Text = total.ToString();
        }

        private void FillChequeAmountTotal0(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            txtTotalCol5Row0.Text = edit.Text;
            txtTotalChequeAmount.Text = total.ToString();
        }

        #endregion

        #region Tds decution Events and Functions
        private void tds_Leave(object sender, EventArgs e)
        {

            TextEdit edit = sender as TextEdit;

            if (edit.Name.Equals("tdsCol3Row0"))
            {
                FillTdsTotal0(edit);
            }
            if (edit.Name.Equals("tdsCol3Row1"))
            {
                FillTdsTotal1(edit);

            }
            if (edit.Name.Equals("tdsCol3Row2"))
            {
                FillTdsTotal2(edit);

            }
            if (edit.Name.Equals("tdsCol3Row3"))
            {
                FillTdsTotal3(edit);

            }
            if (edit.Name.Equals("tdsCol3Row4"))
            {
                FillTdsTotal4(edit);
            }
            if (edit.Name.Equals("tdsCol3Row5"))
            {
                FillTdsTotal5(edit);

            }
            if (edit.Name.Equals("tdsCol3Row6"))
            {
                FillTdsTotal6(edit);

            }
            if (edit.Name.Equals("tdsCol3Row7"))
            {
                FillTdsTotal7(edit);

            }
            if (edit.Name.Equals("tdsCol3Row8"))
            {
                FillTdsTotal8(edit);

            }
            if (edit.Name.Equals("tdsCol3Row9"))
            {
                FillTdsTotal9(edit);
            }

        }
        private void FillTdsTotal0(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row0.Text);
                txtTotalCol5Row0.Text = (total1 - tdstotal).ToString();
            }

            decimal total = decimal.Parse(tdsCol3Row0.Text);
            txtTdsTotal.Text = total.ToString();
        }

        private void FillTdsTotal9(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row9))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row9.Text);
                txtTotalCol5Row9.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1)
                & !ValidationClass.IsTextEditEmpty(tdsCol3Row2) & !ValidationClass.IsTextEditEmpty(tdsCol3Row3) & !ValidationClass.IsTextEditEmpty(tdsCol3Row4) & !ValidationClass.IsTextEditEmpty(tdsCol3Row5) & !ValidationClass.IsTextEditEmpty(tdsCol3Row6) & !ValidationClass.IsTextEditEmpty(tdsCol3Row7) & !ValidationClass.IsTextEditEmpty(tdsCol3Row8))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                total += decimal.Parse(tdsCol3Row2.Text);
                total += decimal.Parse(tdsCol3Row3.Text);
                total += decimal.Parse(tdsCol3Row4.Text);
                total += decimal.Parse(tdsCol3Row5.Text);
                total += decimal.Parse(tdsCol3Row6.Text);
                total += decimal.Parse(tdsCol3Row7.Text);
                total += decimal.Parse(tdsCol3Row8.Text);

                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }

        private void FillTdsTotal8(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row8))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row8.Text);
                txtTotalCol5Row8.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1)
                & !ValidationClass.IsTextEditEmpty(tdsCol3Row2) & !ValidationClass.IsTextEditEmpty(tdsCol3Row3) & !ValidationClass.IsTextEditEmpty(tdsCol3Row4) & !ValidationClass.IsTextEditEmpty(tdsCol3Row5) & !ValidationClass.IsTextEditEmpty(tdsCol3Row6) & !ValidationClass.IsTextEditEmpty(tdsCol3Row7))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                total += decimal.Parse(tdsCol3Row2.Text);
                total += decimal.Parse(tdsCol3Row3.Text);
                total += decimal.Parse(tdsCol3Row4.Text);
                total += decimal.Parse(tdsCol3Row5.Text);
                total += decimal.Parse(tdsCol3Row6.Text);
                total += decimal.Parse(tdsCol3Row7.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }

        private void FillTdsTotal7(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row7))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row7.Text);
                txtTotalCol5Row7.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1)
                & !ValidationClass.IsTextEditEmpty(tdsCol3Row2) & !ValidationClass.IsTextEditEmpty(tdsCol3Row3) & !ValidationClass.IsTextEditEmpty(tdsCol3Row4) & !ValidationClass.IsTextEditEmpty(tdsCol3Row5) & !ValidationClass.IsTextEditEmpty(tdsCol3Row6))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                total += decimal.Parse(tdsCol3Row2.Text);
                total += decimal.Parse(tdsCol3Row3.Text);
                total += decimal.Parse(tdsCol3Row4.Text);
                total += decimal.Parse(tdsCol3Row5.Text);
                total += decimal.Parse(tdsCol3Row6.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }


        }

        private void FillTdsTotal6(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row6))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row6.Text);
                txtTotalCol5Row6.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1)
                & !ValidationClass.IsTextEditEmpty(tdsCol3Row2) & !ValidationClass.IsTextEditEmpty(tdsCol3Row3) & !ValidationClass.IsTextEditEmpty(tdsCol3Row4) & !ValidationClass.IsTextEditEmpty(tdsCol3Row5))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                total += decimal.Parse(tdsCol3Row2.Text);
                total += decimal.Parse(tdsCol3Row3.Text);
                total += decimal.Parse(tdsCol3Row4.Text);
                total += decimal.Parse(tdsCol3Row5.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }

        private void FillTdsTotal5(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row5))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row5.Text);
                txtTotalCol5Row5.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1)
                & !ValidationClass.IsTextEditEmpty(tdsCol3Row2) & !ValidationClass.IsTextEditEmpty(tdsCol3Row3) & !ValidationClass.IsTextEditEmpty(tdsCol3Row4))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                total += decimal.Parse(tdsCol3Row2.Text);
                total += decimal.Parse(tdsCol3Row3.Text);
                total += decimal.Parse(tdsCol3Row4.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }

        private void FillTdsTotal4(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row4))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row4.Text);
                txtTotalCol5Row4.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1)
                & !ValidationClass.IsTextEditEmpty(tdsCol3Row2) & !ValidationClass.IsTextEditEmpty(tdsCol3Row3))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                total += decimal.Parse(tdsCol3Row2.Text);
                total += decimal.Parse(tdsCol3Row3.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }

        private void FillTdsTotal3(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row3))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row3.Text);
                txtTotalCol5Row3.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1)
                & !ValidationClass.IsTextEditEmpty(tdsCol3Row2))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                total += decimal.Parse(tdsCol3Row2.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }

        private void FillTdsTotal2(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row2))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row2.Text);
                txtTotalCol5Row2.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0) & !ValidationClass.IsTextEditEmpty(tdsCol3Row1))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                total += decimal.Parse(tdsCol3Row1.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }

        private void FillTdsTotal1(TextEdit edit)
        {
            decimal tdstotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row1))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row1.Text);
                txtTotalCol5Row1.Text = (total1 - tdstotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(tdsCol3Row0))
            {
                decimal total = decimal.Parse(tdsCol3Row0.Text);
                txtTdsTotal.Text = (total + tdstotal).ToString();
            }
        }
        #endregion

        #region Fill Txttotal textbox fields
        private void txtTotal_Leave(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;

            if (edit.Name.Equals("txtTotalCol5Row0"))
            {
                FilltxtTotal0(edit);
            }
            if (edit.Name.Equals("txtTotalCol5Row1"))
            {
                FilltxtTotal1(edit);

            }
            if (edit.Name.Equals("txtTotalCol5Row2"))
            {
                FilltxtTotal2(edit);

            }
            if (edit.Name.Equals("txtTotalCol5Row3"))
            {
                FilltxtTotal3(edit);

            }
            if (edit.Name.Equals("txtTotalCol5Row4"))
            {
                FilltxtTotal4(edit);
            }
            if (edit.Name.Equals("txtTotalCol5Row5"))
            {
                FilltxtTotal5(edit);

            }
            if (edit.Name.Equals("txtTotalCol5Row6"))
            {
                FilltxtTotal6(edit);

            }
            if (edit.Name.Equals("txtTotalCol5Row7"))
            {
                FilltxtTotal7(edit);

            }
            if (edit.Name.Equals("txtTotalCol5Row8"))
            {
                FilltxtTotal8(edit);

            }
            if (edit.Name.Equals("txtTotalCol5Row9"))
            {
                FilltxtTotal9(edit);
            }

        }

        private void FilltxtTotal0(TextEdit edit)
        {
            txtTotalPartPayment.Text = edit.Text;
        }

        private void FilltxtTotal1(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal2(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal3(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row2))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                total += decimal.Parse(txtTotalCol5Row2.Text);
                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal4(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row2) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row3))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                total += decimal.Parse(txtTotalCol5Row2.Text);
                total += decimal.Parse(txtTotalCol5Row3.Text);
                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal5(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row2) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row3) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row4))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                total += decimal.Parse(txtTotalCol5Row2.Text);
                total += decimal.Parse(txtTotalCol5Row3.Text);
                total += decimal.Parse(txtTotalCol5Row4.Text);
                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal6(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row2) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row3) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row4) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row5))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                total += decimal.Parse(txtTotalCol5Row2.Text);
                total += decimal.Parse(txtTotalCol5Row3.Text);
                total += decimal.Parse(txtTotalCol5Row4.Text);
                total += decimal.Parse(txtTotalCol5Row5.Text);
                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal7(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row2) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row3) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row4) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row5) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row6))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                total += decimal.Parse(txtTotalCol5Row2.Text);
                total += decimal.Parse(txtTotalCol5Row3.Text);
                total += decimal.Parse(txtTotalCol5Row4.Text);
                total += decimal.Parse(txtTotalCol5Row5.Text);
                total += decimal.Parse(txtTotalCol5Row6.Text);
                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal8(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row2) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row3) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row4) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row5) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row6) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row7))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                total += decimal.Parse(txtTotalCol5Row2.Text);
                total += decimal.Parse(txtTotalCol5Row3.Text);
                total += decimal.Parse(txtTotalCol5Row4.Text);
                total += decimal.Parse(txtTotalCol5Row5.Text);
                total += decimal.Parse(txtTotalCol5Row6.Text);
                total += decimal.Parse(txtTotalCol5Row7.Text);

                txtTotalPartPayment.Text = total.ToString();
            }
        }

        private void FilltxtTotal9(TextEdit edit)
        {
            decimal total = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row1) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row2) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row3) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row4) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row5) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row6) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row7) & !ValidationClass.IsTextEditEmpty(txtTotalCol5Row8))
            {
                total += decimal.Parse(txtTotalCol5Row0.Text);
                total += decimal.Parse(txtTotalCol5Row1.Text);
                total += decimal.Parse(txtTotalCol5Row2.Text);
                total += decimal.Parse(txtTotalCol5Row3.Text);
                total += decimal.Parse(txtTotalCol5Row4.Text);
                total += decimal.Parse(txtTotalCol5Row5.Text);
                total += decimal.Parse(txtTotalCol5Row6.Text);
                total += decimal.Parse(txtTotalCol5Row7.Text);
                total += decimal.Parse(txtTotalCol5Row8.Text);
                txtTotalPartPayment.Text = total.ToString();
            }

        }

        #endregion

        #region Other Expense Automatically fill values
        private void txtOtherExpense_Leave(object sender, EventArgs e)
        {

            TextEdit edit = sender as TextEdit;

            if (edit.Name.Equals("txtOtherExpCol4Row0"))
            {
                FillOtherExpTotal0(edit);
            }
            if (edit.Name.Equals("txtOtherExpCol4Row1"))
            {
                FillOtherExpTotal1(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row2"))
            {
                FillOtherExpTotal2(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row3"))
            {
                FillOtherExpTotal3(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row4"))
            {
                FillOtherExpTotal4(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row5"))
            {
                FillOtherExpTotal5(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row6"))
            {
                FillOtherExpTotal6(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row7"))
            {
                FillOtherExpTotal7(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row8"))
            {
                FillOtherExpTotal8(edit);

            }
            if (edit.Name.Equals("txtOtherExpCol4Row9"))
            {
                FillOtherExpTotal9(edit);
            }
        }
        private void FillOtherExpTotal0(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row0))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row0.Text);
                txtTotalCol5Row0.Text = (total1 - othtotal).ToString();
            }
            decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
            txtOtherExpense.Text = total.ToString();
        }
        private void FillOtherExpTotal1(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row1))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row1.Text);
                txtTotalCol5Row1.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }
        private void FillOtherExpTotal2(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row2))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row2.Text);
                txtTotalCol5Row2.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }
        private void FillOtherExpTotal3(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row3))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row3.Text);
                txtTotalCol5Row3.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row2))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                total += decimal.Parse(txtOtherExpCol4Row2.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }

        private void FillOtherExpTotal4(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row4))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row4.Text);
                txtTotalCol5Row4.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row2) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row3))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                total += decimal.Parse(txtOtherExpCol4Row2.Text);
                total += decimal.Parse(txtOtherExpCol4Row3.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }

        private void FillOtherExpTotal5(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row5))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row5.Text);
                txtTotalCol5Row5.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row2) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row3) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row4))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                total += decimal.Parse(txtOtherExpCol4Row2.Text);
                total += decimal.Parse(txtOtherExpCol4Row3.Text);
                total += decimal.Parse(txtOtherExpCol4Row4.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }

        private void FillOtherExpTotal6(TextEdit edit)
        {

            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row6))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row6.Text);
                txtTotalCol5Row6.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row2) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row3) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row4) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row5))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                total += decimal.Parse(txtOtherExpCol4Row2.Text);
                total += decimal.Parse(txtOtherExpCol4Row3.Text);
                total += decimal.Parse(txtOtherExpCol4Row4.Text);
                total += decimal.Parse(txtOtherExpCol4Row5.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }

        private void FillOtherExpTotal7(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row7))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row7.Text);
                txtTotalCol5Row7.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row2) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row3) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row4) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row5) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row6))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                total += decimal.Parse(txtOtherExpCol4Row2.Text);
                total += decimal.Parse(txtOtherExpCol4Row3.Text);
                total += decimal.Parse(txtOtherExpCol4Row4.Text);
                total += decimal.Parse(txtOtherExpCol4Row5.Text);
                total += decimal.Parse(txtOtherExpCol4Row6.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }

        private void FillOtherExpTotal8(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row8))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row8.Text);
                txtTotalCol5Row8.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row2) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row3) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row4) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row5) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row6) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row7))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                total += decimal.Parse(txtOtherExpCol4Row2.Text);
                total += decimal.Parse(txtOtherExpCol4Row3.Text);
                total += decimal.Parse(txtOtherExpCol4Row4.Text);
                total += decimal.Parse(txtOtherExpCol4Row5.Text);
                total += decimal.Parse(txtOtherExpCol4Row6.Text);
                total += decimal.Parse(txtOtherExpCol4Row7.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }

        private void FillOtherExpTotal9(TextEdit edit)
        {
            decimal othtotal = decimal.Parse(edit.Text);
            if (!ValidationClass.IsTextEditEmpty(txtTotalCol5Row9))
            {
                decimal total1 = decimal.Parse(txtTotalCol5Row9.Text);
                txtTotalCol5Row9.Text = (total1 - othtotal).ToString();
            }
            if (!ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row0) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row1) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row2) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row3) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row4) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row5) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row6) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row7) & !ValidationClass.IsTextEditEmpty(txtOtherExpCol4Row8))
            {
                decimal total = decimal.Parse(txtOtherExpCol4Row0.Text);
                total += decimal.Parse(txtOtherExpCol4Row1.Text);
                total += decimal.Parse(txtOtherExpCol4Row2.Text);
                total += decimal.Parse(txtOtherExpCol4Row3.Text);
                total += decimal.Parse(txtOtherExpCol4Row4.Text);
                total += decimal.Parse(txtOtherExpCol4Row5.Text);
                total += decimal.Parse(txtOtherExpCol4Row6.Text);
                total += decimal.Parse(txtOtherExpCol4Row7.Text);
                total += decimal.Parse(txtOtherExpCol4Row8.Text);
                txtOtherExpense.Text = (total + othtotal).ToString();
            }
        }

        #endregion

        #region Check box Events
        private void checkRow_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.Name.Equals("checkRow1"))
            {
                EnableRow1(check);
            }
            if (check.Name.Equals("checkRow2"))
            {
                EnableRow2(check);
            }
            if (check.Name.Equals("checkRow3"))
            {
                EnableRow3(check);
            }
            if (check.Name.Equals("checkRow4"))
            {
                EnableRow4(check);
            }
            if (check.Name.Equals("checkRow5"))
            {
                EnableRow5(check);
            }
            if (check.Name.Equals("checkRow6"))
            {
                EnableRow6(check);
            }
            if (check.Name.Equals("checkRow7"))
            {
                EnableRow7(check);
            }
            if (check.Name.Equals("checkRow8"))
            {
                EnableRow8(check);
            }
            if (check.Name.Equals("checkRow9"))
            {
                EnableRow9(check);
            }
        }

        private void EnableRow9(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel16.Enabled = true;
            }
            else
            {
                tableLayoutPanel16.Enabled = false;
            }
        }

        private void EnableRow8(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel15.Enabled = true;
            }
            else
            {
                tableLayoutPanel15.Enabled = false;
            }
        }

        private void EnableRow7(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel13.Enabled = true;
            }
            else
            {
                tableLayoutPanel13.Enabled = false;
            }
        }

        private void EnableRow6(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel11.Enabled = true;
            }
            else
            {
                tableLayoutPanel11.Enabled = false;
            }
        }

        private void EnableRow5(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel10.Enabled = true;
            }
            else
            {
                tableLayoutPanel10.Enabled = false;
            }
        }

        private void EnableRow4(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel9.Enabled = true;
            }
            else
            {
                tableLayoutPanel9.Enabled = false;
            }
        }

        private void EnableRow3(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel8.Enabled = true;
            }
            else
            {
                tableLayoutPanel8.Enabled = false;
            }
        }

        private void EnableRow2(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel7.Enabled = true;
            }
            else
            {
                tableLayoutPanel7.Enabled = false;
            }
        }

        private void EnableRow1(CheckBox check)
        {
            if (check.Checked.Equals(true))
            {
                tableLayoutPanel4.Enabled = true;
            }
            else
            {
                tableLayoutPanel4.Enabled = false;
            }
        }
        #endregion

        #region Button Enter Event and Validation for button Enter
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int i = 0;
            string message = String.Empty;
            if (ValidationForBillReceived(ref message))
            {
                //this.zmaindataset.Clear();
                try
                {
                    i = this.zmainbillTableAdapter1.FillByPaymentRecieved(this.zmaindataset.zmainbill, int.Parse(comboDebitBillNumber.SelectedItem.ToString()), DateTime.Parse(dtPaymentDate.Text), comPaymentRecieved.SelectedItem.ToString() == "Yes" ? true : false);
                }
                catch
                {
                }
                dataGridView1.DataSource = this.zmaindataset.zmainbill;
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = 0;
            string message = String.Empty;
            if (ValidationForBillReceived(ref message))
            {
                //this.zmaindataset.Clear();
                try
                {
                    i = this.zmainbillTableAdapter1.FillByPaymentRecieved(this.zmaindataset.zmainbill, int.Parse(comboDebitBillNumber.SelectedItem.ToString()), DateTime.Parse(dtPaymentDate.Text), comPaymentRecieved.SelectedItem.ToString() == "Yes" ? true : false);
                }
                catch
                {
                }
                dataGridView1.DataSource = this.zmaindataset.zmainbill;
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public bool ValidationForBillReceived(ref string message)
        {
            ArrayList list = new ArrayList();
            bool retVal = true;
            if (comboDebitBillNumber.SelectedIndex == -1 && comboDebitBillNumber.Text == string.Empty)
            {
                list.Add(true);
                message += "Debit Bill Number Cannot be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            if (comPaymentRecieved.SelectedIndex == -1 && comPaymentRecieved.Text == String.Empty)
            {
                list.Add(true);
                message += "Payment Received Cannot be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            foreach (bool b in list)
            {
                if (b == true)
                {
                    retVal = false;
                }
            }
            return retVal;
        }
        
#endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboDebitBillNumber.SelectedItem.ToString() != String.Empty)
            {
                this.billRcvTableAdapter.FillBySearchPartPayment(this.zmaindataset.billRcv, int.Parse(comboDebitBillNumber.SelectedItem.ToString()));
                dataGridView1.DataSource = this.zmaindataset.billRcv;
            }
        }

        
    }
}