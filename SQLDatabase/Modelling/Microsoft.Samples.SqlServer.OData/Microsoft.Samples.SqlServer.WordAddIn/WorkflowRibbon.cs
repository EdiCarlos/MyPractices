// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Samples.SqlServer.WordAddin;
using Microsoft.Samples.SqlServer.Common;
using Microsoft.Samples.SqlServer.Common.Forms;
using System.IO;
using System.Windows.Media.Imaging;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using Microsoft.Samples.SqlServer.WordAddin.ExtensionMethods;
using Microsoft.Office.Tools;

namespace Microsoft.Samples.SqlServer.WordAddIn
{
    public partial class WorkflowRibbon
    {
        private DesignerForm designerForm;
        private WorkflowConfiguration config = new WorkflowConfiguration();

        private SampleActivity m_sampleActivity = null;

        public SampleActivity Activity
        {
            get
            {
                if (m_sampleActivity == null)
                    m_sampleActivity = new SampleActivity();
                return m_sampleActivity;
            }
        }

        public CustomTaskPane TaskPane { get; set; }

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

            this.Activity.Run(string.Format(@"{0}\{1}", getFeedGallery.SelectedItem.Tag, getFeedGallery.SelectedItem.Label));
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

        private void oDataGroup_DialogLauncherClick(object sender, RibbonControlEventArgs e)
        {
            this.DesignWorkflow();
        }

        private void designButton_Click(object sender, RibbonControlEventArgs e)
        {
            this.DesignWorkflow();
        }

        private void DesignWorkflow()
        {
            designerForm = new DesignerForm();
            designerForm.runToolStripButton.Visible = true;
            designerForm.ClientName = "Word";
            designerForm.runToolStripButton.Click += new EventHandler(runToolStripButton_Click);
            designerForm.Show(new MyWin32Window(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle));
        }
        void runToolStripButton_Click(object sender, EventArgs e)
        {
            this.ShowActivitiesCTP();
            m_sampleActivity = new SampleActivity();
            m_sampleActivity.Run(designerForm.WorkflowPath);
        }
    }
}
