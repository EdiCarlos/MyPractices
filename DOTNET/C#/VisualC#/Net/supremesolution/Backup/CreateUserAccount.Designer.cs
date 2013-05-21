namespace SupremeTransport
{
    partial class CreateUserAccount
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
            this.Supremetab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboSupUserType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSClear = new System.Windows.Forms.Button();
            this.btnScancel = new System.Windows.Forms.Button();
            this.btnSCreateAccount = new System.Windows.Forms.Button();
            this.txtSupUserPass = new System.Windows.Forms.TextBox();
            this.txtSupUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboZahUserType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.btnZClear = new System.Windows.Forms.Button();
            this.btnZcancel = new System.Windows.Forms.Button();
            this.btnZCreateAccount = new System.Windows.Forms.Button();
            this.txtZahUserPass = new System.Windows.Forms.TextBox();
            this.txtZahUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Supremetab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSupUserType.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboZahUserType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Supremetab
            // 
            this.Supremetab.Controls.Add(this.tabPage1);
            this.Supremetab.Controls.Add(this.tabPage2);
            this.Supremetab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Supremetab.Location = new System.Drawing.Point(0, 0);
            this.Supremetab.Name = "Supremetab";
            this.Supremetab.SelectedIndex = 0;
            this.Supremetab.Size = new System.Drawing.Size(1028, 616);
            this.Supremetab.TabIndex = 1;
            this.Supremetab.Selected += new System.Windows.Forms.TabControlEventHandler(this.Supremetab_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Supreme Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ComboSupUserType);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnSClear);
            this.panel1.Controls.Add(this.btnScancel);
            this.panel1.Controls.Add(this.btnSCreateAccount);
            this.panel1.Controls.Add(this.txtSupUserPass);
            this.panel1.Controls.Add(this.txtSupUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(268, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 335);
            this.panel1.TabIndex = 2;
            // 
            // ComboSupUserType
            // 
            this.ComboSupUserType.Location = new System.Drawing.Point(227, 200);
            this.ComboSupUserType.Name = "ComboSupUserType";
            this.ComboSupUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboSupUserType.Properties.Items.AddRange(new object[] {
            "Admin",
            "Data Entry",
            "Default"});
            this.ComboSupUserType.Size = new System.Drawing.Size(172, 20);
            this.ComboSupUserType.TabIndex = 5;
            this.ComboSupUserType.ToolTip = "Select User Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "User Type";
            // 
            // btnSClear
            // 
            this.btnSClear.Location = new System.Drawing.Point(302, 248);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(75, 23);
            this.btnSClear.TabIndex = 8;
            this.btnSClear.Text = "Cl&ear";
            this.btnSClear.UseVisualStyleBackColor = true;
            // 
            // btnScancel
            // 
            this.btnScancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnScancel.Location = new System.Drawing.Point(203, 248);
            this.btnScancel.Name = "btnScancel";
            this.btnScancel.Size = new System.Drawing.Size(75, 23);
            this.btnScancel.TabIndex = 7;
            this.btnScancel.Text = "&Cancel";
            this.btnScancel.UseVisualStyleBackColor = true;
            // 
            // btnSCreateAccount
            // 
            this.btnSCreateAccount.Location = new System.Drawing.Point(104, 248);
            this.btnSCreateAccount.Name = "btnSCreateAccount";
            this.btnSCreateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnSCreateAccount.TabIndex = 6;
            this.btnSCreateAccount.Text = "&Create";
            this.btnSCreateAccount.UseVisualStyleBackColor = true;
            // 
            // txtSupUserPass
            // 
            this.txtSupUserPass.Location = new System.Drawing.Point(227, 121);
            this.txtSupUserPass.MaxLength = 30;
            this.txtSupUserPass.Name = "txtSupUserPass";
            this.txtSupUserPass.PasswordChar = '*';
            this.txtSupUserPass.Size = new System.Drawing.Size(172, 20);
            this.txtSupUserPass.TabIndex = 4;
            // 
            // txtSupUserName
            // 
            this.txtSupUserName.Location = new System.Drawing.Point(227, 84);
            this.txtSupUserName.MaxLength = 30;
            this.txtSupUserName.Name = "txtSupUserName";
            this.txtSupUserName.Size = new System.Drawing.Size(172, 20);
            this.txtSupUserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(151, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supreme Transport";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zahid Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.comboZahUserType);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnZClear);
            this.panel2.Controls.Add(this.btnZcancel);
            this.panel2.Controls.Add(this.btnZCreateAccount);
            this.panel2.Controls.Add(this.txtZahUserPass);
            this.panel2.Controls.Add(this.txtZahUsername);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(268, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 232);
            this.panel2.TabIndex = 1;
            // 
            // comboZahUserType
            // 
            this.comboZahUserType.Location = new System.Drawing.Point(227, 158);
            this.comboZahUserType.Name = "comboZahUserType";
            this.comboZahUserType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboZahUserType.Properties.Items.AddRange(new object[] {
            "Admin",
            "Data Entry",
            "Default"});
            this.comboZahUserType.Size = new System.Drawing.Size(172, 20);
            this.comboZahUserType.TabIndex = 7;
            this.comboZahUserType.ToolTip = "Select User Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "User Type";
            // 
            // btnZClear
            // 
            this.btnZClear.Location = new System.Drawing.Point(302, 196);
            this.btnZClear.Name = "btnZClear";
            this.btnZClear.Size = new System.Drawing.Size(75, 23);
            this.btnZClear.TabIndex = 10;
            this.btnZClear.Text = "Cl&ear";
            this.btnZClear.UseVisualStyleBackColor = true;
            // 
            // btnZcancel
            // 
            this.btnZcancel.Location = new System.Drawing.Point(203, 196);
            this.btnZcancel.Name = "btnZcancel";
            this.btnZcancel.Size = new System.Drawing.Size(75, 23);
            this.btnZcancel.TabIndex = 9;
            this.btnZcancel.Text = "&Cancel";
            this.btnZcancel.UseVisualStyleBackColor = true;
            // 
            // btnZCreateAccount
            // 
            this.btnZCreateAccount.Location = new System.Drawing.Point(104, 196);
            this.btnZCreateAccount.Name = "btnZCreateAccount";
            this.btnZCreateAccount.Size = new System.Drawing.Size(75, 23);
            this.btnZCreateAccount.TabIndex = 8;
            this.btnZCreateAccount.Text = "&Login";
            this.btnZCreateAccount.UseVisualStyleBackColor = true;
            // 
            // txtZahUserPass
            // 
            this.txtZahUserPass.Location = new System.Drawing.Point(227, 121);
            this.txtZahUserPass.MaxLength = 30;
            this.txtZahUserPass.Name = "txtZahUserPass";
            this.txtZahUserPass.PasswordChar = '*';
            this.txtZahUserPass.Size = new System.Drawing.Size(172, 20);
            this.txtZahUserPass.TabIndex = 6;
            // 
            // txtZahUsername
            // 
            this.txtZahUsername.Location = new System.Drawing.Point(227, 84);
            this.txtZahUsername.MaxLength = 30;
            this.txtZahUsername.Name = "txtZahUsername";
            this.txtZahUsername.Size = new System.Drawing.Size(172, 20);
            this.txtZahUsername.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "User Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "User Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(177, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Zahid Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 157);
            this.textBox1.MaxLength = 30;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Re-Enter  Password";
            // 
            // CreateUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 616);
            this.Controls.Add(this.Supremetab);
            this.Name = "CreateUserAccount";
            this.Text = "CreateUserAccount";
            this.Supremetab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSupUserType.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboZahUserType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Supremetab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit ComboSupUserType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSClear;
        private System.Windows.Forms.Button btnScancel;
        private System.Windows.Forms.Button btnSCreateAccount;
        private System.Windows.Forms.TextBox txtSupUserPass;
        private System.Windows.Forms.TextBox txtSupUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ComboBoxEdit comboZahUserType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnZClear;
        private System.Windows.Forms.Button btnZcancel;
        private System.Windows.Forms.Button btnZCreateAccount;
        private System.Windows.Forms.TextBox txtZahUserPass;
        private System.Windows.Forms.TextBox txtZahUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}