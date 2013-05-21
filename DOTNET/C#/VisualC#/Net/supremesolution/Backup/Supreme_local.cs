using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraEditors;

namespace SupremeTransport
{
    public partial class Supreme_local : Form
    {
        public Supreme_local()
        {
            InitializeComponent();
        }

        private void Supreme_local_Load(object sender, EventArgs e)
        {
            this.selectlocalbillTableAdapter.Fill(this.lclsupset.selectlocalbill);
        }

        #region Bill Variable Fields

        int billNumber;
        string partyname;
        DateTime billDate;
        decimal ttlamount;
        int mainBillId;

        public int MainBillId
        {
            get { return mainBillId; }
            set { mainBillId = value; }
        }

        public string PartyName
        {
            get { return partyname; }
            set { partyname = value; }
        }
        public decimal Ttlamount
        {
            get { return ttlamount; }
            set { ttlamount = value; }
        }
        public int BillNumber
        {
            get { return billNumber; }
            set { billNumber = value; }
        }
        public DateTime BillDate
        {
            get { return billDate; }
            set { billDate = value; }
        }

        #endregion

        #region Bill detail region
        string truckno, from, to, commodities;
        decimal weight, money;
        DateTime detBillDate;

        public string Truckno
        {
            get { return truckno; }
            set
            {
                if (value.Equals(String.Empty))
                {
                    truckno = "N.A";
                }
                else
                {
                    truckno = value;
                }
            }
        }

        public string From
        {
            get { return from; }
            set
            {

                if (value.Equals(String.Empty))
                {
                    from = "N.A";
                }
                else
                {
                    from = value;
                }
            }
        }

        public string To
        {
            get { return to; }
            set { to = value == String.Empty ? "N.A" : value; }
        }

        public string Commodities
        {
            get { return commodities; }
            set { commodities = (value == String.Empty | value == "0") ? "0" : value; }
        }

        public decimal Weight
        {
            get { return weight; }
            set { weight = Convert.ToString(value) == String.Empty ? 0 : value; }
        }

        public decimal Money
        {
            get { return money; }
            set { money = value.ToString() == String.Empty ? 0 : value; }
        }
        public DateTime DetBillDate
        {
            get { return detBillDate; }
            set { detBillDate = value.ToString() == String.Empty ? DateTime.Parse(new DateTime(2010, 1, 1).ToShortDateString()) : value; }
        }

        #endregion

