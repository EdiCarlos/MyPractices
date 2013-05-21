// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Threading;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Activities.Tracking;
using Microsoft.Samples.SqlServer.Common;
using VB = Microsoft.VisualBasic;
using System.IO;
using System.Xml;
using Microsoft.Samples.SqlServer.ExcelAddIn.SampleWorkflow;
using Microsoft.Office.Tools;
using Microsoft.Samples.SqlServer.Common.Forms;

namespace Microsoft.Samples.SqlServer.ExcelAddIn
{
    public partial class WorkflowRibbon
    {
        private DesignerForm designerForm;
        private WorkflowConfiguration config = new WorkflowConfiguration();

        public CustomTaskPane TaskPane {get; set; }

        private void ShowActivitiesCTP()
        {
            if (TaskPane == null)
            {
                TaskPane = Globals.ThisAddIn.CustomTaskPanes.Add(new WorkflowActivitiesControl(), "Workflow Activity Tracking");
                TaskPane.Visible = true;
            }
            else
            {
                TaskPane.Visible = true;
            }
        }

        private void configurationButton_Click(object sender, RibbonControlEventArgs e)
        {
            ConfigurationPropertyGrid configForm = new ConfigurationPropertyGrid();

            try
            {
                configForm.ShowDialog();
            }
            finally
            {
                if (configForm != null)
                    configForm.Dispose();
            }
        }

        private void getFeedGallery_Click(object sender, RibbonControlEventArgs e)
        {
            this.ShowActivitiesCTP();
            SampleActivity sampleActivity = new SampleActivity();
            sampleActivity.Run(string.Format(@"{0}\{1}", getFeedGallery.SelectedItem.Tag, getFeedGallery.SelectedItem.Label));
        }

        private void generalGroup_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            this.DesignWorkflow();  
        }

        private void getFeedGallery_ItemsLoading(object sender, RibbonControlEventArgs e)
        {
            if (config.WorkflowPath != string.Empty && config.WorkflowPath != null)
            {
                getFeedGallery.Items.Clear();
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(config.WorkflowPath);
                IEnumerable<FileInfo> fileList = dir.GetFiles("*.xaml");

                foreach (FileInfo file in fileList)
                {
                    RibbonDropDownItem ribbonItem = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                    ribbonItem.Label = file.Name;
                    ribbonItem.Tag = config.WorkflowPath;
                    getFeedGallery.Items.Add(ribbonItem);
                }
            }
        }

        private void designButton_Click(object sender, RibbonControlEventArgs e)
        {
            this.DesignWorkflow();
        }

        private void DesignWorkflow()
        {
            designerForm = new DesignerForm();
            designerForm.runToolStripButton.Visible = true;
            designerForm.runToolStripButton.Click += new EventHandler(runToolStripButton_Click);
            designerForm.Show(new MyWin32Window(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle));
        }

        void runToolStripButton_Click(object sender, EventArgs e)
        {
            this.ShowActivitiesCTP();
            SampleActivity sampleActivity = new SampleActivity();
            sampleActivity.Run(designerForm.WorkflowPath);
        }

      }
}
