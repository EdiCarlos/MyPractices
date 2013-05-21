namespace Microsoft.Samples.SqlServer.Common.Forms
{
    partial class DesignerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerForm));
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.workflowDesignerControl = new Microsoft.Samples.SqlServer.Workflow.Designer.WorkflowDesignerControl();
            this.designerToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.activitiesStripButton = new System.Windows.Forms.ToolStripButton();
            this.runToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.workflowActivitiesControl = new Microsoft.Samples.SqlServer.Common.WorkflowActivitiesControl();
            this.designerToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Cursor = System.Windows.Forms.Cursors.Default;
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementHost1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elementHost1.Size = new System.Drawing.Size(976, 736);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.workflowDesignerControl;
            // 
            // designerToolStrip
            // 
            this.designerToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.designerToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.designerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.activitiesStripButton,
            this.runToolStripButton});
            this.designerToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.designerToolStrip.Location = new System.Drawing.Point(0, 0);
            this.designerToolStrip.Name = "designerToolStrip";
            this.designerToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.designerToolStrip.Size = new System.Drawing.Size(976, 27);
            this.designerToolStrip.TabIndex = 1;
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(49, 24);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // activitiesStripButton
            // 
            this.activitiesStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.activitiesStripButton.Image = ((System.Drawing.Image)(resources.GetObject("activitiesStripButton.Image")));
            this.activitiesStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.activitiesStripButton.Name = "activitiesStripButton";
            this.activitiesStripButton.Size = new System.Drawing.Size(73, 24);
            this.activitiesStripButton.Text = "Activities";
            this.activitiesStripButton.Click += new System.EventHandler(this.activitiesStripButton_Click);
            // 
            // runToolStripButton
            // 
            this.runToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.runToolStripButton.Enabled = false;
            this.runToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("runToolStripButton.Image")));
            this.runToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runToolStripButton.Name = "runToolStripButton";
            this.runToolStripButton.Size = new System.Drawing.Size(38, 24);
            this.runToolStripButton.Text = "Run";
            this.runToolStripButton.Visible = false;
            this.runToolStripButton.Click += new System.EventHandler(this.runToolStripButton_Click);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(43, 24);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.splitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer.Location = new System.Drawing.Point(0, 27);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.elementHost1);
            this.splitContainer.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.workflowActivitiesControl);
            this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Panel2Collapsed = true;
            this.splitContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer.Size = new System.Drawing.Size(976, 736);
            this.splitContainer.SplitterDistance = 576;
            this.splitContainer.TabIndex = 2;
            // 
            // workflowActivitiesControl
            // 
            this.workflowActivitiesControl.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.workflowActivitiesControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.workflowActivitiesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workflowActivitiesControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workflowActivitiesControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.workflowActivitiesControl.Location = new System.Drawing.Point(0, 0);
            this.workflowActivitiesControl.Margin = new System.Windows.Forms.Padding(4);
            this.workflowActivitiesControl.Name = "workflowActivitiesControl";
            this.workflowActivitiesControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.workflowActivitiesControl.Size = new System.Drawing.Size(96, 100);
            this.workflowActivitiesControl.TabIndex = 0;
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 763);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.designerToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesignerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Designer";
            this.Load += new System.EventHandler(this.DesignerForm_Load);
            this.designerToolStrip.ResumeLayout(false);
            this.designerToolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Workflow.Designer.WorkflowDesignerControl workflowDesignerControl;
        private System.Windows.Forms.ToolStrip designerToolStrip;
        private System.Windows.Forms.ToolStripButton activitiesStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        public System.Windows.Forms.ToolStripButton runToolStripButton;
        public System.Windows.Forms.SplitContainer splitContainer;
        private WorkflowActivitiesControl workflowActivitiesControl;
        private System.Windows.Forms.ToolStripButton newToolStripButton;



    }
}