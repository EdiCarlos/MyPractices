namespace Crom.Controls.Test.Forms
{
    partial class MyForm
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
            this.dockContainer1 = new Crom.Controls.Docking.DockContainer();
            this.SuspendLayout();
            // 
            // dockContainer1
            // 
            this.dockContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.dockContainer1.Location = new System.Drawing.Point(12, 32);
            this.dockContainer1.Name = "dockContainer1";
            this.dockContainer1.Size = new System.Drawing.Size(708, 384);
            this.dockContainer1.TabIndex = 0;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 420);
            this.Controls.Add(this.dockContainer1);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Crom.Controls.Docking.DockContainer dockContainer1;

    }
}