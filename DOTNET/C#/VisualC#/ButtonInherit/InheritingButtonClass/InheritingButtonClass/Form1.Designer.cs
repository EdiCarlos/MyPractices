namespace InheritingButtonClass
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
            this.loginControl1 = new MyButton.LoginControl();
            this.mButton1 = new InheritingButtonClass.MButton();
            this.SuspendLayout();
            // 
            // loginControl1
            // 
            this.loginControl1.Location = new System.Drawing.Point(24, 29);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Password = null;
            this.loginControl1.Size = new System.Drawing.Size(256, 129);
            this.loginControl1.TabIndex = 1;
            this.loginControl1.Username = null;
            this.loginControl1.BtnHandler += new System.EventHandler(this.loginControl1_BtnHandler);
            this.loginControl1.BtnClearHandler += new System.EventHandler(this.loginControl1_BtnClearHandler);
            // 
            // mButton1
            // 
            this.mButton1.Id = "MButton";
            this.mButton1.Location = new System.Drawing.Point(96, 195);
            this.mButton1.Name = "mButton1";
            this.mButton1.Size = new System.Drawing.Size(75, 23);
            this.mButton1.TabIndex = 0;
            this.mButton1.Text = "mButton1";
            this.mButton1.UseVisualStyleBackColor = true;
            this.mButton1.MouseDownHandler += new System.Windows.Forms.MouseEventHandler(this.mButton1_MouseDownHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.mButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MButton mButton1;
        private MyButton.LoginControl loginControl1;
    }
}

