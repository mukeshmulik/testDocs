using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class CreditMemoApprovalStatus
    {
        public int CMApprovalStatusID { get; set; }
        public string ApprovalName { get; set; }
        public string ApprovalDescription { get; set; }
        public int RecordStatusID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