        #region DataGridView Events
        private string FormatMoneyValue(string p)
        {
            decimal money = decimal.Parse(p);
            money = Math.Round(money);
            return money.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMsstlc.Text = dataGridView1.CurrentRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString().ToUpper();
            txtBillNumberstlc.Text = dataGridView1.CurrentRow.Cells["billnoDataGridViewTextBoxColumn"].Value.ToString();
            dateEditstlc.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells["startdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            calcTotalAmount.Text = FormatMoneyValue(dataGridView1.CurrentRow.Cells["total_amount"].Value.ToString());

            MainBillId = Int32.Parse(dataGridView1.CurrentRow.Cells["localbillidDataGridViewTextBoxColumn"].Value.ToString());
            this.selectlocaldetTableAdapter1.FillBy(this.lclsupset.selectlocaldet, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells["localbillidDataGridViewTextBoxColumn"].Value.ToString(), typeof(int))))));
            //this.selectlocaldetTableAdapter1.Fill(this.lclsupset.selectlocaldet, int.Parse(dataGridView1.CurrentRow.Cells["localbillidDataGridViewTextBoxColumn"].Value.ToString()));
            dataGridView2.DataSource = this.lclsupset.selectlocaldet;

            FillBillTextBoxes();
            radioUpdatestlc.Checked = true;
            //radioInsertstlc.Checked = true;
            btnClear.Enabled = false;
            txtBillNumberstlc.Enabled = false;

        }
        #endregion

        #region FillTextBox Fields

        private void FillBillTextBoxes()
        {
            for (int j = 0; j < 7; j++)
            {
                if (j == 0)
                {
                    FillRow1(j);
                }
                if (j == 1)
                {
                    FillRow2(j);
                }
                if (j == 2)
                {
                    FillRow3(j);
                }
                if (j == 3)
                {
                    FillRow4(j);
                }
                if (j == 4)
                {
                    FillRow5(j);
                }
                if (j == 5)
                {
                    FillRow6(j);
                }
                if (j == 6)
                {
                    FillRow7(j);
                }

            }

        }

        private void FillRow7(int j)
        {
            dtcol0Row6.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            cmbTruckCol1Row6.Text = dataGridView2.Rows[j].Cells["truckNoDataGridViewTextBoxColumn"].Value.ToString();
            cmbFromCol2Row6.Text = dataGridView2.Rows[j].Cells["fromnameDataGridViewTextBoxColumn"].Value.ToString();
            cmbToCol3Row6.Text = dataGridView2.Rows[j].Cells["tonameDataGridViewTextBoxColumn"].Value.ToString();
            cmbCommodCol4Row6.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["commoditiesDataGridViewTextBoxColumn"].Value.ToString());
            cmbWeightCol5Row6.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["weightDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol6Row6.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            BillId6 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow6(int j)
        {
            dtcol0Row5.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            cmbTruckCol1Row5.Text = dataGridView2.Rows[j].Cells["truckNoDataGridViewTextBoxColumn"].Value.ToString();
            cmbFromCol2Row5.Text = dataGridView2.Rows[j].Cells["fromnameDataGridViewTextBoxColumn"].Value.ToString();
            cmbToCol3Row5.Text = dataGridView2.Rows[j].Cells["tonameDataGridViewTextBoxColumn"].Value.ToString();
            cmbCommodCol4Row5.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["commoditiesDataGridViewTextBoxColumn"].Value.ToString());
            cmbWeightCol5Row5.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["weightDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol6Row5.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            BillId5 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow5(int j)
        {
            dtcol0Row4.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            cmbTruckCol1Row4.Text = dataGridView2.Rows[j].Cells["truckNoDataGridViewTextBoxColumn"].Value.ToString();
            cmbFromCol2Row4.Text = dataGridView2.Rows[j].Cells["fromnameDataGridViewTextBoxColumn"].Value.ToString();
            cmbToCol3Row4.Text = dataGridView2.Rows[j].Cells["tonameDataGridViewTextBoxColumn"].Value.ToString();
            cmbCommodCol4Row4.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["commoditiesDataGridViewTextBoxColumn"].Value.ToString());
            cmbWeightCol5Row4.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["weightDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol6Row4.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            BillId4 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow4(int j)
        {
            dtcol0Row3.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            cmbTruckCol1Row3.Text = dataGridView2.Rows[j].Cells["truckNoDataGridViewTextBoxColumn"].Value.ToString();
            cmbFromCol2Row3.Text = dataGridView2.Rows[j].Cells["fromnameDataGridViewTextBoxColumn"].Value.ToString();
            cmbToCol3Row3.Text = dataGridView2.Rows[j].Cells["tonameDataGridViewTextBoxColumn"].Value.ToString();
            cmbCommodCol4Row3.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["commoditiesDataGridViewTextBoxColumn"].Value.ToString());
            cmbWeightCol5Row3.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["weightDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol6Row3.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            BillId3 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow3(int j)
        {
            dtcol0Row2.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            cmbTruckCol1Row2.Text = dataGridView2.Rows[j].Cells["truckNoDataGridViewTextBoxColumn"].Value.ToString();
            cmbFromCol2Row2.Text = dataGridView2.Rows[j].Cells["fromnameDataGridViewTextBoxColumn"].Value.ToString();
            cmbToCol3Row2.Text = dataGridView2.Rows[j].Cells["tonameDataGridViewTextBoxColumn"].Value.ToString();
            cmbCommodCol4Row2.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["commoditiesDataGridViewTextBoxColumn"].Value.ToString());
            cmbWeightCol5Row2.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["weightDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol6Row2.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            BillId2 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow2(int j)
        {
            dtcol0Row1.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            cmbTruckCol1Row1.Text = dataGridView2.Rows[j].Cells["truckNoDataGridViewTextBoxColumn"].Value.ToString();
            cmbFromCol2Row1.Text = dataGridView2.Rows[j].Cells["fromnameDataGridViewTextBoxColumn"].Value.ToString();
            cmbToCol3Row1.Text = dataGridView2.Rows[j].Cells["tonameDataGridViewTextBoxColumn"].Value.ToString();
            cmbCommodCol4Row1.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["commoditiesDataGridViewTextBoxColumn"].Value.ToString());
            cmbWeightCol5Row1.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["weightDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol6Row1.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            BillId1 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow1(int j)
        {
            dtcol0Row0.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billDateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            cmbTruckCol1Row0.Text = dataGridView2.Rows[j].Cells["truckNoDataGridViewTextBoxColumn"].Value.ToString();
            cmbFromCol2Row0.Text = dataGridView2.Rows[j].Cells["fromnameDataGridViewTextBoxColumn"].Value.ToString();
            cmbToCol3Row0.Text = dataGridView2.Rows[j].Cells["tonameDataGridViewTextBoxColumn"].Value.ToString();
            cmbCommodCol4Row0.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["commoditiesDataGridViewTextBoxColumn"].Value.ToString());
            cmbWeightCol5Row0.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["weightDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol6Row0.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            BillId0 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        #endregion

        #region Button Events
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
           int rowsAffected = UpdateMainBill();
            rowsAffected += UpdateDetBill();
           if(rowsAffected != 0)
           {
               MessageBox.Show("Bill Updated");
           }
           else{
           MessageBox.Show("Updation Failed");
           }

            this.selectlocalbillTableAdapter.Fill(this.lclsupset.selectlocalbill);
            dataGridView1.DataSource = this.lclsupset.selectlocalbill;
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int i = this.selectlocalbillTableAdapter.Delete(MainBillId);
                this.selectlocalbillTableAdapter.Fill(lclsupset.selectlocalbill);
                dataGridView1.DataSource = lclsupset.selectlocalbill;
                if (i != 0)
                {
                    MessageBox.Show(MainBillId.ToString() + " Bill Deleted");
                }
                else
                {
                    MessageBox.Show("Deleting of Bill Entry Failed");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFieldsAll();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Function To Clear all fields
        /// <summary>
        /// This function clears all fields from the form
        /// Supreme_local
        /// </summary>
        private void ClearFieldsAll()
        {
            System.Collections.IEnumerator en = tableLayoutPanel1.Controls.GetEnumerator();
            while (en.MoveNext())
            {
                if (en.Current is DevExpress.XtraEditors.ComboBoxEdit)
                {

                    DevExpress.XtraEditors.ComboBoxEdit combo = en.Current as DevExpress.XtraEditors.ComboBoxEdit;
                    combo.Text = String.Empty;
                }
                if (en.Current is TextEdit)
                {
                    TextEdit text = en.Current as TextEdit;
                    text.Text = String.Empty;
                }
                if (en.Current is DateEdit)
                {
                    DateEdit dt = en.Current as DateEdit;
                    dt.Text = String.Empty;
                }
            }
            System.Collections.IEnumerator egroupbox1 = groupBox1.Controls.GetEnumerator();
            while (egroupbox1.MoveNext())
            {
                if (egroupbox1.Current is TextBox)
                {
                    TextBox text = egroupbox1.Current as TextBox;
                    text.Text = String.Empty;
                }
                if (egroupbox1.Current is DateEdit)
                {
                    DateEdit dt = egroupbox1.Current as DateEdit;
                    dt.Text = String.Empty;
                }
            }
            calcTotalAmount.Text = String.Empty;
        }
        #endregion

        #region Enter Button Event
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            if (CheckAllFields(ref message))
            {
                int rows = InsertDataInBill();
                rows += InsertBillDet();
                if (rows != 0)
                {
                    this.selectlocalbillTableAdapter.Fill(this.lclsupset.selectlocalbill);
                    dataGridView1.DataSource = this.lclsupset.selectlocalbill;
                    dataGridView2.DataSource = null;
                    MessageBox.Show("Rows Inserted");
                }
                else { MessageBox.Show("Row Insertion Failed"); }
            }
            else
            {
                MessageBox.Show("Please all the fields First \n\r " + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int InsertDataInBill()
        {
            int rows = 0;
            BillNumber = int.Parse(txtBillNumberstlc.Text.Trim());
            PartyName = txtMsstlc.Text.Trim();
            BillDate = DateTime.Parse(dateEditstlc.Text.Trim());
            Ttlamount = Decimal.Parse(calcTotalAmount.Text.Trim());


            try
            {
               

                rows = this.selectlocalbillTableAdapter.Insert(BillNumber, PartyName, BillDate, Ttlamount);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            return rows;
        }
        private int InsertBillDet()
        {
            int rows = 0;
            InitializeRow1();
            rows += this.selectlocaldetTableAdapter1.Insert(DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow2();
            rows += this.selectlocaldetTableAdapter1.Insert(DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow3();
            rows += this.selectlocaldetTableAdapter1.Insert(DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow4();
            rows += this.selectlocaldetTableAdapter1.Insert(DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow5();
            rows += this.selectlocaldetTableAdapter1.Insert(DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow6();
            rows += this.selectlocaldetTableAdapter1.Insert(DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow7();
            rows += this.selectlocaldetTableAdapter1.Insert(DetBillDate, Truckno, From, To, Commodities, Weight, Money);

            return rows;
        }
        private bool CheckAllFields(ref string str)
        {
            ArrayList list = new ArrayList();
            bool retVal = true;
            if (ValidationClass.IsTextEditEmpty(txtBillNumberstlc))
            {
                list.Add(true);
                str += "* Bill Number Cannot Be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsTextBoxEmpty(txtMsstlc))
            {
                list.Add(true);
                str += "* M/s Fields Cannot be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsDateEditEmpty(dateEditstlc))
            {
                list.Add(true);
                str += "* Date Field Cannot be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            if (ValidationClass.IsCalcEditEmpty(calcTotalAmount))
            {
                list.Add(true);
                str += "* Total Amount Cannot be Empty \n\r";
            }
            else
            {
                list.Add(false);
            }
            IEnumerator en = list.GetEnumerator();
            while (en.MoveNext())
            {
                if ((bool)en.Current == true)
                {
                    retVal = false;
                }
            }
            return retVal;

        }
        #endregion

        #region Initialize row Functions

        private void InitializeRow7()
        {
            DetBillDate = DateTime.Parse(dtcol0Row6.Text.Trim() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol0Row6.Text.Trim());
            Truckno = cmbTruckCol1Row6.Text.Trim();
            From = cmbFromCol2Row6.Text.Trim();
            To = cmbToCol3Row6.Text.Trim();
            Commodities = cmbCommodCol4Row6.Text.Trim();
            Weight = decimal.Parse(cmbWeightCol5Row6.Text.Trim() != String.Empty ? cmbWeightCol5Row6.Text.Trim() : "0");
            Money = decimal.Parse(txtAmountCol6Row6.Text.Trim() != String.Empty ? txtAmountCol6Row6.Text.Trim() : "0");
        }

        private void InitializeRow6()
        {
            DetBillDate = DateTime.Parse(dtcol0Row5.Text.Trim() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol0Row5.Text.Trim());
            Truckno = cmbTruckCol1Row5.Text.Trim();
            From = cmbFromCol2Row5.Text.Trim();
            To = cmbToCol3Row5.Text.Trim();
            Commodities = cmbCommodCol4Row5.Text.Trim();
            Weight = decimal.Parse(cmbWeightCol5Row5.Text.Trim() != String.Empty ? cmbWeightCol5Row5.Text.Trim() : "0");
            Money = decimal.Parse(txtAmountCol6Row5.Text.Trim() != String.Empty ? txtAmountCol6Row5.Text.Trim() : "0");

        }

        private void InitializeRow5()
        {
            DetBillDate = DateTime.Parse(dtcol0Row4.Text.Trim() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol0Row4.Text.Trim());
            Truckno = cmbTruckCol1Row4.Text.Trim();
            From = cmbFromCol2Row4.Text.Trim();
            To = cmbToCol3Row4.Text.Trim();
            Commodities = cmbCommodCol4Row4.Text.Trim();
            Weight = decimal.Parse(cmbWeightCol5Row4.Text.Trim() != String.Empty ? cmbWeightCol5Row4.Text.Trim() : "0");
            Money = decimal.Parse(txtAmountCol6Row4.Text.Trim() != String.Empty ? txtAmountCol6Row4.Text.Trim() : "0");
        }

        private void InitializeRow4()
        {
            DetBillDate = DateTime.Parse(dtcol0Row3.Text.Trim() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol0Row3.Text.Trim());
            Truckno = cmbTruckCol1Row3.Text.Trim();
            From = cmbFromCol2Row3.Text.Trim();
            To = cmbToCol3Row3.Text.Trim();
            Commodities = cmbCommodCol4Row3.Text.Trim();
            Weight = decimal.Parse(cmbWeightCol5Row3.Text.Trim() != String.Empty ? cmbWeightCol5Row3.Text.Trim() : "0");
            Money = decimal.Parse(txtAmountCol6Row3.Text.Trim() != String.Empty ? txtAmountCol6Row3.Text.Trim() : "0");
        }

        private void InitializeRow3()
        {
            DetBillDate = DateTime.Parse(dtcol0Row2.Text.Trim() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol0Row2.Text.Trim());
            Truckno = cmbTruckCol1Row2.Text.Trim();
            From = cmbFromCol2Row2.Text.Trim();
            To = cmbToCol3Row2.Text.Trim();
            Commodities = cmbCommodCol4Row2.Text.Trim();
            Weight = decimal.Parse(cmbWeightCol5Row2.Text.Trim() != String.Empty ? cmbWeightCol5Row2.Text.Trim() : "0");
            Money = decimal.Parse(txtAmountCol6Row2.Text.Trim() != String.Empty ? txtAmountCol6Row2.Text.Trim() : "0");
        }

        private void InitializeRow2()
        {
            DetBillDate = DateTime.Parse(dtcol0Row1.Text.Trim() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol0Row1.Text.Trim());
            Truckno = cmbTruckCol1Row1.Text.Trim();
            From = cmbFromCol2Row1.Text.Trim();
            To = cmbToCol3Row1.Text.Trim();
            Commodities = cmbCommodCol4Row1.Text.Trim();
            Weight = decimal.Parse(cmbWeightCol5Row1.Text.Trim() != String.Empty ? cmbWeightCol5Row1.Text.Trim() : "0");
            Money = decimal.Parse(txtAmountCol6Row1.Text.Trim() != String.Empty ? txtAmountCol6Row1.Text.Trim() : "0");
        }

        private void InitializeRow1()
        {
            DetBillDate = DateTime.Parse(dtcol0Row0.Text.Trim() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol0Row0.Text.Trim());
            Truckno = cmbTruckCol1Row0.Text.Trim();
            From = cmbFromCol2Row0.Text.Trim();
            To = cmbToCol3Row0.Text.Trim();
            Commodities = cmbCommodCol4Row0.Text.Trim();
            Weight = decimal.Parse(cmbWeightCol5Row0.Text.Trim() != String.Empty ? cmbWeightCol5Row0.Text.Trim() : "0");
            Money = decimal.Parse(txtAmountCol6Row0.Text.Trim() != String.Empty ? txtAmountCol6Row0.Text.Trim() : "0");
        }
        int[] billId = new int[7];

        public int BillId0
        {
            get
            {
                return billId[0];
            }
            set
            {
                billId[0] = value;
            }
        }
        public int BillId1
        {
            get
            {
                return billId[1];
            }
            set
            {
                billId[1] = value;
            }
        }
        public int BillId2
        {
            get
            {
                return billId[2];
            }
            set
            {
                billId[2] = value;
            }
        }
        public int BillId3
        {
            get
            {
                return billId[3];
            }
            set
            {
                billId[3] = value;
            }
        }
        public int BillId4
        {
            get
            {
                return billId[4];
            }
            set
            {
                billId[4] = value;
            }
        }
        public int BillId5
        {
            get
            {
                return billId[5];
            }
            set
            {
                billId[5] = value;
            }
        }
        public int BillId6
        {
            get
            {
                return billId[6];
            }
            set
            {
                billId[6] = value;
            }
        }
        #endregion

        #region Radion Button Events

        private void radioInsertstlc_Click(object sender, EventArgs e)
        {
            ClearFieldsAll();

        }

        private void radioInsertstlc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInsertstlc.Checked.Equals(true))
            {
                btnUpdate.Enabled = false;
                btnEnter.Enabled = true;
                btnDelete.Enabled = false;
                btnClear.Enabled = true;
                txtBillNumberstlc.Enabled = true;
                txtBillNumberstlc.Text = String.Empty;
            }
        }

        private void radioUpdatestlc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdatestlc.Checked.Equals(true))
            {
                btnUpdate.Enabled = true;
                btnEnter.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                txtBillNumberstlc.Enabled = false;
            }
        }

        private void radioDeletestlc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDeletestlc.Checked.Equals(true))
            {
                btnUpdate.Enabled = false;
                btnEnter.Enabled = false;
                btnDelete.Enabled = true;
                btnClear.Enabled = true;
                txtBillNumberstlc.Enabled = true;
                ClearFieldsAll();
            }
        }
        #endregion

        #region Update Function
        private int UpdateDetBill()
        {
            InitializeRow1();
            int retVal = this.selectlocaldetTableAdapter1.Update(BillId0, DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow2();
            retVal += this.selectlocaldetTableAdapter1.Update(BillId1, DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow3();
            retVal += this.selectlocaldetTableAdapter1.Update(BillId2, DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow4();
            retVal += this.selectlocaldetTableAdapter1.Update(BillId3, DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow5();
            retVal += this.selectlocaldetTableAdapter1.Update(BillId4, DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow6();
            retVal += this.selectlocaldetTableAdapter1.Update(BillId5, DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            InitializeRow7();
            retVal += this.selectlocaldetTableAdapter1.Update(BillId6, DetBillDate, Truckno, From, To, Commodities, Weight, Money);
            return retVal;
        }

        private int UpdateMainBill()
        {
            int retVal = 0;
            string message = String.Empty;
            if (CheckAllFields(ref message))
            {
                BillNumber = int.Parse(txtBillNumberstlc.Text.Trim());
                PartyName = txtMsstlc.Text.Trim();
                BillDate = DateTime.Parse(dateEditstlc.Text.Trim());
                Ttlamount = Decimal.Parse(calcTotalAmount.Text.Trim());

                retVal = this.selectlocalbillTableAdapter.Update(MainBillId, BillNumber, PartyName, BillDate, Ttlamount);
            }
            else
            {
                MessageBox.Show("Please Select The Bill Frist" + message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retVal;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!dateEditstlc.Text.Equals(String.Empty) & (txtBillNumberstlc.Text == String.Empty & txtMsstlc.Text == String.Empty))
            {
                this.selectlocalbillTableAdapter.FillBylclBillDate(lclsupset.selectlocalbill, DateTime.Parse(dateEditstlc.Text));
                dataGridView1.DataSource = lclsupset.selectlocalbill;
                dataGridView2.DataSource = null;
            }
            if (!txtBillNumberstlc.Text.Equals(String.Empty) & (txtMsstlc.Text.Equals(String.Empty) & txtMsstlc.Text.Equals(String.Empty)))
            {
                this.selectlocalbillTableAdapter.FillByLocalBillId(lclsupset.selectlocalbill, int.Parse(txtBillNumberstlc.Text.Trim()));
                dataGridView1.DataSource = lclsupset.selectlocalbill;
                dataGridView2.DataSource = null;
            }
            if (!txtMsstlc.Text.Equals(String.Empty) & (txtBillNumberstlc.Text.Equals(String.Empty) & dateEditstlc.Text.Equals(String.Empty)))
            {
                this.selectlocalbillTableAdapter.FillBylclName(lclsupset.selectlocalbill, txtMsstlc.Text);
                dataGridView1.DataSource = lclsupset.selectlocalbill;
                dataGridView2.DataSource = null;
            }
            if (!(txtBillNumberstlc.Text.Equals(String.Empty) & txtMsstlc.Text.Equals(String.Empty)) & dateEditstlc.Text.Equals(String.Empty))
            {
                this.selectlocalbillTableAdapter.FillBylclBillIDAndName(lclsupset.selectlocalbill, int.Parse(txtBillNumberstlc.Text.Trim()), txtMsstlc.Text.Trim());
            }
            if (!(txtBillNumberstlc.Text.Equals(String.Empty) & dateEditstlc.Text.Equals(String.Empty)) & txtMsstlc.Text.Equals(String.Empty))
            {
                this.selectlocalbillTableAdapter.FillBylclBillIdAndBillDate(lclsupset.selectlocalbill, int.Parse(txtBillNumberstlc.Text.Trim()), DateTime.Parse(dateEditstlc.Text));
            }
            if (!(txtMsstlc.Text.Equals(String.Empty) & dateEditstlc.Text.Equals(String.Empty)) & txtBillNumberstlc.Text.Equals(String.Empty))
            {
                this.selectlocalbillTableAdapter.FillBylclNameAndDate(lclsupset.selectlocalbill, txtMsstlc.Text, DateTime.Parse(dateEditstlc.Text));

            }
            if (!txtMsstlc.Text.Equals(String.Empty) & !dateEditstlc.Text.Equals(String.Empty) & !txtBillNumberstlc.Text.Equals(String.Empty))
            {
                this.selectlocalbillTableAdapter.FillBylclBillIdNameAndDate(lclsupset.selectlocalbill, int.Parse(txtBillNumberstlc.Text), txtMsstlc.Text, DateTime.Parse(dateEditstlc.Text));

            }
        }

        #region Caluclation Events
        private void CalCulateTotalAmount_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;

            if (txt.Name.Equals("txtAmountCol6Row0"))
            {
                FillTotalAmount0(txt);
            }
            if (txt.Name.Equals("txtAmountCol6Row1"))
            {
                FillTotalAmount1(txt);
            }
            if (txt.Name.Equals("txtAmountCol6Row2"))
            {
                FillTotalAmount2(txt);
            }
            if (txt.Name.Equals("txtAmountCol6Row3"))
            {
                FillTotalAmount3(txt);
            }
            if (txt.Name.Equals("txtAmountCol6Row4"))
            {
                FillTotalAmount4(txt);
            } if (txt.Name.Equals("txtAmountCol6Row5"))
            {
                FillTotalAmount5(txt);
            } if (txt.Name.Equals("txtAmountCol6Row6"))
            {
                FillTotalAmount6(txt);
            }
            
        }
        
        public string AddTotalAmount(TextEdit txt, params TextEdit [] val)
        {
            decimal first = decimal.Parse(txt.Text);
            decimal total = 0;
            foreach (TextEdit var in val)
            {
                total += decimal.Parse(var.Text);
            }
            total += first;
            return total.ToString();
        }
        
        private void FillTotalAmount6(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !(ValidationClass.IsTextEditEmpty(txtAmountCol6Row0) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row1) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row2) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row3) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row4) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row5)))
            {
                
                calcTotalAmount.Text = AddTotalAmount(txt, txtAmountCol6Row0, txtAmountCol6Row1, txtAmountCol6Row2, txtAmountCol6Row3, txtAmountCol6Row4, txtAmountCol6Row5);
            }

        }

        private void FillTotalAmount5(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !(ValidationClass.IsTextEditEmpty(txtAmountCol6Row0) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row1) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row2) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row3) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row4)))
            {
                calcTotalAmount.Text = AddTotalAmount(txt, txtAmountCol6Row0, txtAmountCol6Row1, txtAmountCol6Row2, txtAmountCol6Row3, txtAmountCol6Row4);
            }

        }

        private void FillTotalAmount4(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !(ValidationClass.IsTextEditEmpty(txtAmountCol6Row0) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row1) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row2) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row3)))
            {
                calcTotalAmount.Text = AddTotalAmount(txt, txtAmountCol6Row0, txtAmountCol6Row1, txtAmountCol6Row2, txtAmountCol6Row3);
            }
        }

        private void FillTotalAmount3(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !(ValidationClass.IsTextEditEmpty(txtAmountCol6Row0) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row1) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row2)))
            {
                calcTotalAmount.Text = AddTotalAmount(txt, txtAmountCol6Row0, txtAmountCol6Row1, txtAmountCol6Row2);
            }
        }

        private void FillTotalAmount2(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !(ValidationClass.IsTextEditEmpty(txtAmountCol6Row0) & ValidationClass.IsTextEditEmpty(txtAmountCol6Row1)))
            {
                calcTotalAmount.Text = AddTotalAmount(txt, txtAmountCol6Row0, txtAmountCol6Row1);
            }
        }

        private void FillTotalAmount1(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol6Row0))
            {
                calcTotalAmount.Text = AddTotalAmount(txt);
            }
        }

        private void FillTotalAmount0(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt))
            {
                calcTotalAmount.Text = txt.Text;
            }
        }
        #endregion

        private void checkshowAllbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowAllbox.Checked == true)
            {
                this.selectlocalbillTableAdapter.FillBylclSelectall(lclsupset.selectlocalbill);
            }
            else
            {
                this.selectlocalbillTableAdapter.Fill(lclsupset.selectlocalbill);
                dataGridView2.Refresh();
            }

        }
    }
}