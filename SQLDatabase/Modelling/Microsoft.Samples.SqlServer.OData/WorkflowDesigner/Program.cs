using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Samples.SqlServer.Common.Forms;

namespace WorkflowDesigner
{
  static class Program
  {
 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DesignerForm designerForm = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {      
                designerForm = new DesignerForm();
                designerForm.runToolStripButton.Visible = true;
                designerForm.splitContainer.Panel2Collapsed = false;
                Application.Run(designerForm);
            }

            finally
            {
                if (designerForm != null)
                    designerForm.Dispose();
            }
        }
    }
}
