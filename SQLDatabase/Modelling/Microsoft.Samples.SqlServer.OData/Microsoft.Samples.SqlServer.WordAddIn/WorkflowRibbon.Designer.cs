namespace Microsoft.Samples.SqlServer.WordAddIn
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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.oDataGroup = this.Factory.CreateRibbonGroup();
            this.configurationButton = this.Factory.CreateRibbonButton();
            this.designButton = this.Factory.CreateRibbonButton();
            this.getFeedGallery = this.Factory.CreateRibbonGallery();
            this.tab1.SuspendLayout();
            this.oDataGroup.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabDeveloper";
            this.tab1.Groups.Add(this.oDataGroup);
            this.tab1.Label = "TabDeveloper";
            this.tab1.Name = "tab1";
            // 
            // oDataGroup
            // 
            ribbonDialogLauncherImpl1.ScreenTip = "Design Workflow";
            ribbonDialogLauncherImpl1.SuperTip = "Design Workflow";
            this.oDataGroup.DialogLauncher = ribbonDialogLauncherImpl1;
            this.oDataGroup.Items.Add(this.configurationButton);
            this.oDataGroup.Items.Add(this.designButton);
            this.oDataGroup.Items.Add(this.getFeedGallery);
            this.oDataGroup.Label = "OData";
            this.oDataGroup.Name = "oDataGroup";
            this.oDataGroup.DialogLauncherClick += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.oDataGroup_DialogLauncherClick);
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
            // designButton
            // 
            this.designButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.designButton.Label = "Design";
            this.designButton.Name = "designButton";
            this.designButton.OfficeImageId = "TableDesign";
            this.designButton.ShowImage = true;
            this.designButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.designButton_Click);
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
            // WorkflowRibbon
            // 
            this.Name = "WorkflowRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.oDataGroup.ResumeLayout(false);
            this.oDataGroup.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup oDataGroup;
        internal Office.Tools.Ribbon.RibbonButton configurationButton;
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
