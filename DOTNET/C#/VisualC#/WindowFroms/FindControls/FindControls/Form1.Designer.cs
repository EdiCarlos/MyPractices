namespace FindControls
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.paneltabEntry = new System.Windows.Forms.Panel();
            this.tabEntryControl = new System.Windows.Forms.TabControl();
            this.tabBatchLevel = new System.Windows.Forms.TabPage();
            this.btn_skipBtach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mastno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_wtflag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_invdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_carracct = new System.Windows.Forms.TextBox();
            this.lblTbilled = new System.Windows.Forms.Label();
            this.groupBatch = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_item1 = new System.Windows.Forms.Label();
            this.txt_scac = new System.Windows.Forms.TextBox();
            this.txt_vatperc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_scaclient = new System.Windows.Forms.TextBox();
            this.lbl_item4 = new System.Windows.Forms.Label();
            this.lbl_item2 = new System.Windows.Forms.Label();
            this.txt_curr = new System.Windows.Forms.TextBox();
            this.lbl_item3 = new System.Windows.Forms.Label();
            this.txt_batch = new System.Windows.Forms.TextBox();
            this.txt_clientno = new System.Windows.Forms.TextBox();
            this.lblscacName = new System.Windows.Forms.Label();
            this.tabShipment = new System.Windows.Forms.TabPage();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.paneltabEntry.SuspendLayout();
            this.tabEntryControl.SuspendLayout();
            this.tabBatchLevel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBatch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_skipBtach);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.paneltabEntry);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1228, 739);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 3;
            // 
            // paneltabEntry
            // 
            this.paneltabEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltabEntry.Controls.Add(this.tabEntryControl);
            this.paneltabEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltabEntry.Location = new System.Drawing.Point(0, 0);
            this.paneltabEntry.Name = "paneltabEntry";
            this.paneltabEntry.Size = new System.Drawing.Size(815, 739);
            this.paneltabEntry.TabIndex = 4;
            // 
            // tabEntryControl
            // 
            this.tabEntryControl.Controls.Add(this.tabBatchLevel);
            this.tabEntryControl.Controls.Add(this.tabShipment);
            this.tabEntryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEntryControl.Location = new System.Drawing.Point(0, 0);
            this.tabEntryControl.MinimumSize = new System.Drawing.Size(0, 203);
            this.tabEntryControl.Name = "tabEntryControl";
            this.tabEntryControl.SelectedIndex = 0;
            this.tabEntryControl.Size = new System.Drawing.Size(813, 737);
            this.tabEntryControl.TabIndex = 1;
            // 
            // tabBatchLevel
            // 
            this.tabBatchLevel.Controls.Add(this.groupBox1);
            this.tabBatchLevel.Controls.Add(this.groupBatch);
            this.tabBatchLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBatchLevel.Location = new System.Drawing.Point(4, 22);
            this.tabBatchLevel.Name = "tabBatchLevel";
            this.tabBatchLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabBatchLevel.Size = new System.Drawing.Size(805, 711);
            this.tabBatchLevel.TabIndex = 0;
            this.tabBatchLevel.Text = "Batch & Mast Level Details";
            this.tabBatchLevel.UseVisualStyleBackColor = true;
            // 
            // btn_skipBtach
            // 
            this.btn_skipBtach.Location = new System.Drawing.Point(138, 221);
            this.btn_skipBtach.Name = "btn_skipBtach";
            this.btn_skipBtach.Size = new System.Drawing.Size(76, 23);
            this.btn_skipBtach.TabIndex = 62;
            this.btn_skipBtach.Text = "S&kip Batch";
            this.btn_skipBtach.UseVisualStyleBackColor = true;
            this.btn_skipBtach.Click += new System.EventHandler(this.btn_skipBtach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Level Details:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 13;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.260448F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.649174F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.122449F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.135082F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.219631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMsg, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_mastno, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_wtflag, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_mode, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_invdate, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_carracct, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTbilled, 11, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(763, 53);
            this.tableLayoutPanel2.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = " dd/mm/yy";
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMsg.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblMsg, 3);
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(620, 8);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(104, 16);
            this.lblMsg.TabIndex = 54;
            this.lblMsg.Text = "Batch Loaded";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mast Inv No";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "0-Pds,1-KGs";
            // 
            // txt_mastno
            // 
            this.txt_mastno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mastno.Location = new System.Drawing.Point(66, 6);
            this.txt_mastno.Name = "txt_mastno";
            this.txt_mastno.Size = new System.Drawing.Size(60, 20);
            this.txt_mastno.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(136, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 26);
            this.label8.TabIndex = 46;
            this.label8.Text = "Wt Flag";
            // 
            // txt_wtflag
            // 
            this.txt_wtflag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_wtflag.Location = new System.Drawing.Point(178, 6);
            this.txt_wtflag.MaxLength = 1;
            this.txt_wtflag.Name = "txt_wtflag";
            this.txt_wtflag.Size = new System.Drawing.Size(63, 20);
            this.txt_wtflag.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Mode";
            // 
            // txt_mode
            // 
            this.txt_mode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mode.Location = new System.Drawing.Point(294, 6);
            this.txt_mode.Name = "txt_mode";
            this.txt_mode.Size = new System.Drawing.Size(52, 20);
            this.txt_mode.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 26);
            this.label5.TabIndex = 51;
            this.label5.Text = "Inv Date";
            // 
            // txt_invdate
            // 
            this.txt_invdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_invdate.Location = new System.Drawing.Point(410, 6);
            this.txt_invdate.MaxLength = 8;
            this.txt_invdate.Name = "txt_invdate";
            this.txt_invdate.Size = new System.Drawing.Size(52, 20);
            this.txt_invdate.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(468, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 26);
            this.label10.TabIndex = 53;
            this.label10.Text = "CarrAcct";
            // 
            // txt_carracct
            // 
            this.txt_carracct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_carracct.Location = new System.Drawing.Point(526, 6);
            this.txt_carracct.Name = "txt_carracct";
            this.txt_carracct.Size = new System.Drawing.Size(52, 20);
            this.txt_carracct.TabIndex = 52;
            // 
            // lblTbilled
            // 
            this.lblTbilled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTbilled.AutoSize = true;
            this.lblTbilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTbilled.Location = new System.Drawing.Point(646, 36);
            this.lblTbilled.Name = "lblTbilled";
            this.lblTbilled.Size = new System.Drawing.Size(44, 13);
            this.lblTbilled.TabIndex = 56;
            this.lblTbilled.Text = "Billed=0";
            this.lblTbilled.Visible = false;
            // 
            // groupBatch
            // 
            this.groupBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBatch.Controls.Add(this.tableLayoutPanel1);
            this.groupBatch.Controls.Add(this.lblscacName);
            this.groupBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBatch.Location = new System.Drawing.Point(6, 146);
            this.groupBatch.Name = "groupBatch";
            this.groupBatch.Size = new System.Drawing.Size(784, 64);
            this.groupBatch.TabIndex = 1;
            this.groupBatch.TabStop = false;
            this.groupBatch.Text = "Batch Level Details:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.30533F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.07353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62114F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_item1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_scac, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_vatperc, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_scaclient, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_item4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_item2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_curr, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_item3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_batch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_clientno, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 44);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // lbl_item1
            // 
            this.lbl_item1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_item1.AutoSize = true;
            this.lbl_item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item1.Location = new System.Drawing.Point(3, 15);
            this.lbl_item1.Name = "lbl_item1";
            this.lbl_item1.Size = new System.Drawing.Size(1, 13);
            this.lbl_item1.TabIndex = 31;
            this.lbl_item1.Text = "Batch";
            // 
            // txt_scac
            // 
            this.txt_scac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_scac.Location = new System.Drawing.Point(359, 12);
            this.txt_scac.Name = "txt_scac";
            this.txt_scac.Size = new System.Drawing.Size(107, 20);
            this.txt_scac.TabIndex = 32;
            // 
            // txt_vatperc
            // 
            this.txt_vatperc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_vatperc.Location = new System.Drawing.Point(619, 12);
            this.txt_vatperc.Name = "txt_vatperc";
            this.txt_vatperc.Size = new System.Drawing.Size(1, 20);
            this.txt_vatperc.TabIndex = 35;
            this.txt_vatperc.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Scac Client";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Vat Percent";
            // 
            // txt_scaclient
            // 
            this.txt_scaclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_scaclient.Location = new System.Drawing.Point(545, 12);
            this.txt_scaclient.Name = "txt_scaclient";
            this.txt_scaclient.Size = new System.Drawing.Size(73, 20);
            this.txt_scaclient.TabIndex = 34;
            // 
            // lbl_item4
            // 
            this.lbl_item4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_item4.AutoSize = true;
            this.lbl_item4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item4.Location = new System.Drawing.Point(81, 9);
            this.lbl_item4.Name = "lbl_item4";
            this.lbl_item4.Size = new System.Drawing.Size(50, 26);
            this.lbl_item4.TabIndex = 33;
            this.lbl_item4.Text = "Client Number";
            // 
            // lbl_item2
            // 
            this.lbl_item2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_item2.AutoSize = true;
            this.lbl_item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item2.Location = new System.Drawing.Point(317, 15);
            this.lbl_item2.Name = "lbl_item2";
            this.lbl_item2.Size = new System.Drawing.Size(36, 13);
            this.lbl_item2.TabIndex = 28;
            this.lbl_item2.Text = "Scac";
            // 
            // txt_curr
            // 
            this.txt_curr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_curr.Location = new System.Drawing.Point(261, 12);
            this.txt_curr.MaxLength = 3;
            this.txt_curr.Name = "txt_curr";
            this.txt_curr.Size = new System.Drawing.Size(39, 20);
            this.txt_curr.TabIndex = 0;
            // 
            // lbl_item3
            // 
            this.lbl_item3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_item3.AutoSize = true;
            this.lbl_item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item3.Location = new System.Drawing.Point(197, 15);
            this.lbl_item3.Name = "lbl_item3";
            this.lbl_item3.Size = new System.Drawing.Size(57, 13);
            this.lbl_item3.TabIndex = 30;
            this.lbl_item3.Text = "Currency";
            // 
            // txt_batch
            // 
            this.txt_batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_batch.Enabled = false;
            this.txt_batch.Location = new System.Drawing.Point(-2, 12);
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.ReadOnly = true;
            this.txt_batch.Size = new System.Drawing.Size(72, 20);
            this.txt_batch.TabIndex = 27;
            // 
            // txt_clientno
            // 
            this.txt_clientno.AcceptsReturn = true;
            this.txt_clientno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_clientno.Enabled = false;
            this.txt_clientno.Location = new System.Drawing.Point(142, 12);
            this.txt_clientno.Name = "txt_clientno";
            this.txt_clientno.ReadOnly = true;
            this.txt_clientno.Size = new System.Drawing.Size(48, 20);
            this.txt_clientno.TabIndex = 27;
            // 
            // lblscacName
            // 
            this.lblscacName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblscacName.AutoSize = true;
            this.lblscacName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscacName.Location = new System.Drawing.Point(763, 29);
            this.lblscacName.Name = "lblscacName";
            this.lblscacName.Size = new System.Drawing.Size(107, 13);
            this.lblscacName.TabIndex = 38;
            this.lblscacName.Text = "No SCAC Entered";
            // 
            // tabShipment
            // 
            this.tabShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShipment.Location = new System.Drawing.Point(4, 22);
            this.tabShipment.Name = "tabShipment";
            this.tabShipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabShipment.Size = new System.Drawing.Size(1422, 241);
            this.tabShipment.TabIndex = 1;
            this.tabShipment.Text = "Shipment Level Details";
            this.tabShipment.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 739);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.paneltabEntry.ResumeLayout(false);
            this.tabEntryControl.ResumeLayout(false);
            this.tabBatchLevel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBatch.ResumeLayout(false);
            this.groupBatch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_skipBtach;
        private System.Windows.Forms.Panel paneltabEntry;
        private System.Windows.Forms.TabControl tabEntryControl;
        private System.Windows.Forms.TabPage tabBatchLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mastno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_wtflag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_invdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_carracct;
        private System.Windows.Forms.Label lblTbilled;
        private System.Windows.Forms.GroupBox groupBatch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_item1;
        private System.Windows.Forms.TextBox txt_scac;
        private System.Windows.Forms.TextBox txt_vatperc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_scaclient;
        private System.Windows.Forms.Label lbl_item4;
        private System.Windows.Forms.Label lbl_item2;
        private System.Windows.Forms.TextBox txt_curr;
        private System.Windows.Forms.Label lbl_item3;
        private System.Windows.Forms.TextBox txt_batch;
        private System.Windows.Forms.TextBox txt_clientno;
        private System.Windows.Forms.Label lblscacName;
        private System.Windows.Forms.TabPage tabShipment;
    }
}

