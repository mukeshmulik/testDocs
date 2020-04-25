using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class CreditMemoApprovalTransition
    {
        public int CMApprovalTransitionID { get; set; }
        public int CMRequestID { get; set; }
        public int PlantID { get; set; }
        public int DepartmentID { get; set; }
        public int CMApprovalStatusID { get; set; }
        public string SupervisorApproval { get; set; }
        public string CustomerServiceApproval { get; set; }
        public string VPMarketingApproval { get; set; }
        public string VPFinanceApproval { get; set; }
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string DepartmentName { get; set; }
        public string PlantName { get; set; }
        public string ApprovalName { get; set; }

    }
}
