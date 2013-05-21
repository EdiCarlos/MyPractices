namespace ValidationOfControls
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
            this.components = new System.ComponentModel.Container();
            this.txtEmployeename = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeename
            // 
            this.txtEmployeename.Location = new System.Drawing.Point(198, 67);
            this.txtEmployeename.Name = "txtEmployeename";
            this.txtEmployeename.Size = new System.Drawing.Size(106, 20);
            this.txtEmployeename.TabIndex = 0;
            this.txtEmployeename.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmployeename_Validating);
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(198, 93);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(106, 20);
            this.txtdob.TabIndex = 1;
            this.txtdob.Validating += new System.ComponentModel.CancelEventHandler(this.txtdob_Validating);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(198, 119);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(106, 20);
            this.txtphone.TabIndex = 2;
            this.txtphone.Validating += new System.ComponentModel.CancelEventHandler(this.txtphone_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(96, 67);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(84, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "phone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.CausesValidation = false;
            this.button2.Location = new System.Drawing.Point(229, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtEmployeename);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeename;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

