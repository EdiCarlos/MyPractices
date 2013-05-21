// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Activities.Tracking;
using Microsoft.Office.Interop.Excel;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using Microsoft.Samples.SqlServer.Activities.ActivityPublishers;
using Microsoft.Samples.SqlServer.Common;
using Microsoft.Samples.SqlServer.ExcelAddIn.Extensions;

namespace Microsoft.Samples.SqlServer.ExcelAddIn.SampleWorkflow
{
  class SampleActivity
  {
    public void Run(string workflowPath)
    {
      Cursor.Current = Cursors.WaitCursor;

      Activity wf = (Activity)ActivityXamlServices.Load(workflowPath);

      WorkflowApplication wfApp = new WorkflowApplication(wf);

      Tracking sampleParticipant = new Tracking
      {
        TrackingProfile = new TrackingProfile()
        {
          Name = "CustomTrackingProfile",
          Queries = 
        {
           new ActivityStateQuery()
          {
              // Subscribe for track records from all activities for all states
              //ActivityName = "*"
              //ActivityStates.Closed
              ActivityName = "*",
              States = { ActivityStates.Closed },

              // Extract workflow variables and arguments as a part of the activity tracking record
              // VariableName = "*" allows for extraction of all variables in the scope
              // of the activity
              Variables = 
              {                                
                  { "*" }
              },
              Arguments = 
              {
                  { "*" }
              }
          }   
        }
        }

      };

      sampleParticipant.ActivityStateTracked += new Tracking.ActivityStateTrackedHandler(sampleParticipant_ActivityStateTracked);
      wfApp.Extensions.Add(sampleParticipant);

      if (Globals.ThisAddIn.CustomTaskPanes.Count > 0)
      {
          WorkflowActivitiesControl workflowActivities = Globals.ThisAddIn.CustomTaskPanes[0].Control as WorkflowActivitiesControl;
          workflowActivities.objectsTreeView.Nodes.Clear();
      }

      wfApp.Run();

      Cursor.Current = Cursors.Default;
    }

    void sampleParticipant_ActivityStateTracked(object sender, ActivityStateTrackedEventArgs e)
    {
        //Invoke a Treeview method to add all ActivityState names and arguments to Nodes
        if (Globals.ThisAddIn.CustomTaskPanes.Count > 0)
        {
            WorkflowActivitiesControl workflowActivities = Globals.ThisAddIn.CustomTaskPanes[0].Control as WorkflowActivitiesControl;
            workflowActivities.Invoke(new WorkflowActivitiesControl.AddNodeDelegate
                (workflowActivities.AddNode), e.ActivityStateRecord.Activity.Name, e.ActivityStateRecord.Arguments);
        }

        if (e.ActivityStateRecord.Activity.Name == "WriteLine")
        {
            string text = e.ActivityStateRecord.Arguments["Text"].ToString();
            Globals.ThisAddIn.Application.ActiveCell.FormulaR1C1 = text;
        }

        //Sample uses Excel Automation. It could use XML Mapping
        if (e.ActivityStateRecord.Activity.Name == "EntityProperties")
        {
            IEnumerable<IEnumerable<EntityProperty>> entityProperties =
                (IEnumerable<IEnumerable<EntityProperty>>)e.ActivityStateRecord.Arguments["Properties"];

            TablePartPublisher tablePart = (TablePartPublisher)e.ActivityStateRecord.Arguments["DocumentPart"];
            if (tablePart != null)
            {
                string styleName = tablePart.StyleName.ToString();

                Globals.ThisAddIn.Application.ActiveCell.InsertEntityTable(entityProperties, styleName);
            }
        }

    }
  }
}
