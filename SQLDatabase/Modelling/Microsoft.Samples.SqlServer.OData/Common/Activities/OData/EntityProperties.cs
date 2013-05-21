// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.Samples.SqlServer.Activities.ActivityPublishers;
using Microsoft.Samples.SqlServer.Activities.Designers.OData;
using System.Xml.Linq;

namespace Microsoft.Samples.SqlServer.Activities
{
    [Designer(typeof(Microsoft.Samples.SqlServer.Activities.EntityPropertiesDesigner))]
    public sealed class EntityProperties : NativeActivity
    {
        public InArgument<Object> Properties { get; set; }

        [Browsable(false)]
        public Activity DocumentPartActivity { get; set; }

        [Browsable(false)]
        public OutArgument<DocumentPart> DocumentPart { get; set; }

        //Cache composite activity metadata
        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);
        }

        protected override void Execute(NativeActivityContext context)
        {
            DocumentPart.Set(context, this.DocumentPartActivity);
        }
    }
}
