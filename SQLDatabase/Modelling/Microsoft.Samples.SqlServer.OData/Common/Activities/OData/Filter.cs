// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.ComponentModel;

namespace Microsoft.Samples.SqlServer.Activities
{
    public enum ComparisonOperatorEnum
    {
        Eq, Ne, Gt, Ge, Lt, Le
    }

    //NEXT: Convert to ComboBox style
    public enum LogicalOperatorEnum
    {
        End, And, Or
    }

    [Designer(typeof(Microsoft.Samples.SqlServer.Activities.Designers.FilterDesigner))]
    public sealed class Filter : Activity
    {
        public string Name { get; set; }
        public ComparisonOperatorEnum ComparisonOperator { get; set; }
        public object Value { get; set; }

        //NEXT: Convert to ComboBox style
        public LogicalOperatorEnum LogicalOperator { get; set; }
    }
}
