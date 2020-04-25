using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class CreditMemoApprovalHistory
    {
        public int CMApprovalHistoryID { get; set; }
        public int CMRequestID { get; set; }
        public int PlantID { get; set; }
        public int DepartmentID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int CMApprovalStatusID { get; set; }
        public int CMApprovalTransitionID { get; set; }        
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string DepartmentName { get; set; }
        public string PlantName { get; set; }
        public string RoleName { get; set; }
        public string ApprovalName { get; set; }

    }
}
