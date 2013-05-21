namespace Microsoft.Samples.SqlServer.ExcelAddIn
{
  partial class WorkflowRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public WorkflowRibbon()
      : base(Globals.Factory.GetRibbonFactory())
    {
      InitializeComponent();
    }

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
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.workflowTab = this.Factory.CreateRibbonTab();
            this.generalGroup = this.Factory.CreateRibbonGroup();
            this.configurationButton = this.Factory.CreateRibbonButton();
            this.getFeedGallery = this.Factory.CreateRibbonGallery();
            this.designButton = this.Factory.CreateRibbonButton();
            this.workflowTab.SuspendLayout();
            this.generalGroup.SuspendLayout();
            // 
            // workflowTab
            // 
            this.workflowTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.workflowTab.ControlId.OfficeId = "TabDeveloper";
            this.workflowTab.Groups.Add(this.generalGroup);
            this.workflowTab.Label = "TabDeveloper";
            this.workflowTab.Name = "workflowTab";
            // 
            // generalGroup
            // 
            this.generalGroup.DialogLauncher = ribbonDialogLauncherImpl1;
            this.generalGroup.Items.Add(this.configurationButton);
            this.generalGroup.Items.Add(this.designButton);
            this.generalGroup.Items.Add(this.getFeedGallery);
            this.generalGroup.Label = "OData";
            this.generalGroup.Name = "generalGroup";
            this.generalGroup.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.generalGroup_DialogLauncherClick);
            // 
            // configurationButton
            // 
            this.configurationButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.configurationButton.Label = "Configuration";
            this.configurationButton.Name = "configurationButton";
            this.configurationButton.OfficeImageId = "PropertySheet";
            this.configurationButton.ShowImage = true;
            this.configurationButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.configurationButton_Click);
            // 
            // getFeedGallery
            // 
            this.getFeedGallery.ColumnCount = 1;
            this.getFeedGallery.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.getFeedGallery.Label = "Get Feed";
            this.getFeedGallery.Name = "getFeedGallery";
            this.getFeedGallery.OfficeImageId = "Filter";
            this.getFeedGallery.ShowImage = true;
            this.getFeedGallery.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.getFeedGallery_Click);
            this.getFeedGallery.ItemsLoading += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.getFeedGallery_ItemsLoading);
            // 
            // designButton
            // 
            this.designButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.designButton.Label = "Design";
            this.designButton.Name = "designButton";
            this.designButton.OfficeImageId = "TableDesign";
            this.designButton.ShowImage = true;
            this.designButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.designButton_Click);
            // 
            // WorkflowRibbon
            // 
            this.Name = "WorkflowRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.workflowTab);
            this.workflowTab.ResumeLayout(false);
            this.workflowTab.PerformLayout();
            this.generalGroup.ResumeLayout(false);
            this.generalGroup.PerformLayout();

    }

    #endregion

    internal Microsoft.Office.Tools.Ribbon.RibbonTab workflowTab;
    internal Microsoft.Office.Tools.Ribbon.RibbonGroup generalGroup;
    internal Microsoft.Office.Tools.Ribbon.RibbonButton configurationButton;
    internal Office.Tools.Ribbon.RibbonGallery getFeedGallery;
    internal Office.Tools.Ribbon.RibbonButton designButton;
  }

  partial class ThisRibbonCollection
  {
    internal WorkflowRibbon WorkflowRibbon
    {
      get { return this.GetRibbon<WorkflowRibbon>(); }
    }
  }
}
