using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraEditors;

namespace SupremeTransport
{
    // TODO: zahid_bill (changes)

    // TODO: 1) Add Controls to the UI
    // TODO: 2) Do validation of textbox fields
    // TODO: 3) Add columns to database
    // TODO: 4) Alter the procedure dbo.insert and dbo.updatemainbill
    // TODO: 5) Edit Insert Update Parameter in code
    // TODO: 6) Edit Code to Clear Text of newly add controls
    // TODO: 7) Write code to automatically fill total bags fields and total tonew fields 
    public partial class zahid_mainBill : Form
    {
        public zahid_mainBill()
        {
            InitializeComponent();
            //InsertDataInBill();
        }


        #region Form Events

        private void Supreme_Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zmaindataset.zmainbill' table. You can move, or remove it, as needed.
            this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            // TODO: This line of code loads data into the 'zmaindataset.zbill' table. You can move, or remove it, as needed.
            // this.zbillTableAdapter.Fill(this.zmaindataset.zbill);
            // TODO: This line of code loads data into the 'zmaindataset.zmainbill' table. You can move, or remove it, as needed.

            //this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            //this.billTableAdapter.Fill(this.maindataset.bill);
            //this.billBindingSource.DataMember = "bill";
            //this.billBindingSource.DataSource = this.maindataset.Tables[1].Select("mnbillid = 100");

        }

        #endregion

