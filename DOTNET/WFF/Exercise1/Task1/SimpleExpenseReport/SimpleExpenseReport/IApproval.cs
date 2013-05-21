using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleExpenseReport
{
    public interface IApproval
    {
        Action Approve { get; set; }
        Action Reject { get; set; }
        Action TaskCompleted { get; set; }
    }
}
