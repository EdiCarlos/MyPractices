namespace csPortScanner
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            this.txtTragetIP = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.lblIPScanned = new System.Windows.Forms.Label();
            this.lblClosedPorts = new System.Windows.Forms.Label();
            this.lblOpenPorts = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtEndPort = new System.Windows.Forms.TextBox();
            this.txtThreadCount = new System.Windows.Forms.TextBox();
            this.txtStartPort = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvwResults = new System.Windows.Forms.ListView();
            this.IPAddress = new System.Windows.Forms.ColumnHeader();
            this.Port = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.txtEndIP = new System.Windows.Forms.TextBox();
            this.lblCurrIP = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTragetIP
            // 
            this.txtTragetIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTragetIP.Location = new System.Drawing.Point(12, 25);
            this.txtTragetIP.Name = "txtTragetIP";
            this.txtTragetIP.Size = new System.Drawing.Size(116, 20);
            this.txtTragetIP.TabIndex = 0;
            this.txtTragetIP.Text = "127.0.0.1";
            this.txtTragetIP.TextChanged += new System.EventHandler(this.txtTragetIP_TextChanged);
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(280, 21);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(102, 28);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Start Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lblIPScanned
            // 
            this.lblIPScanned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIPScanned.Location = new System.Drawing.Point(352, 252);
            this.lblIPScanned.Name = "lblIPScanned";
            this.lblIPScanned.Size = new System.Drawing.Size(37, 13);
            this.lblIPScanned.TabIndex = 22;
            this.lblIPScanned.Text = "0";
            // 
            // lblClosedPorts
            // 
            this.lblClosedPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClosedPorts.Location = new System.Drawing.Point(352, 235);
            this.lblClosedPorts.Name = "lblClosedPorts";
            this.lblClosedPorts.Size = new System.Drawing.Size(37, 13);
            this.lblClosedPorts.TabIndex = 23;
            this.lblClosedPorts.Text = "0";
            // 
            // lblOpenPorts
            // 
            this.lblOpenPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpenPorts.Location = new System.Drawing.Point(352, 217);
            this.lblOpenPorts.Name = "lblOpenPorts";
            this.lblOpenPorts.Size = new System.Drawing.Size(37, 13);
            this.lblOpenPorts.TabIndex = 24;
            this.lblOpenPorts.Text = "0";
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(277, 188);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(99, 16);
            this.Label6.TabIndex = 20;
            this.Label6.Text = "Scan Results";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(266, 217);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Open Ports:";
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(266, 252);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(71, 13);
            this.Label7.TabIndex = 19;
            this.Label7.Text = "IPs Scanned:";
            // 
            // Label4
            // 
            this.Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(266, 235);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(69, 13);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Closed Ports:";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(266, 89);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "End Port";
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(266, 141);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(46, 13);
            this.Label8.TabIndex = 15;
            this.Label8.Text = "Threads";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(266, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Start Port";
            // 
            // txtEndPort
            // 
            this.txtEndPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndPort.Location = new System.Drawing.Point(323, 86);
            this.txtEndPort.Name = "txtEndPort";
            this.txtEndPort.Size = new System.Drawing.Size(66, 20);
            this.txtEndPort.TabIndex = 4;
            this.txtEndPort.Text = "1000";
            // 
            // txtThreadCount
            // 
            this.txtThreadCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThreadCount.Location = new System.Drawing.Point(323, 138);
            this.txtThreadCount.Name = "txtThreadCount";
            this.txtThreadCount.Size = new System.Drawing.Size(66, 20);
            this.txtThreadCount.TabIndex = 6;
            this.txtThreadCount.Text = "100";
            // 
            // txtStartPort
            // 
            this.txtStartPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartPort.Location = new System.Drawing.Point(323, 59);
            this.txtStartPort.Name = "txtStartPort";
            this.txtStartPort.Size = new System.Drawing.Size(66, 20);
            this.txtStartPort.TabIndex = 3;
            this.txtStartPort.Text = "0";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(269, 281);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(113, 21);
            this.ProgressBar.TabIndex = 25;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeOut.Location = new System.Drawing.Point(323, 112);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(66, 20);
            this.txtTimeOut.TabIndex = 5;
            this.txtTimeOut.Text = "150";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Target IP Address(s)";
            // 
            // lvwResults
            // 
            this.lvwResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IPAddress,
            this.Port,
            this.Status});
            this.lvwResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7});
            this.lvwResults.Location = new System.Drawing.Point(12, 47);
            this.lvwResults.Name = "lvwResults";
            this.lvwResults.Size = new System.Drawing.Size(247, 257);
            this.lvwResults.TabIndex = 26;
            this.lvwResults.UseCompatibleStateImageBehavior = false;
            this.lvwResults.View = System.Windows.Forms.View.Details;
            // 
            // IPAddress
            // 
            this.IPAddress.Text = "IP Address";
            this.IPAddress.Width = 94;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 79;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // txtEndIP
            // 
            this.txtEndIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndIP.Location = new System.Drawing.Point(143, 25);
            this.txtEndIP.Name = "txtEndIP";
            this.txtEndIP.Size = new System.Drawing.Size(116, 20);
            this.txtEndIP.TabIndex = 1;
            this.txtEndIP.Text = "127.0.0.1";
            // 
            // lblCurrIP
            // 
            this.lblCurrIP.Location = new System.Drawing.Point(146, 7);
            this.lblCurrIP.Name = "lblCurrIP";
            this.lblCurrIP.Size = new System.Drawing.Size(112, 14);
            this.lblCurrIP.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 316);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCurrIP);
            this.Controls.Add(this.lvwResults);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.lblIPScanned);
            this.Controls.Add(this.lblClosedPorts);
            this.Controls.Add(this.lblOpenPorts);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.txtEndPort);
            this.Controls.Add(this.txtThreadCount);
            this.Controls.Add(this.txtStartPort);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtEndIP);
            this.Controls.Add(this.txtTragetIP);
            this.Name = "frmMain";
            this.Text = "C# Port Scanner";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTragetIP;
        private System.Windows.Forms.Button btnScan;
        internal System.Windows.Forms.Label lblIPScanned;
        internal System.Windows.Forms.Label lblClosedPorts;
        internal System.Windows.Forms.Label lblOpenPorts;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtEndPort;
        internal System.Windows.Forms.TextBox txtThreadCount;
        internal System.Windows.Forms.TextBox txtStartPort;
        internal System.Windows.Forms.ProgressBar ProgressBar;
        internal System.Windows.Forms.TextBox txtTimeOut;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvwResults;
        private System.Windows.Forms.ColumnHeader IPAddress;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox txtEndIP;
        private System.Windows.Forms.Label lblCurrIP;
        private System.Windows.Forms.Label label10;
    }
}