        #region Radio Button Events
        private void radioInsertstlc_Click(object sender, EventArgs e)
        {
            ClearMainFields();
            ClearRow1();
            ClearRow2();
            ClearRow3();
            ClearRow4();
            ClearRow5();
            ClearRow6();
            ClearRow7();
            ClearRow8();
        }
        private void radioInsertstlc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInsertstlc.Checked.Equals(true))
            {
                btnUpdate.Enabled = false;
                btnEnter.Enabled = true;
                btnDelete.Enabled = false;
            }
        }

        private void radioDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDelete.Checked.Equals(true))
            {
                btnUpdate.Enabled = false;
                btnEnter.Enabled = false;
                btnDelete.Enabled = true;
            }
        }

        private void radioUpdatestlc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUpdatestlc.Checked.Equals(true))
            {
                btnUpdate.Enabled = true;
                btnEnter.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        #endregion

        #region DataGridView1 Events

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPartyName.Text = dataGridView1.CurrentRow.Cells["partyNameDataGridViewTextBoxColumn"].Value.ToString().ToUpper();

            txtDebitBillNo.Text = dataGridView1.CurrentRow.Cells["debitBillNoDataGridViewTextBoxColumn"].Value.ToString();

            txtStation.Text = dataGridView1.CurrentRow.Cells["stationDataGridViewTextBoxColumn"].Value.ToString();

            dtBilMain.Text = DateTime.Parse(dataGridView1.CurrentRow.Cells["billdateDataGridViewTextBoxColumn1"].Value.ToString()).ToShortDateString();

            txtServiceCharge.Text = FormatMoneyValue(dataGridView1.CurrentRow.Cells["serviceChargeDataGridViewTextBoxColumn"].Value.ToString());

            txtSurcharge.Text = FormatMoneyValue(dataGridView1.CurrentRow.Cells["surchargeDataGridViewTextBoxColumn"].Value.ToString());

            txtSecondarytx.Text = FormatMoneyValue(dataGridView1.CurrentRow.Cells["hsServiceChargeDataGridViewTextBoxColumn"].Value.ToString());

            txtTotalTx.Text = FormatMoneyValue(dataGridView1.CurrentRow.Cells["taxDataGridViewTextBoxColumn"].Value.ToString());

            Calculator_Grand_Total.Text = FormatMoneyValue(dataGridView1.CurrentRow.Cells["totalDataGridViewTextBoxColumn"].Value.ToString());
            txtTotalInWords.Text = dataGridView1.CurrentRow.Cells["TotalInWordsDataGridViewTextBoxColumn"].Value.ToString();
            txtTotalBags.Text = dataGridView1.CurrentRow.Cells["TotalBagsDataGridViewTextBoxColumn"].Value.ToString();
            txttotalTone.Text = dataGridView1.CurrentRow.Cells["TotalTonesDataGridViewTextBoxColumn"].Value.ToString();
            MainBillId = int.Parse(dataGridView1.CurrentRow.Cells["mnbillidDataGridViewTextBoxColumn1"].Value.ToString());
            //this.zbillTableAdapter.Fill(this.zmaindataset.zbill);
            try
            {
                this.zbillTableAdapter.FillBy(this.zmaindataset.zbill, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells["mnbillIdDataGridViewTextBoxColumn1"].Value.ToString(), typeof(int))))));
            }
            catch
            {
                //this.zbillTableAdapter.FillBy(this.zmaindataset.zbill, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells["mnbillIdDataGridViewTextBoxColumn1"].Value.ToString(), typeof(int))))));

            }
            finally
            {
                this.zbillTableAdapter.FillBy(this.zmaindataset.zbill, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells["mnbillIdDataGridViewTextBoxColumn1"].Value.ToString(), typeof(int))))));

            }
            dataGridView2.DataSource = this.zmaindataset.zbill;

            FillBillTextBoxes();
            radioUpdatestlc.Checked = true;
            //    radioInsertstlc.Checked = true;
        }
        #endregion

        /// <summary>
        /// This function help to fill the textboxes when datagridview1 
        /// is cells is clicked
        /// </summary>

        private void FillBillTextBoxes()
        {
            for (int j = 0; j < 8; j++)
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
                if (j == 7)
                {
                    FillRow8(j);
                }
            }
        }

        #region Fill DataRow
        private void FillRow8(int j)
        {
            dtcol1row7.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row7.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row7.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row7.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row7.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row7.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row7.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row7.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row7.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row7.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row7.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId7 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());

        }

        private void FillRow7(int j)
        {
            dtcol1row6.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row6.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row6.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row6.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row6.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row6.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row6.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row6.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row6.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row6.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row6.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId6 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());

        }

        private void FillRow6(int j)
        {
            dtcol1row5.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row5.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row5.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row5.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row5.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row5.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row5.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row5.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row5.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row5.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row5.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId5 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow5(int j)
        {
            dtcol1row4.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row4.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row4.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row4.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row4.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row4.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row4.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row4.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row4.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row4.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row4.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId4 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow4(int j)
        {
            dtcol1row3.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row3.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row3.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row3.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row3.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row3.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row3.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row3.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row3.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row3.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row3.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId3 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow3(int j)
        {
            dtcol1row2.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row2.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row2.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row2.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row2.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row2.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row2.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row2.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row2.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row2.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row2.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId2 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void FillRow2(int j)
        {

            dtcol1row1.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row1.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row1.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row1.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row1.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row1.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row1.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row1.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row1.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row1.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row1.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId1 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());

        }

        private void FillRow1(int j)
        {
            dtcol1row0.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["billdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();

            txtChCol3Row0.Text = dataGridView2.Rows[j].Cells["chalanNumberDataGridViewTextBoxColumn"].Value.ToString();

            txtgcCol2Row0.Text = dataGridView2.Rows[j].Cells["gcnumberDataGridViewTextBoxColumn"].Value.ToString();
            txtTruckCol4Row0.Text = dataGridView2.Rows[j].Cells["truckNumberDataGridViewTextBoxColumn"].Value.ToString();
            txtGoodCol5Row0.Text = dataGridView2.Rows[j].Cells["goodsDataGridViewTextBoxColumn"].Value.ToString();
            txtBagCol6Row0.Text = dataGridView2.Rows[j].Cells["bagsDataGridViewTextBoxColumn"].Value.ToString();
            txtToneCol7Row0.Text = dataGridView2.Rows[j].Cells["toneDataGridViewTextBoxColumn"].Value.ToString();
            txtRateCol8Row0.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["rateDataGridViewTextBoxColumn"].Value.ToString());
            txtAmountCol9Row0.Text = FormatMoneyValue(dataGridView2.Rows[j].Cells["amountDataGridViewTextBoxColumn"].Value.ToString());
            dtUlDateCol10Row0.Text = DateTime.Parse(dataGridView2.Rows[j].Cells["unloadingdateDataGridViewTextBoxColumn"].Value.ToString()).ToShortDateString();
            txtExpenseCol9Row0.Text = dataGridView2.Rows[j].Cells["expenseDataGridViewTextBoxColumn"].Value.ToString();
            BillId0 = int.Parse(dataGridView2.Rows[j].Cells["billidDataGridViewTextBoxColumn"].Value.ToString());
        }

        private string FormatMoneyValue(string p)
        {
            decimal money = decimal.Parse(p);
            money = Math.Round(money);
            return money.ToString();
        }

        #endregion

        #region Main bill variables
        DateTime billDate, endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        string partyName, station, totalbags, totaltones, totalinwords;
        public string Totalbags
        {
            get { return totalbags; }
            set { totalbags = value; }
        }

        public string Totaltones
        {
            get { return totaltones; }
            set { totaltones = value; }
        }

        public string Totalinwords
        {
            get { return totalinwords; }
            set { totalinwords = value; }
        }
        int mainUserid, billNumber;
        decimal total, serviceCharge, hsServiceCharge, tax, surCharge;
        public decimal SurCharge
        {
            get { return surCharge; }
            set { surCharge = value; }
        }
        public decimal Tax
        {
            get { return tax; }
            set { tax = value; }
        }
        public decimal HsServiceCharge
        {
            get { return hsServiceCharge; }
            set { hsServiceCharge = value; }
        }
        public decimal ServiceCharge
        {
            get { return serviceCharge; }
            set { serviceCharge = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
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
        public int MainUserid
        {
            get { return mainUserid; }
            set { mainUserid = value; }
        }
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
        #endregion

        #region bill variables
        string gcNumber, chalanNumber, truckNumber, tatabill, goods, bags, tone;
        DateTime loadingDate, unloadingDate;
        decimal rate, amount, expense;

        public decimal Expense
        {
            get { return expense; }
            set { expense = value; }
        }
        public decimal Rate
        {
            get { return rate; }
            set { rate = value.ToString() != String.Empty ? value : 0; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value.ToString() != String.Empty ? value : 0; }
        }
        public DateTime UnloadingDate
        {
            get { return unloadingDate; }
            set { unloadingDate = value.ToString() == String.Empty ? new DateTime(2010, 01, 01) : value; }
        }
        public DateTime LoadingDate
        {
            get { return loadingDate; }
            set { loadingDate = value.ToString() == String.Empty ? new DateTime(2010, 01, 01) : value; }
        }
        public string Tatabill
        {
            get { return tatabill; }
            set { tatabill = value != String.Empty ? value : "N.A"; }
        }
        public string Tone
        {
            get { return tone; }
            set { tone = value != String.Empty ? value : "0"; }
        }
        public string Bags
        {
            get { return bags; }
            set { bags = value != String.Empty ? value : "N.A"; }
        }
        public string Goods
        {
            get { return goods; }
            set { goods = value != String.Empty ? value : "N.A"; }
        }
        public string TruckNumber
        {
            get { return truckNumber; }
            set { truckNumber = value != String.Empty ? value : "N.A"; }
        }
        public string ChalanNumber
        {
            get { return chalanNumber; }
            set { chalanNumber = value != String.Empty ? value : "N.A"; }
        }
        public string GcNumber
        {
            get { return gcNumber; }
            set { gcNumber = value != String.Empty ? value : "N.A"; }
        }

        #endregion

        #region Insertion details

        private int InsertDataInMainBill()
        {
            int rows = 0;
            BillDate = DateTime.Parse(dtBilMain.Text);
            PartyName = txtPartyName.Text.ToString().Trim();
            BillNumber = int.Parse(txtDebitBillNo.Text.Trim());
            MainUserid = UserLogin.UserId;
            Station = txtStation.Text.Trim();
            Total = decimal.Parse(Calculator_Grand_Total.Text.ToString());
            ServiceCharge = decimal.Parse(txtServiceCharge.Text);
            HsServiceCharge = decimal.Parse(txtSecondarytx.Text);
            Tax = decimal.Parse(txtTotalTx.Text);
            SurCharge = decimal.Parse(txtSurcharge.Text);
            EndDate = AddToEndDate(BillDate);
            Totalinwords = txtTotalInWords.Text.Trim();
            Totaltones = txttotalTone.Text.Trim();
            Totalbags = txtTotalBags.Text.Trim();
            try
            {
                rows = this.zmainbillTableAdapter.Insert(UserLogin.UserId, 0, BillNumber, BillDate, PartyName, Station, Total, ServiceCharge, SurCharge, HsServiceCharge, Tax, null, null, null, EndDate, Totalinwords, Totalbags, Totaltones);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            catch (DataException daException)
            {
                MessageBox.Show(daException.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
            return rows;
        }

        private DateTime AddToEndDate(DateTime BillDate)
        {
            DateTime dt = BillDate;
            dt = dt.AddDays(45);
            return dt;
        }

        private int InsertDataInBill()
        {
            int billid = 0;
            //SqlBillId.getBillID(out billid);

            //Initializing 1st row
            InitializeRow1();
            int rows = this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);
            //Initializing 2nd row
            InitializeRow2();

            rows += this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);
            //Initializing third row
            InitializeRow3();

            rows += this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow4();

            rows += this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow5();

            rows += this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow6();

            rows += this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow7();

            rows += this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            //initializing 8th rows

            InitializeRow8();
            rows += this.zbillTableAdapter.Insert(billid, 100, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            return rows;
        }

        #endregion

        #region Initializing rows for insertion
        private void InitializeRow8()
        {
            LoadingDate = DateTime.Parse(dtcol1row7.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row7.Text);
            GcNumber = txtgcCol2Row7.Text.Trim();
            ChalanNumber = txtChCol3Row7.Text.Trim();
            TruckNumber = txtTruckCol4Row7.Text.Trim();
            Goods = txtGoodCol5Row7.Text.Trim();
            Bags = txtBagCol6Row7.Text.Trim();
            Tone = txtToneCol7Row7.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row7.Text == String.Empty ? "0" : txtRateCol8Row7.Text);
            Amount = decimal.Parse(txtAmountCol9Row7.Text == String.Empty ? "0" : txtAmountCol9Row7.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row7.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row7.Text);
            Expense = decimal.Parse(txtExpenseCol9Row7.Text == String.Empty ? "0" : txtExpenseCol9Row7.Text.Trim());

        }

        private void InitializeRow7()
        {
            LoadingDate = DateTime.Parse(dtcol1row6.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row6.Text);
            GcNumber = txtgcCol2Row6.Text.Trim();
            ChalanNumber = txtChCol3Row6.Text.Trim();
            TruckNumber = txtTruckCol4Row6.Text.Trim();
            Goods = txtGoodCol5Row6.Text.Trim();
            Bags = txtBagCol6Row6.Text.Trim();
            Tone = txtToneCol7Row6.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row6.Text == String.Empty ? "0" : txtRateCol8Row6.Text);
            Amount = decimal.Parse(txtAmountCol9Row6.Text == String.Empty ? "0" : txtAmountCol9Row6.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row6.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row6.Text);
            Expense = decimal.Parse(txtExpenseCol9Row6.Text == String.Empty ? "0" : txtExpenseCol9Row6.Text.Trim());

        }

        private void InitializeRow6()
        {
            LoadingDate = DateTime.Parse(dtcol1row5.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row5.Text);
            GcNumber = txtgcCol2Row5.Text.Trim();
            ChalanNumber = txtChCol3Row5.Text.Trim();
            TruckNumber = txtTruckCol4Row5.Text.Trim();
            Goods = txtGoodCol5Row5.Text.Trim();
            Bags = txtBagCol6Row5.Text.Trim();
            Tone = txtToneCol7Row5.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row5.Text == String.Empty ? "0" : txtRateCol8Row5.Text);
            Amount = decimal.Parse(txtAmountCol9Row5.Text == String.Empty ? "0" : txtAmountCol9Row5.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row5.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row5.Text);
            Expense = decimal.Parse(txtExpenseCol9Row5.Text == String.Empty ? "0" : txtExpenseCol9Row5.Text.Trim());

        }

        private void InitializeRow5()
        {
            LoadingDate = DateTime.Parse(dtcol1row4.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row4.Text);
            GcNumber = txtgcCol2Row4.Text.Trim();
            ChalanNumber = txtChCol3Row4.Text.Trim();
            TruckNumber = txtTruckCol4Row4.Text.Trim();
            Goods = txtGoodCol5Row4.Text.Trim();
            Bags = txtBagCol6Row4.Text.Trim();
            Tone = txtToneCol7Row4.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row4.Text == String.Empty ? "0" : txtRateCol8Row4.Text);
            Amount = decimal.Parse(txtAmountCol9Row4.Text == String.Empty ? "0" : txtAmountCol9Row4.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row4.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row4.Text);
            Expense = decimal.Parse(txtExpenseCol9Row4.Text == String.Empty ? "0" : txtExpenseCol9Row4.Text.Trim());

        }

        private void InitializeRow4()
        {
            LoadingDate = DateTime.Parse(dtcol1row3.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row3.Text);
            GcNumber = txtgcCol2Row3.Text.Trim();
            ChalanNumber = txtChCol3Row3.Text.Trim();
            TruckNumber = txtTruckCol4Row3.Text.Trim();
            Goods = txtGoodCol5Row3.Text.Trim();
            Bags = txtBagCol6Row3.Text.Trim();
            Tone = txtToneCol7Row3.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row3.Text == String.Empty ? "0" : txtRateCol8Row3.Text);
            Amount = decimal.Parse(txtAmountCol9Row3.Text == String.Empty ? "0" : txtAmountCol9Row3.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row3.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row3.Text);
            Expense = decimal.Parse(txtExpenseCol9Row3.Text == String.Empty ? "0" : txtExpenseCol9Row3.Text.Trim());

        }

        private void InitializeRow3()
        {
            LoadingDate = DateTime.Parse(dtcol1row2.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row2.Text);
            GcNumber = txtgcCol2Row2.Text.Trim();
            ChalanNumber = txtChCol3Row2.Text.Trim();
            TruckNumber = txtTruckCol4Row2.Text.Trim();
            Goods = txtGoodCol5Row2.Text.Trim();
            Bags = txtBagCol6Row2.Text.Trim();
            Tone = txtToneCol7Row2.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row2.Text == String.Empty ? "0" : txtRateCol8Row2.Text);
            Amount = decimal.Parse(txtAmountCol9Row2.Text == String.Empty ? "0" : txtAmountCol9Row2.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row2.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row2.Text);
            Expense = decimal.Parse(txtExpenseCol9Row2.Text == String.Empty ? "0" : txtExpenseCol9Row2.Text.Trim());

        }

        private void InitializeRow2()
        {
            LoadingDate = DateTime.Parse(dtcol1row1.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row1.Text);
            GcNumber = txtgcCol2Row1.Text.Trim();
            ChalanNumber = txtChCol3Row1.Text.Trim();
            TruckNumber = txtTruckCol4Row1.Text.Trim();
            Goods = txtGoodCol5Row1.Text.Trim();
            Bags = txtBagCol6Row1.Text.Trim();
            Tone = txtToneCol7Row1.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row1.Text == String.Empty ? "0" : txtRateCol8Row1.Text);
            Amount = decimal.Parse(txtAmountCol9Row1.Text == String.Empty ? "0" : txtAmountCol9Row1.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row1.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row1.Text);
            Expense = decimal.Parse(txtExpenseCol9Row1.Text == String.Empty ? "0" : txtExpenseCol9Row1.Text.Trim());


        }

        private void InitializeRow1()
        {
            LoadingDate = DateTime.Parse(dtcol1row0.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtcol1row0.Text);
            GcNumber = txtgcCol2Row0.Text.Trim();
            ChalanNumber = txtChCol3Row0.Text.Trim();
            TruckNumber = txtTruckCol4Row0.Text.Trim();
            Goods = txtGoodCol5Row0.Text.Trim();
            Bags = txtBagCol6Row0.Text.Trim();
            Tone = txtToneCol7Row0.Text.Trim();
            Rate = decimal.Parse(txtRateCol8Row0.Text == String.Empty ? "0" : txtRateCol8Row0.Text);
            Amount = decimal.Parse(txtAmountCol9Row0.Text == String.Empty ? "0" : txtAmountCol9Row0.Text);
            UnloadingDate = DateTime.Parse(dtUlDateCol10Row0.Text == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtUlDateCol10Row0.Text);
            Expense = decimal.Parse(txtExpenseCol9Row0.Text == String.Empty ? "0" : txtExpenseCol9Row0.Text.Trim());
        }
        #endregion

        #region Clear Fields

        private void ClearMainFields()
        {
            txtPartyName.Text = "";
            txtDebitBillNo.Text = "";
            txtStation.Text = "";
            dtBilMain.Text = "";
            txtServiceCharge.Text = "";
            txtSurcharge.Text = "";
            txtSecondarytx.Text = "";
            txtTotalTx.Text = "";
            Calculator_Grand_Total.Text = "";
            txttotalTone.Text = string.Empty;
            txtTotalBags.Text = string.Empty;
            txtTotalInWords.Text = string.Empty;

        }

        private void ClearRow4()
        {
            dtcol1row3.Text = "";
            txtChCol3Row3.Text = "";
            txtgcCol2Row3.Text = "";
            txtTruckCol4Row3.Text = "";
            txtGoodCol5Row3.Text = "";
            txtBagCol6Row3.Text = "";
            txtToneCol7Row3.Text = "";
            txtRateCol8Row3.Text = "";
            txtAmountCol9Row3.Text = "";
            dtUlDateCol10Row3.Text = "";
            txtExpenseCol9Row3.Text = "";

        }

        private void ClearRow3()
        {
            dtcol1row2.Text = "";
            txtChCol3Row2.Text = "";
            txtgcCol2Row2.Text = "";
            txtTruckCol4Row2.Text = "";
            txtGoodCol5Row2.Text = "";
            txtBagCol6Row2.Text = "";
            txtToneCol7Row2.Text = "";
            txtRateCol8Row2.Text = "";
            txtAmountCol9Row2.Text = "";
            dtUlDateCol10Row2.Text = "";
            txtExpenseCol9Row2.Text = "";

        }

        private void ClearRow5()
        {
            dtcol1row4.Text = "";
            txtChCol3Row4.Text = "";
            txtgcCol2Row4.Text = "";
            txtTruckCol4Row4.Text = "";
            txtGoodCol5Row4.Text = "";
            txtBagCol6Row4.Text = "";
            txtToneCol7Row4.Text = "";
            txtRateCol8Row4.Text = "";
            txtAmountCol9Row4.Text = "";
            dtUlDateCol10Row4.Text = "";
            txtExpenseCol9Row4.Text = "";

        }

        private void ClearRow6()
        {
            dtcol1row5.Text = "";
            txtChCol3Row5.Text = "";
            txtgcCol2Row5.Text = "";
            txtTruckCol4Row5.Text = "";
            txtGoodCol5Row5.Text = "";
            txtBagCol6Row5.Text = "";
            txtToneCol7Row5.Text = "";
            txtRateCol8Row5.Text = "";
            txtAmountCol9Row5.Text = "";
            dtUlDateCol10Row5.Text = "";
            txtExpenseCol9Row5.Text = "";

        }

        private void ClearRow7()
        {
            dtcol1row6.Text = "";
            txtChCol3Row6.Text = "";
            txtgcCol2Row6.Text = "";
            txtTruckCol4Row6.Text = "";
            txtGoodCol5Row6.Text = "";
            txtBagCol6Row6.Text = "";
            txtToneCol7Row6.Text = "";
            txtRateCol8Row6.Text = "";
            txtAmountCol9Row6.Text = "";
            dtUlDateCol10Row6.Text = "";
            txtExpenseCol9Row6.Text = "";

        }

        private void ClearRow8()
        {
            dtcol1row7.Text = "";
            txtChCol3Row7.Text = "";
            txtgcCol2Row7.Text = "";
            txtTruckCol4Row7.Text = "";
            txtGoodCol5Row7.Text = "";
            txtBagCol6Row7.Text = "";
            txtToneCol7Row7.Text = "";
            txtRateCol8Row7.Text = "";
            txtAmountCol9Row7.Text = "";
            dtUlDateCol10Row7.Text = "";
            txtExpenseCol9Row7.Text = "";

        }

        private void ClearRow1()
        {
            dtcol1row0.Text = "";
            txtChCol3Row0.Text = "";
            txtgcCol2Row0.Text = "";
            txtTruckCol4Row0.Text = "";
            txtGoodCol5Row0.Text = "";
            txtBagCol6Row0.Text = "";
            txtToneCol7Row0.Text = "";
            txtRateCol8Row0.Text = "";
            txtAmountCol9Row0.Text = "";
            dtUlDateCol10Row0.Text = "";
            txtExpenseCol9Row0.Text = "";
        }
        private void ClearRow2()
        {
            dtcol1row1.Text = "";
            txtChCol3Row1.Text = "";
            txtgcCol2Row1.Text = "";
            txtTruckCol4Row1.Text = "";
            txtGoodCol5Row1.Text = "";
            txtBagCol6Row1.Text = "";
            txtToneCol7Row1.Text = "";
            txtRateCol8Row1.Text = "";
            txtAmountCol9Row1.Text = "";
            dtUlDateCol10Row1.Text = "";
            txtExpenseCol9Row1.Text = "";
        }
        #endregion

        #region Button Click Events
        /// <summary>
        /// Button Enter For Inserting data into data fields
        /// helps you insert data and is called by btnEnter Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //int mnrowsaffected = this.zmainbillTableAdapter.Insert(100, 100, 615, DateTime.Now, "Tata chemical ltd", "taluja", 34770, 8518, 170, 85, 8773, null, null, null);
            //int rowaffected = this.billTableAdapter.Insert(0, 100, new DateTime(2009, 01, 06), "43839", "33387", "GJIAZ-8346", "SAD", "27", "26", 1662, 43212, new DateTime(2010, 01, 10), "310010677");
            int mnrowsaffected = 0;
            string message = string.Empty;
            if (CheckMainFields(ref message))
            {
                try
                {
                    mnrowsaffected = InsertDataInMainBill();
                    mnrowsaffected += InsertDataInBill();
                    if (mnrowsaffected != 0)
                    {
                        MessageBox.Show("Bill Inserted Into Database");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
                    dataGridView1.DataSource = this.zmaindataset.zmainbill;
                }
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckMainFields(ref string message)
        {
            ArrayList check = new ArrayList();
            bool retval = true;
            if (ValidationClass.IsTextBoxEmpty(txtPartyName))
            {
                message += "Party Name is Required \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsTextBoxEmpty(txtStation))
            {
                message += "Station Name is Required \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsDateEditEmpty(dtBilMain))
            {
                message += "Date is Required \n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsTextEditEmpty(txtDebitBillNo))
            {
                message += "Debit Bill Number is Required \n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsCalcEditEmpty(txtServiceCharge))
            {
                message += "Calculation of Service Charge is Required \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsCalcEditEmpty(txtSurcharge))
            {
                message += "Calculation of Surcharge is Required  \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsCalcEditEmpty(txtSecondarytx))
            {
                message += "Calculation of  Secondary Tax is Required  \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsCalcEditEmpty(txtTotalTx))
            {
                message += "Calculation of Total Tax is Required  \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsCalcEditEmpty(Calculator_Grand_Total))
            {
                message += "Calculation of Total Tax is Required  \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsTextBoxEmpty(txtTotalInWords))
            {
                message += "Total (In Words) Field Required  \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsTextEditEmpty(txttotalTone) | ValidationClass.IsTextEditZero(txttotalTone))
            {
                message += "Total Tone is Required  \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            if (ValidationClass.IsTextEditEmpty(txtTotalBags))
            {
                message += "Total Bag Field is Required  \r\n";
                check.Add(true);
            }
            else
            {
                check.Add(false);
            }
            IEnumerator ie = check.GetEnumerator();
            while (ie.MoveNext())
            {
                if ((bool)ie.Current == true)
                {
                    retval = false;
                }
            }
            return retval;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearMainFields();
            ClearRow1();
            ClearRow2();
            ClearRow3();
            ClearRow4();
            ClearRow5();
            ClearRow6();
            ClearRow7();
            ClearRow8();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            if (CheckMainFields(ref message))
            {

                int i = UpdateMainBill();
                i += UpdateBill();
                if (i != 0)
                {
                    MessageBox.Show("Bill Updated");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Update Command

        int mainBillId = 0;
        int billId0, billId1, billId2, billId3, billId4, billId5, billId6, billId7;

        public int BillId0
        {
            get { return billId0; }
            set { billId0 = value; }
        }

        public int BillId1
        {
            get { return billId1; }
            set { billId1 = value; }
        }

        public int BillId2
        {
            get { return billId2; }
            set { billId2 = value; }
        }

        public int BillId3
        {
            get { return billId3; }
            set { billId3 = value; }
        }

        public int BillId4
        {
            get { return billId4; }
            set { billId4 = value; }
        }

        public int BillId5
        {
            get { return billId5; }
            set { billId5 = value; }
        }

        public int BillId6
        {
            get { return billId6; }
            set { billId6 = value; }
        }

        public int BillId7
        {
            get { return billId7; }
            set { billId7 = value; }
        }
        public int MainBillId
        {
            get { return mainBillId; }
            set { mainBillId = value; }
        }

        private int UpdateMainBill()
        {
            int userid = UserLogin.UserId;
            int billid = 0;
            BillDate = DateTime.Parse(dtBilMain.Text);
            PartyName = txtPartyName.Text.ToString().Trim();
            BillNumber = int.Parse(txtDebitBillNo.Text.Trim());
            MainUserid = 1001;
            Station = txtStation.Text.Trim();
            Total = decimal.Parse(Calculator_Grand_Total.Text.ToString());
            ServiceCharge = decimal.Parse(txtServiceCharge.Text);
            HsServiceCharge = decimal.Parse(txtSecondarytx.Text);
            Tax = decimal.Parse(txtTotalTx.Text);
            SurCharge = decimal.Parse(txtSurcharge.Text);
            Totalinwords = txtTotalInWords.Text.Trim();
            Totaltones = txttotalTone.Text.Trim();
            Totalbags = txtTotalBags.Text.Trim();

            int retVal = this.zmainbillTableAdapter.FillBy(this.zmaindataset.zmainbill, UserLogin.UserId, billid, BillNumber, BillDate, PartyName, Station, Total, ServiceCharge, SurCharge, HsServiceCharge, Tax, Totalinwords, Totalbags, Totaltones, MainBillId);

            this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
            dataGridView1.DataSource = this.zmaindataset.zmainbill;

            return retVal;
        }

        private int UpdateBill()
        {
            int userid = UserLogin.UserId;

            InitializeRow1();

            int retVal = this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId0, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow2();

            retVal += this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId1, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow3();

            retVal += this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId2, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow4();

            retVal += this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId3, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow5();

            retVal += this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId4, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow6();

            retVal += this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId5, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow7();

            retVal += this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId6, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);

            InitializeRow8();

            retVal += this.zbillTableAdapter.FillByBill(this.zmaindataset.zbill, BillId7, userid, MainBillId, LoadingDate, GcNumber, ChalanNumber, TruckNumber, Goods, Bags, Tone, Rate, Amount, UnloadingDate, Expense);


            this.zbillTableAdapter.FillBy(this.zmaindataset.zbill, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells["mnbillIdDataGridViewTextBoxColumn1"].Value.ToString(), typeof(int))))));

            dataGridView2.DataSource = this.zmaindataset.zbill;
            return retVal;
        }

        #endregion

        #region Search Commmand
        private void btnSearch_Click(object sender, EventArgs e)
        {
            PartyName = txtPartyName.Text.Trim();
            BillNumber = int.Parse(txtDebitBillNo.Text.Trim() == String.Empty ? "0" : txtDebitBillNo.Text.Trim());
            BillDate = DateTime.Parse(dtBilMain.Text.ToString() == String.Empty ? new DateTime(2010, 01, 01).ToString() : dtBilMain.Text.ToString());
            Station = txtStation.Text.Trim() != String.Empty ? txtStation.Text.Trim() : "N.A";

            if (txtPartyName.Text.Length != 0 & txtDebitBillNo.Text.Length != 0 & txtStation.Text.Length != 0 & dtBilMain.Text.Length != 0)
            {
                this.zmainbillTableAdapter.FillByMainSearch(zmaindataset.zmainbill, PartyName, Station, BillNumber, BillDate);
            }
            else if (txtPartyName.Text.Length != 0 & txtStation.Text.Length != 0)
            {
                this.zmainbillTableAdapter.FillByMainSearchPartyAndStation(zmaindataset.zmainbill, PartyName, Station);
            }
            else if (txtPartyName.Text.Length != 0 & txtStation.Text.Length != 0 & txtDebitBillNo.Text.Length != 0)
            {
                this.zmainbillTableAdapter.FillByMainSearchPartyStationAndDbno(zmaindataset.zmainbill, PartyName, Station, BillNumber);
            }
            else if (txtPartyName.Text.Length != 0)
            {
                this.zmainbillTableAdapter.FillByMainSearchPartyName(this.zmaindataset.zmainbill, PartyName);
            }
            else if (txtDebitBillNo.Text.Length != 0)
            {
                this.zmainbillTableAdapter.FillByMainSearchDebitBillNo(this.zmaindataset.zmainbill, BillNumber);
            }
            else if (dtBilMain.Text.Length != 0)
            {
                this.zmainbillTableAdapter.FillMainSearchByBillDate(this.zmaindataset.zmainbill, BillDate);
            }
            else if (txtStation.Text.Length != 0)
            {
                this.zmainbillTableAdapter.FillByMainSearchStation(this.zmaindataset.zmainbill, Station);
            }

        }
        #endregion

        #region Automatic Calculation of Values

        private void FillTaxFields(decimal total)
        {
            decimal serviceTax = ((((total * 25) / 100) * 10)) / 100;
            serviceTax = Math.Round(serviceTax);
            txtServiceCharge.Text = serviceTax.ToString();
            decimal surCharge = Math.Round((serviceTax * 2) / 100);
            txtSurcharge.Text = surCharge.ToString();
            decimal secondaryCharge = Math.Round((serviceTax * 1) / 100);
            txtSecondarytx.Text = secondaryCharge.ToString();
            decimal totalTax = (secondaryCharge + surCharge + serviceTax);
            txtTotalTx.Text = totalTax.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this entry?", "Delete Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.zmainbillTableAdapter.FillBydeleteMain(this.zmaindataset.zmainbill, mainBillId);
                if (this.zmaindataset.zmainbill != null)
                {
                    dataGridView1.DataSource = this.zmaindataset.zmainbill;
                    this.zbillTableAdapter.FillBy(this.zmaindataset.zbill, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells["mnbillIdDataGridViewTextBoxColumn1"].Value.ToString(), typeof(int))))));
                    dataGridView2.DataSource = this.zmaindataset.zbill;
                }

                ClearMainFields();
                ClearRow1();
                ClearRow2();
                ClearRow3();
                ClearRow4();
                ClearRow5();
                ClearRow6();
                ClearRow7();
                ClearRow8();
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            if (txt.Name.Equals("txtAmountCol9Row0"))
            {
                FillGrandTotalRow0(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row1"))
            {
                FillGrandTotalRow1(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row2"))
            {
                FillGrandTotalRow2(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row3"))
            {
                FillGrandTotalRow3(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row4"))
            {
                FillGrandTotalRow4(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row5"))
            {
                FillGrandTotalRow5(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row6"))
            {
                FillGrandTotalRow6(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row7"))
            {
                FillGrandTotalRow7(txt);
            }
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            TextEdit txt = sender as TextEdit;
            if (txt.Name.Equals("txtAmountCol9Row0"))
            {
                FillGrandTotalRow0(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row1"))
            {
                FillGrandTotalRow1(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row2"))
            {
                FillGrandTotalRow2(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row3"))
            {
                FillGrandTotalRow3(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row4"))
            {
                FillGrandTotalRow4(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row5"))
            {
                FillGrandTotalRow5(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row6"))
            {
                FillGrandTotalRow6(txt);
            }
            if (txt.Name.Equals("txtAmountCol9Row7"))
            {
                FillGrandTotalRow7(txt);
            }
        }

        private void FillGrandTotalRow7(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txtAmountCol9Row0) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row2) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row3) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row4) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row5) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row6) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row7))
            {
                decimal row0 = Convert.ToDecimal(txtAmountCol9Row0.Text);
                decimal row1 = Convert.ToDecimal(txtAmountCol9Row1.Text);
                decimal row2 = Convert.ToDecimal(txtAmountCol9Row2.Text);
                decimal row3 = Convert.ToDecimal(txtAmountCol9Row3.Text);
                decimal row4 = Convert.ToDecimal(txtAmountCol9Row4.Text);
                decimal row5 = Convert.ToDecimal(txtAmountCol9Row5.Text);
                decimal row6 = Convert.ToDecimal(txtAmountCol9Row6.Text);
                decimal row7 = Convert.ToDecimal(txtAmountCol9Row7.Text);

                decimal total = (row0 + row1 + row2 + row3 + row4 + row5 + row6 + row7);
                Calculator_Grand_Total.Text = Convert.ToString(total);
                FillTaxFields(total);
            }
        }

        private void FillGrandTotalRow6(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txtAmountCol9Row0) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row2) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row3) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row4) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row5) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row6))
            {
                decimal row0 = Convert.ToDecimal(txtAmountCol9Row0.Text);
                decimal row1 = Convert.ToDecimal(txtAmountCol9Row1.Text);
                decimal row2 = Convert.ToDecimal(txtAmountCol9Row2.Text);
                decimal row3 = Convert.ToDecimal(txtAmountCol9Row3.Text);
                decimal row4 = Convert.ToDecimal(txtAmountCol9Row4.Text);
                decimal row5 = Convert.ToDecimal(txtAmountCol9Row5.Text);
                decimal row6 = Convert.ToDecimal(txtAmountCol9Row6.Text);

                decimal total = (row0 + row1 + row2 + row3 + row4 + row5 + row6);
                Calculator_Grand_Total.Text = Convert.ToString(total);
                FillTaxFields(total);
            }
        }

        private void FillGrandTotalRow5(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txtAmountCol9Row0) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row2) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row3) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row4) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row4))
            {
                decimal row0 = Convert.ToDecimal(txtAmountCol9Row0.Text);
                decimal row1 = Convert.ToDecimal(txtAmountCol9Row1.Text);
                decimal row2 = Convert.ToDecimal(txtAmountCol9Row2.Text);
                decimal row3 = Convert.ToDecimal(txtAmountCol9Row3.Text);
                decimal row4 = Convert.ToDecimal(txtAmountCol9Row4.Text);
                decimal row5 = Convert.ToDecimal(txtAmountCol9Row5.Text);

                decimal total = (row0 + row1 + row2 + row3 + row4 + row5);
                Calculator_Grand_Total.Text = Convert.ToString(total);
                FillTaxFields(total);
            }
        }

        private void FillGrandTotalRow4(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txtAmountCol9Row0) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row2) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row3) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row4))
            {
                decimal row0 = Convert.ToDecimal(txtAmountCol9Row0.Text);
                decimal row1 = Convert.ToDecimal(txtAmountCol9Row1.Text);
                decimal row2 = Convert.ToDecimal(txtAmountCol9Row2.Text);
                decimal row3 = Convert.ToDecimal(txtAmountCol9Row3.Text);
                decimal row4 = Convert.ToDecimal(txtAmountCol9Row4.Text);

                decimal total = (row0 + row1 + row2 + row3 + row4);
                Calculator_Grand_Total.Text = Convert.ToString(total);
                FillTaxFields(total);
            }
        }

        private void FillGrandTotalRow3(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txtAmountCol9Row0) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row2) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row3))
            {
                decimal row0 = Convert.ToDecimal(txtAmountCol9Row0.Text);
                decimal row1 = Convert.ToDecimal(txtAmountCol9Row1.Text);
                decimal row2 = Convert.ToDecimal(txtAmountCol9Row2.Text);
                decimal row3 = Convert.ToDecimal(txtAmountCol9Row3.Text);

                decimal total = row0 + row1 + row2 + row3;
                Calculator_Grand_Total.Text = Convert.ToString(total);
                FillTaxFields(total);
            }
        }

        private void FillGrandTotalRow2(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txtAmountCol9Row0) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row2))
            {
                decimal row0 = Convert.ToDecimal(txtAmountCol9Row0.Text);
                decimal row1 = Convert.ToDecimal(txtAmountCol9Row1.Text);
                decimal row2 = Convert.ToDecimal(txtAmountCol9Row2.Text);

                decimal total = row0 + row1 + row2;
                Calculator_Grand_Total.Text = Convert.ToString(total);
                FillTaxFields(total);
            }

        }

        private void FillGrandTotalRow1(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txtAmountCol9Row0) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1))
            {
                decimal row0 = Convert.ToDecimal(txtAmountCol9Row0.Text);
                decimal row1 = Convert.ToDecimal(txtAmountCol9Row1.Text);
                decimal total = row0 + row1;
                Calculator_Grand_Total.Text = Convert.ToString(total);
                FillTaxFields(total);
            }
        }

        private void FillGrandTotalRow0(TextEdit txt)
        {
            Calculator_Grand_Total.Text = txt.Text;
            decimal total = decimal.Parse(txt.Text);
            FillTaxFields(total);
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;

            if (txt.Name.Equals("txtRateCol8Row0"))
            {
                FillAmountRow0(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row1"))
            {
                FillAmountRow1(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row2"))
            {
                FillAmountRow2(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row3"))
            {
                FillAmountRow3(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row4"))
            {
                FillAmountRow4(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row5"))
            {
                FillAmountRow5(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row6"))
            {
                FillAmountRow6(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row7"))
            {
                FillAmountRow7(txt);
            }
        }

        private void FillAmountRow1(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1))
            {
                decimal tone = decimal.Parse(txtToneCol7Row1.Text);
                decimal rate = decimal.Parse(txtRateCol8Row1.Text);
                txtAmountCol9Row1.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow1(txt);
            }
            else
            {
                MessageBox.Show("Please Fill The Tones Value First or Rate Column is Empty");
                txt.Text = string.Empty;
            }
        }

        private void FillAmountRow0(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0))
            {
                decimal tone = decimal.Parse(txtToneCol7Row0.Text);
                decimal rate = decimal.Parse(txtRateCol8Row0.Text);
                txtAmountCol9Row0.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow0(txt);
            }
        }

        private void txtRate_KeyUp(object sender, KeyEventArgs e)
        {
            TextEdit txt = sender as TextEdit;

            if (txt.Name.Equals("txtRateCol8Row0"))
            {
                FillAmountRow0(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row1"))
            {
                FillAmountRow1(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row2"))
            {
                FillAmountRow2(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row3"))
            {
                FillAmountRow3(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row4"))
            {
                FillAmountRow4(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row5"))
            {
                FillAmountRow5(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row6"))
            {
                FillAmountRow6(txt);
            }
            if (txt.Name.Equals("txtRateCol8Row7"))
            {
                FillAmountRow7(txt);
            }
        }

        private void FillAmountRow7(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row7))
            {
                decimal tone = decimal.Parse(txtToneCol7Row7.Text);
                decimal rate = decimal.Parse(txtRateCol8Row7.Text);
                txtAmountCol9Row7.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow7(txt);
            }
            else
            {
                MessageBox.Show("Please Fill The Tones Value First or Rate Column is Empty");
                txt.Text = string.Empty;
            }
        }

        private void FillAmountRow6(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row6))
            {
                decimal tone = decimal.Parse(txtToneCol7Row6.Text);
                decimal rate = decimal.Parse(txtRateCol8Row6.Text);
                txtAmountCol9Row6.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow6(txt);
            }
            else
            {
                MessageBox.Show("Please Fill The Tones Value First or Rate Column is Empty");
                txt.Text = string.Empty;
            }


        }

        private void FillAmountRow5(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row5))
            {
                decimal tone = decimal.Parse(txtToneCol7Row5.Text);
                decimal rate = decimal.Parse(txtRateCol8Row5.Text);
                txtAmountCol9Row5.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow5(txt);
            }
            else
            {
                MessageBox.Show("Please Fill The Tones Value First or Rate Column is Empty");
                txt.Text = string.Empty;
            }


        }

        private void FillAmountRow4(TextEdit txt)
        {

            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row4))
            {
                decimal tone = decimal.Parse(txtToneCol7Row4.Text);
                decimal rate = decimal.Parse(txtRateCol8Row4.Text);
                txtAmountCol9Row4.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow4(txt);
            }
            else
            {
                MessageBox.Show("Please Fill The Tones Value First or Rate Column is Empty");
                txt.Text = string.Empty;
            }

        }

        private void FillAmountRow3(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row3))
            {
                decimal tone = decimal.Parse(txtToneCol7Row3.Text);
                decimal rate = decimal.Parse(txtRateCol8Row3.Text);
                txtAmountCol9Row3.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow3(txt);
            }
            else
            {
                MessageBox.Show("Please Fill The Tones Value First or Rate Column is Empty");
                txt.Text = string.Empty;
            }
        }

        private void FillAmountRow2(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row2))
            {
                decimal tone = decimal.Parse(txtToneCol7Row2.Text);
                decimal rate = decimal.Parse(txtRateCol8Row2.Text);
                txtAmountCol9Row2.Text = Convert.ToString(tone * rate);
                FillGrandTotalRow2(txt);
            }
            else
            {
                MessageBox.Show("Please Fill The Tones Value First or Rate Column is Empty");
                txt.Text = string.Empty;
            }
        }
        private void Calculator_Grand_Total_Enter(object sender, EventArgs e)
        {
            FillGrandTotalRow7(sender as TextEdit);
        }

        #endregion

        #region Check box event to show all the bills
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowAllbox.Checked == true)
            {
                this.zmainbillTableAdapter.FillBySelectAll(this.zmaindataset.zmainbill);
                radioDelete.Enabled = false;
                radioInsertstlc.Enabled = false;
                radioUpdatestlc.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                this.zmainbillTableAdapter.Fill(this.zmaindataset.zmainbill);
                dataGridView2.Refresh();
                radioDelete.Enabled = true;
                radioInsertstlc.Enabled = true;
                radioUpdatestlc.Enabled = true;
                btnDelete.Enabled = false;
            }
        }
        #endregion

        #region Bag Automatic Fill
        private void txtBag_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;

            if (txt.Name.Equals("txtBagCol6Row0"))
            {
                FillBagRow0(txt);
            }
            if (txt.Name.Equals("txtBagCol6Row1"))
            {
                FillBagRow1(txt);
            }
            if (txt.Name.Equals("txtBagCol6Row2"))
            {
                FillBagRow2(txt);
            }
            if (txt.Name.Equals("txtBagCol6Row3"))
            {
                FillBagRow3(txt);
            }
            if (txt.Name.Equals("txtBagCol6Row4"))
            {
                FillBagRow4(txt);
            }
            if (txt.Name.Equals("txtBagCol6Row5"))
            {
                FillBagRow5(txt);
            }
            if (txt.Name.Equals("txtBagCol6Row6"))
            {
                FillBagRow6(txt);
            }
            if (txt.Name.Equals("txtBagCol6Row7"))
            {
                FillBagRow7(txt);
            }
            if (txt.Name.Equals("txtTotalBags"))
            {
                FillTotalBags(txt);
            }


        }

        private void FillTotalBags(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row1) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row2) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row3) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row4) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row5) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row6) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row7))
            {
                decimal[] bags = new decimal[8];
                bags[0] = decimal.Parse(txtBagCol6Row0.Text);
                bags[1] = decimal.Parse(txtBagCol6Row1.Text);
                bags[2] = decimal.Parse(txtBagCol6Row2.Text);
                bags[3] = decimal.Parse(txtBagCol6Row3.Text);
                bags[4] = decimal.Parse(txtBagCol6Row4.Text);
                bags[5] = decimal.Parse(txtBagCol6Row5.Text);
                bags[6] = decimal.Parse(txtBagCol6Row6.Text);
                bags[7] = decimal.Parse(txtBagCol6Row7.Text);
                decimal ttl = 0;
                foreach (decimal total in bags)
                {
                    ttl += total;
                }
                txtTotalBags.Text = Convert.ToString(ttl);
            }
        }

        private void FillBagRow7(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row1) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row2) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row3) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row4) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row5) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row6))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalBags = decimal.Parse(txtTotalBags.Text);
                decimal total = (bags + totalBags);
                FillTotalBags(total);
            }
        }

        private void FillBagRow6(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row1) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row2) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row3) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row4) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row5))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalBags = decimal.Parse(txtTotalBags.Text);
                decimal total = (bags + totalBags);
                FillTotalBags(total);
            }
        }

        private void FillBagRow5(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row1) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row2) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row3) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row4))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalBags = decimal.Parse(txtTotalBags.Text);
                decimal total = (bags + totalBags);
                FillTotalBags(total);
            }
        }

        private void FillBagRow4(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row1) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row2) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row3))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalBags = decimal.Parse(txtTotalBags.Text);
                decimal total = (bags + totalBags);
                FillTotalBags(total);
            }
        }

        private void FillBagRow3(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row1) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row2))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalBags = decimal.Parse(txtTotalBags.Text);
                decimal total = (bags + totalBags);
                FillTotalBags(total);
            }
        }

        private void FillBagRow2(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row1))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalBags = decimal.Parse(txtTotalBags.Text);
                decimal total = (bags + totalBags);
                FillTotalBags(total);
            }
        }

        private void FillBagRow1(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtBagCol6Row0))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalBags = decimal.Parse(txtTotalBags.Text);
                decimal total = (bags + totalBags);
                FillTotalBags(total);
            }
        }

        private void FillBagRow0(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt))
            {
                decimal bags = decimal.Parse(txt.Text);
                FillTotalBags(bags);
            }
        }

        private void FillTotalBags(decimal bags)
        {
            txtTotalBags.Text = Convert.ToString(bags);
        }
        #endregion

        #region Tones Automatic Fill
        private void txtTone_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;

            if (txt.Name.Equals("txtToneCol7Row0"))
            {
                FillToneRow0(txt);
            }
            if (txt.Name.Equals("txtToneCol7Row1"))
            {
                FillToneRow1(txt);
            }
            if (txt.Name.Equals("txtToneCol7Row2"))
            {
                FillToneRow2(txt);
            }
            if (txt.Name.Equals("txtToneCol7Row3"))
            {
                FillToneRow3(txt);
            }
            if (txt.Name.Equals("txtToneCol7Row4"))
            {
                FillToneRow4(txt);
            }
            if (txt.Name.Equals("txtToneCol7Row5"))
            {
                FillToneRow5(txt);
            }
            if (txt.Name.Equals("txtToneCol7Row6"))
            {
                FillToneRow6(txt);
            }
            if (txt.Name.Equals("txtToneCol7Row7"))
            {
                FillToneRow7(txt);
            }
            if (txt.Name.Equals("txttotalTone"))
            {
                FillTotalTone(txt);
            }
        }

        private void FillTotalTones(decimal bags)
        {
            txttotalTone.Text = Convert.ToString(bags);
        }

        private void FillToneRow0(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt))
            {
                decimal bags = decimal.Parse(txt.Text);
                FillTotalTones(bags);
            }
        }

        private void FillToneRow1(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalTones = decimal.Parse(txttotalTone.Text);
                decimal total = (bags + totalTones);
                FillTotalTones(total);
            }
        }

        private void FillToneRow2(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalTones = decimal.Parse(txttotalTone.Text);
                decimal total = (bags + totalTones);
                FillTotalTones(total);
            }
        }

        private void FillToneRow3(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row2))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalTones = decimal.Parse(txttotalTone.Text);
                decimal total = (bags + totalTones);
                FillTotalTones(total);
            }
        }

        private void FillToneRow4(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row2) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row3))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalTones = decimal.Parse(txttotalTone.Text);
                decimal total = (bags + totalTones);
                FillTotalTones(total);
            }
        }

        private void FillToneRow5(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row2) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row3) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row4))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalTones = decimal.Parse(txttotalTone.Text);
                decimal total = (bags + totalTones);
                FillTotalTones(total);
            }
        }

        private void FillToneRow6(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row2) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row3) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row4) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row5))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalTones = decimal.Parse(txttotalTone.Text);
                decimal total = (bags + totalTones);
                FillTotalTones(total);
            }
        }

        private void FillToneRow7(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row2) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row3) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row4) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row5) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row6))
            {
                decimal bags = decimal.Parse(txt.Text);
                decimal totalTones = decimal.Parse(txttotalTone.Text);
                decimal total = (bags + totalTones);
                FillTotalTones(total);
            }
        }

        private void FillTotalTone(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row0) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row1) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row2) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row3) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row4) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row5) & !ValidationClass.IsTextEditEmpty(txtToneCol7Row6))
            {
                decimal[] tones = new decimal[8];
                tones[0] = decimal.Parse(txtToneCol7Row0.Text);
                tones[1] = decimal.Parse(txtToneCol7Row1.Text);
                tones[2] = decimal.Parse(txtToneCol7Row2.Text);
                tones[3] = decimal.Parse(txtToneCol7Row3.Text);
                tones[4] = decimal.Parse(txtToneCol7Row4.Text);
                tones[5] = decimal.Parse(txtToneCol7Row5.Text);
                tones[6] = decimal.Parse(txtToneCol7Row6.Text);
                tones[7] = decimal.Parse(txtToneCol7Row7.Text);

                decimal ttl = 0;
                foreach (decimal total in tones)
                {
                    ttl += total;
                }
                txttotalTone.Text = Convert.ToString(ttl);

            }
        }

        #endregion

        private void txtExpense_Leave(object sender, EventArgs e)
        {
            TextEdit txt = sender as TextEdit;

            if (txt.Name.Equals("txtExpenseCol9Row0"))
            {
                FillExpenseRow0(txt);
            }
            if (txt.Name.Equals("txtExpenseCol9Row1"))
            {
                FillExpenseRow1(txt);
            }
            if (txt.Name.Equals("txtExpenseCol9Row2"))
            {
                FillExpenseRow2(txt);
            }
            if (txt.Name.Equals("txtExpenseCol9Row3"))
            {
                FillExpenseRow3(txt);
            }
            if (txt.Name.Equals("txtExpenseCol9Row4"))
            {
                FillExpenseRow4(txt);
            }
            if (txt.Name.Equals("txtExpenseCol9Row5"))
            {
                FillExpenseRow5(txt);
            }
            if (txt.Name.Equals("txtExpenseCol9Row6"))
            {
                FillExpenseRow6(txt);
            }
            if (txt.Name.Equals("txtExpenseCol9Row7"))
            {
                FillExpenseRow7(txt);
            }

        }

        private void FillExpenseRow7(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row7))
            {
                decimal amount0 = decimal.Parse(txtAmountCol9Row7.Text);
                decimal expense0 = decimal.Parse(txt.Text);
                txtAmountCol9Row7.Text = Convert.ToString(amount0 + expense0);
            }

        }
        private void FillExpenseRow6(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row6))
            {
                decimal amount0 = decimal.Parse(txtAmountCol9Row6.Text);
                decimal expense0 = decimal.Parse(txt.Text);
                txtAmountCol9Row6.Text = Convert.ToString(amount0 + expense0);
            }

        }

        private void FillExpenseRow5(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row5))
            {
                decimal amount0 = decimal.Parse(txtAmountCol9Row5.Text);
                decimal expense0 = decimal.Parse(txt.Text);
                txtAmountCol9Row5.Text = Convert.ToString(amount0 + expense0);
            }
        }

        private void FillExpenseRow4(TextEdit txt)
        {

            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row4))
            {
                decimal amount0 = decimal.Parse(txtAmountCol9Row4.Text);
                decimal expense0 = decimal.Parse(txt.Text);
                txtAmountCol9Row4.Text = Convert.ToString(amount0 + expense0);
            }
        }

        private void FillExpenseRow3(TextEdit txt)
        {

            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row3))
            {
                decimal amount0 = decimal.Parse(txtAmountCol9Row3.Text);
                decimal expense0 = decimal.Parse(txt.Text);
                txtAmountCol9Row3.Text = Convert.ToString(amount0 + expense0);
            }
        }

        private void FillExpenseRow2(TextEdit txt)
        {

            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row2))
            {
                decimal amount0 = decimal.Parse(txtAmountCol9Row2.Text);
                decimal expense0 = decimal.Parse(txt.Text);
                txtAmountCol9Row2.Text = Convert.ToString(amount0 + expense0);
            }
        }

        private void FillExpenseRow1(TextEdit txt)
        {

            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row1))
            {
                decimal amount1 = decimal.Parse(txtAmountCol9Row1.Text);
                decimal expense1 = decimal.Parse(txt.Text);
                txtAmountCol9Row1.Text = Convert.ToString(amount1 + expense1);

            }

        }

        private void FillExpenseRow0(TextEdit txt)
        {
            if (!ValidationClass.IsTextEditEmpty(txt) & !ValidationClass.IsTextEditEmpty(txtAmountCol9Row0))
            {
                decimal amount0 = decimal.Parse(txtAmountCol9Row0.Text);
                decimal expense0 = decimal.Parse(txt.Text);
                txtAmountCol9Row0.Text = Convert.ToString(amount0 + expense0);

            }

        }

    }
}