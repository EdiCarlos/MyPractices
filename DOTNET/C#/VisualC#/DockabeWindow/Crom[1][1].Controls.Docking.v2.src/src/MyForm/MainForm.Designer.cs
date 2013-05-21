namespace MyForm
{
    partial class MainForm
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
            this._docker = new Crom.Controls.Docking.DockContainer();
            this.SuspendLayout();
            // 
            // _docker
            // 
            this._docker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this._docker.Dock = System.Windows.Forms.DockStyle.Fill;
            this._docker.Location = new System.Drawing.Point(0, 0);
            this._docker.Name = "_docker";
            this._docker.Size = new System.Drawing.Size(656, 443);
            this._docker.TabIndex = 0;
            this._docker.FormClosed += new System.EventHandler<Crom.Controls.Docking.FormEventArgs>(this._docker_FormClosed);
            this._docker.FormClosing += new System.EventHandler<Crom.Controls.Docking.DockableFormClosingEventArgs>(this._docker_FormClosing);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 443);
            this.Controls.Add(this._docker);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        //private Crom.Controls.Docking.DockContainer _docker;
    }
}

