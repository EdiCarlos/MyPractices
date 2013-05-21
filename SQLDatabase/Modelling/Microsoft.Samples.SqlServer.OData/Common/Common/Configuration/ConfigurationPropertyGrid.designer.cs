//

namespace Microsoft.Samples.SqlServer.Common
{
  partial class ConfigurationPropertyGrid
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
            this.configPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // configPropertyGrid
            // 
            this.configPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configPropertyGrid.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.configPropertyGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.configPropertyGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configPropertyGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.configPropertyGrid.Location = new System.Drawing.Point(8, 7);
            this.configPropertyGrid.Margin = new System.Windows.Forms.Padding(4);
            this.configPropertyGrid.Name = "configPropertyGrid";
            this.configPropertyGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.configPropertyGrid.Size = new System.Drawing.Size(487, 358);
            this.configPropertyGrid.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(412, 373);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeButton.Size = new System.Drawing.Size(83, 28);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ConfigurationPropertyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 416);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.configPropertyGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationPropertyGrid";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Sample";
            this.Load += new System.EventHandler(this.ConfigurationPropertyGrid_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.PropertyGrid configPropertyGrid;

  }
}