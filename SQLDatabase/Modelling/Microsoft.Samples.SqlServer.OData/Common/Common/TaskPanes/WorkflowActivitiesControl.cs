// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Microsoft.Samples.SqlServer.Common
{
  public partial class WorkflowActivitiesControl : UserControl
  {
    public delegate void AddNodeDelegate(String name, IDictionary<string, object> arguments);

    public void AddNode(String name, IDictionary<string, object> arguments)
    {
        //Add activity name
        TreeNode node;
        node = new TreeNode();
        node.Text = name;
        node.ImageKey = name;
        int argItem = objectsTreeView.Nodes.Add(node);

        //Add activity arguments
        object keyValue = null;
        foreach (KeyValuePair<string, object> kvp in arguments)
        {
        keyValue = kvp.Value;
        if (kvp.Value == null)
            keyValue = string.Empty;
        node = new TreeNode();
        node.Text = kvp.Key + "=" + keyValue.ToString();
        node.ImageKey = "Argument";
        objectsTreeView.Nodes[argItem].Nodes.Add(node);

        if (kvp.Value != null)
        {
            if (kvp.Value.GetType() == typeof(Dictionary<string, string>))
            {
            TreeNode dictionaryNode;
            foreach (KeyValuePair<string, string> argKvp in (Dictionary<string, string>)kvp.Value)
            {
                dictionaryNode = new TreeNode();
                dictionaryNode.Text = argKvp.Key + "=" + argKvp.Value.ToString();
                node.Nodes.Add(dictionaryNode);
            }
            }

        }
        }
    }

    public WorkflowActivitiesControl()
    {
        InitializeComponent();     
    }

  }
}
