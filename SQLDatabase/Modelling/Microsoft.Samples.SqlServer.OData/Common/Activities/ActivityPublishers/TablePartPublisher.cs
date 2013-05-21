// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;

namespace Microsoft.Samples.SqlServer.Activities.ActivityPublishers
{
    public class DocumentPart : NativeActivity
    {
        protected override void Execute(NativeActivityContext context) { }
    }

    [Designer(typeof(Microsoft.Samples.SqlServer.Activities.Designers.ActivityPublishers.TablePartPublisherDesigner))]
    public sealed class TablePartPublisher : DocumentPart
    {
        // Define an activity input argument of type string
        public string StyleName { get; set; }
        public string Resource { get; set; }
    }
}
