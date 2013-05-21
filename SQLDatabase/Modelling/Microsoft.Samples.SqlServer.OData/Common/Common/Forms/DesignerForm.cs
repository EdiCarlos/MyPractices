// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Samples.SqlServer.Common;

namespace Microsoft.Samples.SqlServer.Common.Forms
{
    public partial class DesignerForm : Form
    {
        public string ClientName = string.Empty;

        //-private string workflowPath = string.Empty;

        public DesignerForm()
        {
            InitializeComponent();          
        }

        public string WorkflowPath
        {
            get
            {
                return workflowDesignerControl.WorkflowPath;
            }
        }

        void activitiesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            activitiesStripButton.Enabled = true;
        }

        private void DesignerForm_Load(object sender, EventArgs e){ }

        private void activitiesStripButton_Click(object sender, EventArgs e)
        {
            ActivitiesForm activitiesForm = new ActivitiesForm();
            activitiesForm.FormClosed += activitiesForm_FormClosed;
            activitiesForm.Top = 100;
            activitiesForm.Left = 100;
            activitiesForm.Show(new MyWin32Window(this.Handle));
            activitiesStripButton.Enabled = false;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            DialogResult result = openDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string workflowPath = openDialog.FileName;
                workflowDesignerControl.ClientName = this.ClientName;
                workflowDesignerControl.Load(workflowPath);
                this.runToolStripButton.Enabled = true;
                this.Text = String.Format("Designer - {0}", workflowPath);
            }
        }

        private void runToolStripButton_Click(object sender, EventArgs e)
        {
            SampleActivity sampleActivity = new SampleActivity(workflowActivitiesControl);
            sampleActivity.Run(workflowDesignerControl.WorkflowPath);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            workflowDesignerControl.ClientName = this.ClientName;
            workflowDesignerControl.New();
            this.runToolStripButton.Enabled = true;
            this.Text = String.Format("Designer - New");
        }
    }

    /// <summary>
    /// This class can be used to show a Toolform as a child window.
    /// For example, form.Show(new MyWin32Window(System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle));
    /// </summary>
    public class MyWin32Window : System.Windows.Forms.IWin32Window
    {
        private IntPtr _hwnd;

        public MyWin32Window(IntPtr handle)
        {
            _hwnd = handle;
        }

        public IntPtr Handle
        {
            get
            {
                return _hwnd;
            }
        }
    }
}
