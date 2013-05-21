// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities.Tracking;
using VB = Microsoft.VisualBasic;

namespace Microsoft.Samples.SqlServer.Common
{
  public class ActivityStateTrackedEventArgs : EventArgs
  {
    public ActivityStateTrackedEventArgs(ActivityStateRecord state)
    {
      this.ActivityStateRecord = state;
    }

    public ActivityStateRecord ActivityStateRecord;
  }

  public class Tracking : TrackingParticipant
  {
    public delegate void ActivityStateTrackedHandler(object sender, ActivityStateTrackedEventArgs e);

    public event ActivityStateTrackedHandler ActivityStateTracked;

    protected override void Track(TrackingRecord record, TimeSpan timeout)
    {
      if (record != null)
      {
        ActivityStateRecord activityState = (ActivityStateRecord)record;

        if (ActivityStateTracked != null)
          ActivityStateTracked(this, new ActivityStateTrackedEventArgs(activityState));

      }
    }
  }
}


