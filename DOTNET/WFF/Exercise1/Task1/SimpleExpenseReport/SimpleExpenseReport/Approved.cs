using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Windows.Controls;

namespace SimpleExpenseReport
{

    public sealed class Approved : CodeActivity
    {
        public InArgument<string> Text { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
           IApproval approveAction = context.GetExtension<IApproval>();
           if (approveAction != null)
           {
               approveAction.Approve();
           }
        }
    }
}
