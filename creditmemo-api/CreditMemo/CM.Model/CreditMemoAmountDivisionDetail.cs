using System;

namespace CM.Model
{
    public class CreditMemoAmountDivisionDetail
    {
        public int ID { get; set; }
        public int CMRequestID { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public decimal CRAnalystPercent { get; set; }
        public decimal CRAnalystAmount { get; set; }
        public decimal DepartmentPercent { get; set; }
        public decimal DepartmentAmount { get; set; }
        public bool IsApproved { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int AssignedByRoleID { get; set; }
        public int AssignedByDepartmentID { get; set; }
        public int AssignedByPlantID { get; set; }
        public string AssignedByRoleName { get; set; }
        public string AssignedByDepartmentName { get; set; }
        public string AssignedByPlantName { get; set; }
    }
}
