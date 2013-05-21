using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleExpenseReport
{
    public class Approval : IApproval
    {

        #region IApproval Members
        public Action Approve { get; set; }
        public Action Reject { get; set; }
        public Action TaskCompleted { get; set; }

        #endregion
    }
}
