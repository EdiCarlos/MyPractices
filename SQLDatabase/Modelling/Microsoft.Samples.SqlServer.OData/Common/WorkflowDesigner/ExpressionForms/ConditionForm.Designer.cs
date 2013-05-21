namespace Microsoft.Samples.SqlServer.Workflow.Designer
{
  partial class ConditionForm
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
      this.appyButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.variablesComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.operatorCombobox = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.valueTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // appyButton
      // 
      this.appyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.appyButton.Location = new System.Drawing.Point(339, 60);
      this.appyButton.Name = "appyButton";
      this.appyButton.Size = new System.Drawing.Size(75, 23);
      this.appyButton.TabIndex = 0;
      this.appyButton.Text = "Apply";
      this.appyButton.UseVisualStyleBackColor = true;
      this.appyButton.Click += new System.EventHandler(this.appyButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.Location = new System.Drawing.Point(420, 60);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 0;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // variablesComboBox
      // 
      this.variablesComboBox.FormattingEnabled = true;
      this.variablesComboBox.Location = new System.Drawing.Point(12, 26);
      this.variablesComboBox.Name = "variablesComboBox";
      this.variablesComboBox.Size = new System.Drawing.Size(173, 21);
      this.variablesComboBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Variable";
      // 
      // operatorCombobox
      // 
      this.operatorCombobox.FormattingEnabled = true;
      this.operatorCombobox.Items.AddRange(new object[] {
            "=",
            "!=",
            "<",
            ">"});
      this.operatorCombobox.Location = new System.Drawing.Point(191, 26);
      this.operatorCombobox.Name = "operatorCombobox";
      this.operatorCombobox.Size = new System.Drawing.Size(93, 21);
      this.operatorCombobox.TabIndex = 1;
      this.operatorCombobox.Text = "=";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(191, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(14, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "is";
      // 
      // valueTextBox
      // 
      this.valueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.valueTextBox.Location = new System.Drawing.Point(290, 26);
      this.valueTextBox.Name = "valueTextBox";
      this.valueTextBox.Size = new System.Drawing.Size(205, 20);
      this.valueTextBox.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(287, 10);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Value";
      // 
      // ConditionForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(497, 95);
      this.Controls.Add(this.valueTextBox);
      this.Controls.Add(this.operatorCombobox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.variablesComboBox);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.appyButton);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConditionForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Condition";
      this.Load += new System.EventHandler(this.ConditionForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button appyButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.ComboBox variablesComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox operatorCombobox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox valueTextBox;
    private System.Windows.Forms.Label label3;
  }
}