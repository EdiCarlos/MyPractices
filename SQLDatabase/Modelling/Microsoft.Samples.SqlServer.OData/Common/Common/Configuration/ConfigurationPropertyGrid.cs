// Copyright Microsoft

using System;
using System.Windows.Forms;

namespace Microsoft.Samples.SqlServer.Common
{
  public partial class ConfigurationPropertyGrid : Form
  {
    public ConfigurationPropertyGrid()
    {
      InitializeComponent();
    }

    private void ConfigurationPropertyGrid_Load(object sender, EventArgs e)
    {
      configPropertyGrid.SelectedObject = new WorkflowConfiguration();
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      //Sample does not implement all configuration properties
      this.Close();
    }
  }
}
