// Copyright Microsoft

using System;
using System.Collections.Generic;
using Microsoft.Samples.SqlServer.Common;
using System.Windows.Forms;
using System.Threading;
using System.Activities;
using System.Activities.XamlIntegration;
using System.Activities.Tracking;

namespace WorkflowDesigner
{
  class SampleActivity
  {
    private WorkflowActivitiesControl wfActivityContol;

    public SampleActivity(WorkflowActivitiesControl activityContol)
    {
        wfActivityContol = activityContol;
    }

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
                ActivityName = "*",
                States = { ActivityStates.Closed},

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
            }}}
        };

        sampleParticipant.ActivityStateTracked += new Tracking.ActivityStateTrackedHandler(sampleParticipant_ActivityStateTracked);
        wfApp.Extensions.Add(sampleParticipant);

        wfActivityContol.objectsTreeView.Nodes.Clear();

        wfApp.Run();

        Cursor.Current = Cursors.Default;
    }

    void sampleParticipant_ActivityStateTracked(object sender, ActivityStateTrackedEventArgs e)
    {
        wfActivityContol.Invoke(new WorkflowActivitiesControl.AddNodeDelegate
        (wfActivityContol.AddNode), e.ActivityStateRecord.Activity.Name, e.ActivityStateRecord.Arguments);
    }
  }
}
