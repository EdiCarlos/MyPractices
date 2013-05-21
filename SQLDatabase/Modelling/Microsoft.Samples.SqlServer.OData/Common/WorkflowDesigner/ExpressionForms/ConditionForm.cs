// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Activities.Presentation.Model;
using Microsoft.VisualBasic.Activities;
using System.Collections.ObjectModel;
using System.Activities;

namespace Microsoft.Samples.SqlServer.Workflow.Designer
{
  public partial class ConditionForm : Form
  {
    public ModelItem ConditionModelItem { get; set; }
    public Collection<System.Activities.Variable> Variables { get; set; }

    public ConditionForm()
    {
      InitializeComponent();
    }

    private void appyButton_Click(object sender, EventArgs e)
    {
      string expression = String.Format("{0} {1} {2}", variablesComboBox.Text, operatorCombobox.Text, valueTextBox.Text);
      ConditionModelItem.Properties["Condition"].ComputedValue = new VisualBasicValue<Boolean>() { ExpressionText = expression };

      this.Close();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ConditionForm_Load(object sender, EventArgs e)
    {
      variablesComboBox.DataSource = this.Variables;
      variablesComboBox.DisplayMember = "Name";
    }

  }
}
