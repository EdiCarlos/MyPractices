// Copyright Microsoft

using System;
using Microsoft.Samples.SqlServer.Common;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Threading;
using System.Collections.Generic;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Activities.Tracking;
using System.Xml.Linq;
using System.Linq;
using Microsoft.Samples.SqlServer.Activities.ActivityPublishers;
using Microsoft.Samples.SqlServer.WordAddin.ExtensionMethods;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using Microsoft.Samples.SqlServer.WordAddIn;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms.Integration;

namespace Microsoft.Samples.SqlServer.WordAddin
{
    public class SampleActivity
    {
        private IEnumerable<IEnumerable<EntityProperty>> m_entityProperties;
        public IEnumerable<IEnumerable<EntityProperty>> EntityProperties
        {
            get
            {
                return m_entityProperties;
            }
        }

        public void Run(string workflowPath)
        {
            if (workflowPath != string.Empty)
            {
                Activity wf = (Activity)ActivityXamlServices.Load(workflowPath);
                this.RunWorkflow(new WorkflowApplication(wf));
            }
        }

        private void RunWorkflow(WorkflowApplication wfApp)
        {
            Cursor.Current = Cursors.WaitCursor;
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
                    ActivityName = "*",
                    States = { ActivityStates.Closed },

                    // Extract workflow variables and arguments as a part of the activity tracking record
                    // Variables = "*" allows for extraction of all variables in the scope of the activity
                    // Arguments = "*" allows for extraction of all arguments in the scope of the activity
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
            string heading = string.Empty;

            //Invoke a Treeview method to add all ActivityState names and arguments to Nodes
            if (Globals.ThisAddIn.CustomTaskPanes.Count > 0)
            {
               WorkflowActivitiesControl workflowActivitiesControl = Globals.ThisAddIn.CustomTaskPanes[0].Control as WorkflowActivitiesControl;
               
                workflowActivitiesControl.Invoke(new WorkflowActivitiesControl.AddNodeDelegate
                    (workflowActivitiesControl.AddNode), e.ActivityStateRecord.Activity.Name, e.ActivityStateRecord.Arguments);

            }

            if (e.ActivityStateRecord.Activity.Name == "WriteLine")
            {
                heading = e.ActivityStateRecord.Arguments["Text"].ToString();

                Globals.ThisAddIn.Application.Selection.TypeText(heading + "\r");
            }

            //Entity Properties and TablePartPublisher
            if (e.ActivityStateRecord.Activity.Name == "EntityProperties")
            {
                m_entityProperties = (IEnumerable<IEnumerable<EntityProperty>>)e.ActivityStateRecord.Arguments["Properties"];

                TablePartPublisher tablePart = (TablePartPublisher)e.ActivityStateRecord.Arguments["DocumentPart"];
                if (tablePart != null)
                {
                    Globals.ThisAddIn.Application.Selection.Range.InsertEntityTableXml(m_entityProperties, tablePart.StyleName, tablePart.Resource);
                }
            }

            


        }
  }
}
