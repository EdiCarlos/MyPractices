namespace SupremeTransport
{
    partial class Zahid_Pending
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.notificationInformation1 = new SupremeTransport.NotificationInformation();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zmaindataset = new SupremeTransport.zmaindataset();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBySearchBox = new System.Windows.Forms.GroupBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtBilMain = new DevExpress.XtraEditors.DateEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zmainbillTableAdapter = new SupremeTransport.zmaindatasetTableAdapters.zmainbillTableAdapter();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.txtPartyName = new System.Windows.Forms.ComboBox();
            this.txtDebitBillNo = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalPendingAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmaindataset)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBySearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitBillNo.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "(Pending Bills)";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.notificationInformation1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(14, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 74);
            this.panel3.TabIndex = 0;
            // 
            // notificationInformation1
            // 
            this.notificationInformation1.Location = new System.Drawing.Point(630, 2);
            this.notificationInformation1.Name = "notificationInformation1";
            this.notificationInformation1.Size = new System.Drawing.Size(361, 74);
            this.notificationInformation1.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkOrange;
            this.label19.Location = new System.Drawing.Point(309, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(293, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "Supreme Transport And Zahid";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(333, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnSearch);
            this.panel5.Location = new System.Drawing.Point(6, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(996, 32);
            this.panel5.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(547, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Location = new System.Drawing.Point(440, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "C&lear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(11, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 367);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted_1);
            // 
            // zmaindataset
            // 
            this.zmaindataset.DataSetName = "zmaindataset";
            this.zmaindataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBySearchBox);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(14, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 151);
            this.panel2.TabIndex = 2;
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
            this.groupBySearchBox.Location = new System.Drawing.Point(3, 59);
            this.groupBySearchBox.Name = "groupBySearchBox";
            this.groupBySearchBox.Size = new System.Drawing.Size(998, 49);
            this.groupBySearchBox.TabIndex = 3;
            this.groupBySearchBox.TabStop = false;
            this.groupBySearchBox.Text = "Search By Any One";
            // 
            // txtStation
            // 
            this.txtStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStation.Location = new System.Drawing.Point(608, 22);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(166, 20);
            this.txtStation.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(547, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Station :";
            // 
            // dtBilMain
            // 
            this.dtBilMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtBilMain.EditValue = null;
            this.dtBilMain.Location = new System.Drawing.Point(828, 22);
            this.dtBilMain.Name = "dtBilMain";
            this.dtBilMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBilMain.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtBilMain.Size = new System.Drawing.Size(160, 20);
            this.dtBilMain.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(780, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Date :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Party Name :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Debit Bill No :";
            // 
            // zmainbillTableAdapter
            // 
            this.zmainbillTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.Location = new System.Drawing.Point(654, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Re&fresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPartyName
            // 
            this.txtPartyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPartyName.FormattingEnabled = true;
            this.txtPartyName.Location = new System.Drawing.Point(89, 23);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(255, 21);
            this.txtPartyName.TabIndex = 2;
            // 
            // txtDebitBillNo
            // 
            this.txtDebitBillNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDebitBillNo.EditValue = 0;
            this.txtDebitBillNo.Location = new System.Drawing.Point(442, 23);
            this.txtDebitBillNo.Name = "txtDebitBillNo";
            this.txtDebitBillNo.Properties.Mask.EditMask = "n";
            this.txtDebitBillNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDebitBillNo.Size = new System.Drawing.Size(99, 20);
            this.txtDebitBillNo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalPendingAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(567, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 57);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pending Details";
            // 
            // txtTotalPendingAmount
            // 
            this.txtTotalPendingAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalPendingAmount.Enabled = false;
            this.txtTotalPendingAmount.Location = new System.Drawing.Point(153, 22);
            this.txtTotalPendingAmount.Name = "txtTotalPendingAmount";
            this.txtTotalPendingAmount.Size = new System.Drawing.Size(255, 20);
            this.txtTotalPendingAmount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Pending Amount :";
            // 
            // Zahid_Pending
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1028, 616);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(1022, 650);
            this.Name = "Zahid_Pending";
            this.Text = "Zahid\'s Pending Bills";
            this.Load += new System.EventHandler(this.Zahid_Pending_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmaindataset)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBySearchBox.ResumeLayout(false);
            this.groupBySearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBilMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitBillNo.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private zmaindataset zmaindataset;
        private SupremeTransport.zmaindatasetTableAdapters.zmainbillTableAdapter zmainbillTableAdapter;
        private System.Windows.Forms.GroupBox groupBySearchBox;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.DateEdit dtBilMain;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private NotificationInformation notificationInformation1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.ComboBox txtPartyName;
        private DevExpress.XtraEditors.TextEdit txtDebitBillNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalPendingAmount;
        private System.Windows.Forms.Label label2;
    }
}