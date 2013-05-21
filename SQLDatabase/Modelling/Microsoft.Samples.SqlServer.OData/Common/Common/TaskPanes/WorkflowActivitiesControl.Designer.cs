

//using Microsoft.Samples.SqlServer.Workflow.Designer;
namespace Microsoft.Samples.SqlServer.Common
{
  partial class WorkflowActivitiesControl
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkflowActivitiesControl));
            this.objectsTreeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.activitiesTabControl = new System.Windows.Forms.TabControl();
            this.tackingTabPage = new System.Windows.Forms.TabPage();
            this.activitiesTabControl.SuspendLayout();
            this.tackingTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectsTreeView
            // 
            this.objectsTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectsTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectsTreeView.ImageIndex = 0;
            this.objectsTreeView.ImageList = this.imageList;
            this.objectsTreeView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.objectsTreeView.LabelEdit = true;
            this.objectsTreeView.Location = new System.Drawing.Point(3, 3);
            this.objectsTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.objectsTreeView.Name = "objectsTreeView";
            this.objectsTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.objectsTreeView.SelectedImageIndex = 0;
            this.objectsTreeView.Size = new System.Drawing.Size(405, 555);
            this.objectsTreeView.TabIndex = 1;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "QueryFeed.png");
            this.imageList.Images.SetKeyName(1, "FormattingActivity");
            this.imageList.Images.SetKeyName(2, "Permissions");
            this.imageList.Images.SetKeyName(3, "Assign");
            this.imageList.Images.SetKeyName(4, "FlowSwitch");
            this.imageList.Images.SetKeyName(5, "FlowDescision");
            this.imageList.Images.SetKeyName(6, "Flowchart");
            this.imageList.Images.SetKeyName(7, "while");
            this.imageList.Images.SetKeyName(8, "DoWhile");
            this.imageList.Images.SetKeyName(9, "foreach");
            this.imageList.Images.SetKeyName(10, "if");
            this.imageList.Images.SetKeyName(11, "Switch");
            this.imageList.Images.SetKeyName(12, "Sequence");
            this.imageList.Images.SetKeyName(13, "ExpressionMenu");
            this.imageList.Images.SetKeyName(14, "Form");
            this.imageList.Images.SetKeyName(15, "Value");
            this.imageList.Images.SetKeyName(16, "ListItems");
            this.imageList.Images.SetKeyName(17, "NotePanelFormActivity");
            this.imageList.Images.SetKeyName(18, "DynamicActivity");
            this.imageList.Images.SetKeyName(19, "Argument");
            this.imageList.Images.SetKeyName(20, "Values");
            this.imageList.Images.SetKeyName(21, "RangePartActivity");
            this.imageList.Images.SetKeyName(22, "LoginFormActivity");
            this.imageList.Images.SetKeyName(23, "AddItem");
            this.imageList.Images.SetKeyName(24, "Items");
            this.imageList.Images.SetKeyName(25, "DocumentParts");
            this.imageList.Images.SetKeyName(26, "WriteLine");
            this.imageList.Images.SetKeyName(27, "EntityProperties");
            // 
            // activitiesTabControl
            // 
            this.activitiesTabControl.Controls.Add(this.tackingTabPage);
            this.activitiesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesTabControl.Location = new System.Drawing.Point(0, 0);
            this.activitiesTabControl.Name = "activitiesTabControl";
            this.activitiesTabControl.SelectedIndex = 0;
            this.activitiesTabControl.Size = new System.Drawing.Size(419, 590);
            this.activitiesTabControl.TabIndex = 2;
            // 
            // tackingTabPage
            // 
            this.tackingTabPage.Controls.Add(this.objectsTreeView);
            this.tackingTabPage.Location = new System.Drawing.Point(4, 25);
            this.tackingTabPage.Name = "tackingTabPage";
            this.tackingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tackingTabPage.Size = new System.Drawing.Size(411, 561);
            this.tackingTabPage.TabIndex = 0;
            this.tackingTabPage.Text = "Tracking";
            this.tackingTabPage.UseVisualStyleBackColor = true;
            // 
            // WorkflowActivitiesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.activitiesTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkflowActivitiesControl";
            this.Size = new System.Drawing.Size(419, 590);
            this.activitiesTabControl.ResumeLayout(false);
            this.tackingTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.TreeView objectsTreeView;
    private System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.TabPage tackingTabPage;
    private System.Windows.Forms.TabControl activitiesTabControl;
  }
}
