namespace SupremeTransport
{
    partial class Supreme_Pend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maindataset = new SupremeTransport.maindataset();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notificationInformation1 = new SupremeTransport.NotificationInformation();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mainbillTableAdapter = new SupremeTransport.maindatasetTableAdapters.mainbillTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalPendingAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBySearchBox = new System.Windows.Forms.GroupBox();
            this.txtDebitBillNo = new DevExpress.XtraEditors.TextEdit();
            this.txtPartyName = new System.Windows.Forms.ComboBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtBilMain = new DevExpress.XtraEditors.DateEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.pendingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pendingTableAdapter = new SupremeTransport.maindatasetTableAdapters.PendingTableAdapter();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitBillNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSServiceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billReceivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.billRecievedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalInWordsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherExpenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalReceivedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysleftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysgoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataset)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBySearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitBillNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 281);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 474);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.debitBillNoDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn,
            this.stationDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.serviceChargeDataGridViewTextBoxColumn,
            this.hSServiceChargeDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.chequeNoDataGridViewTextBoxColumn,
            this.billReceivedDataGridViewCheckBoxColumn,
            this.billRecievedDateDataGridViewTextBoxColumn,
            this.chequeDateDataGridViewTextBoxColumn,
            this.totalInWordsDataGridViewTextBoxColumn,
            this.totalTonesDataGridViewTextBoxColumn,
            this.totalBagsDataGridViewTextBoxColumn,
            this.tDSDataGridViewTextBoxColumn,
            this.otherExpenseDataGridViewTextBoxColumn,
            this.totalReceivedAmountDataGridViewTextBoxColumn,
            this.billdate,
            this.enddate,
            this.daysleftDataGridViewTextBoxColumn,
            this.daysgoneDataGridViewTextBoxColumn,
            this.totaldaysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pendingBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1339, 474);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // maindataset
            // 
            this.maindataset.DataSetName = "maindataset";
            this.maindataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.notificationInformation1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(20, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1339, 79);
            this.panel3.TabIndex = 2;
            // 
            // notificationInformation1
            // 
            this.notificationInformation1.Location = new System.Drawing.Point(852, 4);
            this.notificationInformation1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.notificationInformation1.Name = "notificationInformation1";
            this.notificationInformation1.Size = new System.Drawing.Size(469, 85);
            this.notificationInformation1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "(Pending Bills)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkOrange;
            this.label19.Location = new System.Drawing.Point(489, 6);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(239, 29);
            this.label19.TabIndex = 2;
            this.label19.Text = "Supreme Transport";
            // 
            // mainbillTableAdapter
            // 
            this.mainbillTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBySearchBox);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(20, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 186);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalPendingAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(760, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(571, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending Details";
            // 
            // txtTotalPendingAmount
            // 
            this.txtTotalPendingAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalPendingAmount.Enabled = false;
            this.txtTotalPendingAmount.Location = new System.Drawing.Point(204, 27);
            this.txtTotalPendingAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalPendingAmount.Name = "txtTotalPendingAmount";
            this.txtTotalPendingAmount.Size = new System.Drawing.Size(339, 23);
            this.txtTotalPendingAmount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Pending Amount :";
            // 
            // groupBySearchBox
            // 
            this.groupBySearchBox.Controls.Add(this.txtDebitBillNo);
            this.groupBySearchBox.Controls.Add(this.txtPartyName);
            this.groupBySearchBox.Controls.Add(this.txtStation);
            this.groupBySearchBox.Controls.Add(this.label18);
            this.groupBySearchBox.Controls.Add(this.dtBilMain);
            this.groupBySearchBox.Controls.Add(this.label17);
            this.groupBySearchBox.Controls.Add(this.label7);
            this.groupBySearchBox.Controls.Add(this.label6);
            this.groupBySearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBySearchBox.Location = new System.Drawing.Point(4, 79);
            this.groupBySearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBySearchBox.Name = "groupBySearchBox";
            this.groupBySearchBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBySearchBox.Size = new System.Drawing.Size(1327, 65);
            this.groupBySearchBox.TabIndex = 3;
            this.groupBySearchBox.TabStop = false;
            this.groupBySearchBox.Text = "Search By Any One";
            // 
            // txtDebitBillNo
            // 
            this.txtDebitBillNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebitBillNo.EditValue = 0;
            this.txtDebitBillNo.Location = new System.Drawing.Point(589, 32);
            this.txtDebitBillNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDebitBillNo.Name = "txtDebitBillNo";
            this.txtDebitBillNo.Properties.Mask.EditMask = "n";
            this.txtDebitBillNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDebitBillNo.Size = new System.Drawing.Size(128, 22);
            this.txtDebitBillNo.TabIndex = 4;
            // 
            // txtPartyName
            // 
            this.txtPartyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartyName.FormattingEnabled = true;
            this.txtPartyName.Location = new System.Drawing.Point(116, 32);
            this.txtPartyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(339, 25);
            this.txtPartyName.TabIndex = 2;
            // 
            // txtStation
            // 
            this.txtStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStation.Location = new System.Drawing.Point(808, 33);
            this.txtStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(220, 23);
            this.txtStation.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(727, 34);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 5;
            this.label18.Text = "Station :";
            // 
            // dtBilMain
            // 
            this.dtBilMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtBilMain.EditValue = null;
            this.dtBilMain.Location = new System.Drawing.Point(1101, 33);
            this.dtBilMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtBilMain.Name = "dtBilMain";
            this.dtBilMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBilMain.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBilMain.Size = new System.Drawing.Size(213, 22);
            this.dtBilMain.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1037, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Date :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Party Name :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Debit Bill No :";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Location = new System.Drawing.Point(8, 146);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1328, 36);
            this.panel5.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(820, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Re&fresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(681, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(532, 4);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 28);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearch.Location = new System.Drawing.Point(376, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pendingBindingSource
            // 
            this.pendingBindingSource.DataMember = "Pending";
            this.pendingBindingSource.DataSource = this.maindataset;
            // 
            // pendingTableAdapter
            // 
            this.pendingTableAdapter.ClearBeforeFill = true;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "Bill Id";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "Bill Id";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "User Id";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "User Id";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debitBillNoDataGridViewTextBoxColumn
            // 
            this.debitBillNoDataGridViewTextBoxColumn.DataPropertyName = "Debit Bill No_";
            this.debitBillNoDataGridViewTextBoxColumn.HeaderText = "Debit Bill No_";
            this.debitBillNoDataGridViewTextBoxColumn.Name = "debitBillNoDataGridViewTextBoxColumn";
            this.debitBillNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "Party Name";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "Party Name";
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            this.partyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "Station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "Station";
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            this.stationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceChargeDataGridViewTextBoxColumn
            // 
            this.serviceChargeDataGridViewTextBoxColumn.DataPropertyName = "Service Charge";
            this.serviceChargeDataGridViewTextBoxColumn.HeaderText = "Service Charge";
            this.serviceChargeDataGridViewTextBoxColumn.Name = "serviceChargeDataGridViewTextBoxColumn";
            this.serviceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hSServiceChargeDataGridViewTextBoxColumn
            // 
            this.hSServiceChargeDataGridViewTextBoxColumn.DataPropertyName = "H_S_Service Charge";
            this.hSServiceChargeDataGridViewTextBoxColumn.HeaderText = "H_S_Service Charge";
            this.hSServiceChargeDataGridViewTextBoxColumn.Name = "hSServiceChargeDataGridViewTextBoxColumn";
            this.hSServiceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "Tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            this.taxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeNoDataGridViewTextBoxColumn
            // 
            this.chequeNoDataGridViewTextBoxColumn.DataPropertyName = "Cheque No_";
            this.chequeNoDataGridViewTextBoxColumn.HeaderText = "Cheque No_";
            this.chequeNoDataGridViewTextBoxColumn.Name = "chequeNoDataGridViewTextBoxColumn";
            this.chequeNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billReceivedDataGridViewCheckBoxColumn
            // 
            this.billReceivedDataGridViewCheckBoxColumn.DataPropertyName = "Bill Received";
            this.billReceivedDataGridViewCheckBoxColumn.HeaderText = "Bill Received";
            this.billReceivedDataGridViewCheckBoxColumn.Name = "billReceivedDataGridViewCheckBoxColumn";
            this.billReceivedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // billRecievedDateDataGridViewTextBoxColumn
            // 
            this.billRecievedDateDataGridViewTextBoxColumn.DataPropertyName = "Bill Recieved date";
            this.billRecievedDateDataGridViewTextBoxColumn.HeaderText = "Bill Recieved date";
            this.billRecievedDateDataGridViewTextBoxColumn.Name = "billRecievedDateDataGridViewTextBoxColumn";
            this.billRecievedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeDateDataGridViewTextBoxColumn
            // 
            this.chequeDateDataGridViewTextBoxColumn.DataPropertyName = "Cheque Date";
            this.chequeDateDataGridViewTextBoxColumn.HeaderText = "Cheque Date";
            this.chequeDateDataGridViewTextBoxColumn.Name = "chequeDateDataGridViewTextBoxColumn";
            this.chequeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalInWordsDataGridViewTextBoxColumn
            // 
            this.totalInWordsDataGridViewTextBoxColumn.DataPropertyName = "TotalInWords";
            this.totalInWordsDataGridViewTextBoxColumn.HeaderText = "TotalInWords";
            this.totalInWordsDataGridViewTextBoxColumn.Name = "totalInWordsDataGridViewTextBoxColumn";
            this.totalInWordsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalTonesDataGridViewTextBoxColumn
            // 
            this.totalTonesDataGridViewTextBoxColumn.DataPropertyName = "Total Tones";
            this.totalTonesDataGridViewTextBoxColumn.HeaderText = "Total Tones";
            this.totalTonesDataGridViewTextBoxColumn.Name = "totalTonesDataGridViewTextBoxColumn";
            this.totalTonesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBagsDataGridViewTextBoxColumn
            // 
            this.totalBagsDataGridViewTextBoxColumn.DataPropertyName = "Total Bags";
            this.totalBagsDataGridViewTextBoxColumn.HeaderText = "Total Bags";
            this.totalBagsDataGridViewTextBoxColumn.Name = "totalBagsDataGridViewTextBoxColumn";
            this.totalBagsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDSDataGridViewTextBoxColumn
            // 
            this.tDSDataGridViewTextBoxColumn.DataPropertyName = "TDS";
            this.tDSDataGridViewTextBoxColumn.HeaderText = "TDS";
            this.tDSDataGridViewTextBoxColumn.Name = "tDSDataGridViewTextBoxColumn";
            this.tDSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherExpenseDataGridViewTextBoxColumn
            // 
            this.otherExpenseDataGridViewTextBoxColumn.DataPropertyName = "Other Expense";
            this.otherExpenseDataGridViewTextBoxColumn.HeaderText = "Other Expense";
            this.otherExpenseDataGridViewTextBoxColumn.Name = "otherExpenseDataGridViewTextBoxColumn";
            this.otherExpenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalReceivedAmountDataGridViewTextBoxColumn
            // 
            this.totalReceivedAmountDataGridViewTextBoxColumn.DataPropertyName = "Total Received Amount";
            this.totalReceivedAmountDataGridViewTextBoxColumn.HeaderText = "Total Received Amount";
            this.totalReceivedAmountDataGridViewTextBoxColumn.Name = "totalReceivedAmountDataGridViewTextBoxColumn";
            this.totalReceivedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billdate
            // 
            this.billdate.DataPropertyName = "Start Date";
            this.billdate.HeaderText = "Start Date";
            this.billdate.Name = "billdate";
            this.billdate.ReadOnly = true;
            // 
            // enddate
            // 
            this.enddate.DataPropertyName = "End Date";
            this.enddate.HeaderText = "End Date";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            // 
            // daysleftDataGridViewTextBoxColumn
            // 
            this.daysleftDataGridViewTextBoxColumn.DataPropertyName = "daysleft";
            this.daysleftDataGridViewTextBoxColumn.HeaderText = "daysleft";
            this.daysleftDataGridViewTextBoxColumn.Name = "daysleftDataGridViewTextBoxColumn";
            this.daysleftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daysgoneDataGridViewTextBoxColumn
            // 
            this.daysgoneDataGridViewTextBoxColumn.DataPropertyName = "daysgone";
            this.daysgoneDataGridViewTextBoxColumn.HeaderText = "daysgone";
            this.daysgoneDataGridViewTextBoxColumn.Name = "daysgoneDataGridViewTextBoxColumn";
            this.daysgoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totaldaysDataGridViewTextBoxColumn
            // 
            this.totaldaysDataGridViewTextBoxColumn.DataPropertyName = "totaldays";
            this.totaldaysDataGridViewTextBoxColumn.HeaderText = "totaldays";
            this.totaldaysDataGridViewTextBoxColumn.Name = "totaldaysDataGridViewTextBoxColumn";
            this.totaldaysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Supreme_Pend
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSearch;
            this.ClientSize = new System.Drawing.Size(1371, 758);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Supreme_Pend";
            this.Text = "Supreme Pending Bills";
            this.Load += new System.EventHandler(this.Supreme_Pend_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataset)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBySearchBox.ResumeLayout(false);
            this.groupBySearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitBillNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pendingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private maindataset maindataset;
        private SupremeTransport.maindatasetTableAdapters.mainbillTableAdapter mainbillTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBySearchBox;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.DateEdit dtBilMain;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private NotificationInformation notificationInformation1;
        private System.Windows.Forms.ComboBox txtPartyName;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtDebitBillNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPendingAmount;
        private System.Windows.Forms.BindingSource pendingBindingSource;
        private SupremeTransport.maindatasetTableAdapters.PendingTableAdapter pendingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitBillNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSServiceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn billReceivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billRecievedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalInWordsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherExpenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalReceivedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysleftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysgoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldaysDataGridViewTextBoxColumn;
    }
}