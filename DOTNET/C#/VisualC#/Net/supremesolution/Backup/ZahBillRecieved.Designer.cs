namespace SupremeTransport
{
    partial class ZahBillRecieved
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkIfUpdate = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.groupPaymentDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comPaymentRecieved = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPaymentDate = new DevExpress.XtraEditors.DateEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChequeNumber = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.dtChequeDate = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBillDetails = new System.Windows.Forms.GroupBox();
            this.comboDebitBillNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zmainbillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zmaindataset = new SupremeTransport.zmaindataset();
            this.zmainbillTableAdapter = new SupremeTransport.zmaindatasetTableAdapters.zmainbillTableAdapter();
            this.mnbillIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitBillNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsServiceChargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billrecieveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.billrcvdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chequeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupPaymentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comPaymentRecieved.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChequeNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChequeDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChequeDate.Properties)).BeginInit();
            this.groupBillDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboDebitBillNumber.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmainbillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmaindataset)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1004, 592);
            this.panelMain.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(998, 172);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.groupPaymentDetails);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBillDetails);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Payment Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkIfUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(267, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 34);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task";
            // 
            // checkIfUpdate
            // 
            this.checkIfUpdate.AutoSize = true;
            this.checkIfUpdate.Location = new System.Drawing.Point(107, 11);
            this.checkIfUpdate.Name = "checkIfUpdate";
            this.checkIfUpdate.Size = new System.Drawing.Size(241, 17);
            this.checkIfUpdate.TabIndex = 0;
            this.checkIfUpdate.Text = "Check this box if you want to update?";
            this.checkIfUpdate.UseVisualStyleBackColor = true;
            this.checkIfUpdate.CheckedChanged += new System.EventHandler(this.checkIfUpdate_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(349, 126);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(584, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "C&lear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(705, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(463, 126);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(97, 23);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "&Show All";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupPaymentDetails
            // 
            this.groupPaymentDetails.Controls.Add(this.label2);
            this.groupPaymentDetails.Controls.Add(this.comPaymentRecieved);
            this.groupPaymentDetails.Controls.Add(this.label3);
            this.groupPaymentDetails.Controls.Add(this.dtPaymentDate);
            this.groupPaymentDetails.Location = new System.Drawing.Point(541, 19);
            this.groupPaymentDetails.Name = "groupPaymentDetails";
            this.groupPaymentDetails.Size = new System.Drawing.Size(277, 65);
            this.groupPaymentDetails.TabIndex = 26;
            this.groupPaymentDetails.TabStop = false;
            this.groupPaymentDetails.Text = "Payment Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Payment Recieved :";
            // 
            // comPaymentRecieved
            // 
            this.comPaymentRecieved.Location = new System.Drawing.Point(142, 14);
            this.comPaymentRecieved.Name = "comPaymentRecieved";
            this.comPaymentRecieved.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comPaymentRecieved.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comPaymentRecieved.Size = new System.Drawing.Size(116, 20);
            this.comPaymentRecieved.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Payment Date :";
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.EditValue = "4/4/2010";
            this.dtPaymentDate.Location = new System.Drawing.Point(142, 40);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtPaymentDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtPaymentDate.Size = new System.Drawing.Size(116, 20);
            this.dtPaymentDate.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChequeNumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtChequeDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(258, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 65);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cheque Details";
            // 
            // txtChequeNumber
            // 
            this.txtChequeNumber.EditValue = 0;
            this.txtChequeNumber.Location = new System.Drawing.Point(127, 13);
            this.txtChequeNumber.Name = "txtChequeNumber";
            this.txtChequeNumber.Properties.Mask.EditMask = "d";
            this.txtChequeNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtChequeNumber.Size = new System.Drawing.Size(121, 20);
            this.txtChequeNumber.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cheque Number :";
            // 
            // dtChequeDate
            // 
            this.dtChequeDate.EditValue = null;
            this.dtChequeDate.Location = new System.Drawing.Point(127, 39);
            this.dtChequeDate.Name = "dtChequeDate";
            this.dtChequeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtChequeDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtChequeDate.Size = new System.Drawing.Size(121, 20);
            this.dtChequeDate.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cheque Date :";
            // 
            // groupBillDetails
            // 
            this.groupBillDetails.Controls.Add(this.comboDebitBillNumber);
            this.groupBillDetails.Location = new System.Drawing.Point(114, 34);
            this.groupBillDetails.Name = "groupBillDetails";
            this.groupBillDetails.Size = new System.Drawing.Size(122, 44);
            this.groupBillDetails.TabIndex = 24;
            this.groupBillDetails.TabStop = false;
            this.groupBillDetails.Text = "Debit Bill Number";
            // 
            // comboDebitBillNumber
            // 
            this.comboDebitBillNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboDebitBillNumber.Location = new System.Drawing.Point(6, 18);
            this.comboDebitBillNumber.Name = "comboDebitBillNumber";
            this.comboDebitBillNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboDebitBillNumber.Size = new System.Drawing.Size(110, 20);
            this.comboDebitBillNumber.TabIndex = 23;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Appearance.Options.UseFont = true;
            this.btnEnter.Location = new System.Drawing.Point(233, 126);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(97, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Bill &Recieved";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 40);
            this.panel2.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkOrange;
            this.label19.Location = new System.Drawing.Point(404, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(257, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "Payment Received (Zahid)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 331);
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
            this.mnbillIdDataGridViewTextBoxColumn,
            this.debitBillNoDataGridViewTextBoxColumn,
            this.billdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn,
            this.stationDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.serviceChargeDataGridViewTextBoxColumn,
            this.surchargeDataGridViewTextBoxColumn,
            this.hsServiceChargeDataGridViewTextBoxColumn,
            this.taxDataGridViewTextBoxColumn,
            this.chequenoDataGridViewTextBoxColumn,
            this.billrecieveDataGridViewCheckBoxColumn,
            this.billrcvdateDataGridViewTextBoxColumn,
            this.chequeDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zmainbillBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(998, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // zmainbillBindingSource
            // 
            this.zmainbillBindingSource.DataMember = "zmainbill";
            this.zmainbillBindingSource.DataSource = this.zmaindataset;
            // 
            // zmaindataset
            // 
            this.zmaindataset.DataSetName = "zmaindataset";
            this.zmaindataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zmainbillTableAdapter
            // 
            this.zmainbillTableAdapter.ClearBeforeFill = true;
            // 
            // mnbillIdDataGridViewTextBoxColumn
            // 
            this.mnbillIdDataGridViewTextBoxColumn.DataPropertyName = "mnbillId";
            this.mnbillIdDataGridViewTextBoxColumn.HeaderText = "Bill Id";
            this.mnbillIdDataGridViewTextBoxColumn.Name = "mnbillIdDataGridViewTextBoxColumn";
            this.mnbillIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debitBillNoDataGridViewTextBoxColumn
            // 
            this.debitBillNoDataGridViewTextBoxColumn.DataPropertyName = "debitBillNo";
            this.debitBillNoDataGridViewTextBoxColumn.HeaderText = "Debit Bill Number";
            this.debitBillNoDataGridViewTextBoxColumn.Name = "debitBillNoDataGridViewTextBoxColumn";
            this.debitBillNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billdateDataGridViewTextBoxColumn
            // 
            this.billdateDataGridViewTextBoxColumn.DataPropertyName = "billdate";
            this.billdateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.billdateDataGridViewTextBoxColumn.Name = "billdateDataGridViewTextBoxColumn";
            this.billdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "enddate";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "partyName";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "Party Name";
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            this.partyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stationDataGridViewTextBoxColumn
            // 
            this.stationDataGridViewTextBoxColumn.DataPropertyName = "station";
            this.stationDataGridViewTextBoxColumn.HeaderText = "Station";
            this.stationDataGridViewTextBoxColumn.Name = "stationDataGridViewTextBoxColumn";
            this.stationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceChargeDataGridViewTextBoxColumn
            // 
            this.serviceChargeDataGridViewTextBoxColumn.DataPropertyName = "serviceCharge";
            this.serviceChargeDataGridViewTextBoxColumn.HeaderText = "Service Charge";
            this.serviceChargeDataGridViewTextBoxColumn.Name = "serviceChargeDataGridViewTextBoxColumn";
            this.serviceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surchargeDataGridViewTextBoxColumn
            // 
            this.surchargeDataGridViewTextBoxColumn.DataPropertyName = "surcharge";
            this.surchargeDataGridViewTextBoxColumn.HeaderText = "Surcharge";
            this.surchargeDataGridViewTextBoxColumn.Name = "surchargeDataGridViewTextBoxColumn";
            this.surchargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hsServiceChargeDataGridViewTextBoxColumn
            // 
            this.hsServiceChargeDataGridViewTextBoxColumn.DataPropertyName = "hsServiceCharge";
            this.hsServiceChargeDataGridViewTextBoxColumn.HeaderText = "H.S.ServiceCharge";
            this.hsServiceChargeDataGridViewTextBoxColumn.Name = "hsServiceChargeDataGridViewTextBoxColumn";
            this.hsServiceChargeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxDataGridViewTextBoxColumn
            // 
            this.taxDataGridViewTextBoxColumn.DataPropertyName = "tax";
            this.taxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.taxDataGridViewTextBoxColumn.Name = "taxDataGridViewTextBoxColumn";
            this.taxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequenoDataGridViewTextBoxColumn
            // 
            this.chequenoDataGridViewTextBoxColumn.DataPropertyName = "chequeno";
            this.chequenoDataGridViewTextBoxColumn.HeaderText = "Cheque Number";
            this.chequenoDataGridViewTextBoxColumn.Name = "chequenoDataGridViewTextBoxColumn";
            this.chequenoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billrecieveDataGridViewCheckBoxColumn
            // 
            this.billrecieveDataGridViewCheckBoxColumn.DataPropertyName = "billrecieve";
            this.billrecieveDataGridViewCheckBoxColumn.HeaderText = "Bill Recieved";
            this.billrecieveDataGridViewCheckBoxColumn.Name = "billrecieveDataGridViewCheckBoxColumn";
            this.billrecieveDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // billrcvdateDataGridViewTextBoxColumn
            // 
            this.billrcvdateDataGridViewTextBoxColumn.DataPropertyName = "billrcvdate";
            this.billrcvdateDataGridViewTextBoxColumn.HeaderText = "Bill Recieved Date";
            this.billrcvdateDataGridViewTextBoxColumn.Name = "billrcvdateDataGridViewTextBoxColumn";
            this.billrcvdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chequeDateDataGridViewTextBoxColumn
            // 
            this.chequeDateDataGridViewTextBoxColumn.DataPropertyName = "Cheque_Date";
            this.chequeDateDataGridViewTextBoxColumn.HeaderText = "Cheque Date";
            this.chequeDateDataGridViewTextBoxColumn.Name = "chequeDateDataGridViewTextBoxColumn";
            this.chequeDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ZahBillRecieved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 616);
            this.Controls.Add(this.panelMain);
            this.Name = "ZahBillRecieved";
            this.Text = "ZahBillRecieved";
            this.Load += new System.EventHandler(this.ZahBillRecieved_Load);
            this.panelMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupPaymentDetails.ResumeLayout(false);
            this.groupPaymentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comPaymentRecieved.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPaymentDate.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtChequeNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChequeDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtChequeDate.Properties)).EndInit();
            this.groupBillDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboDebitBillNumber.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmainbillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmaindataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkIfUpdate;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.GroupBox groupPaymentDetails;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit comPaymentRecieved;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtPaymentDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtChequeNumber;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.DateEdit dtChequeDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBillDetails;
        private DevExpress.XtraEditors.ComboBoxEdit comboDebitBillNumber;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private zmaindataset zmaindataset;
        private System.Windows.Forms.BindingSource zmainbillBindingSource;
        private SupremeTransport.zmaindatasetTableAdapters.zmainbillTableAdapter zmainbillTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnbillIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitBillNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsServiceChargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn billrecieveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billrcvdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chequeDateDataGridViewTextBoxColumn;
    }
}