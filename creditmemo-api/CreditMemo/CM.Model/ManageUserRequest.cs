using System;

namespace CM.Model
{
    public class ManageUserRequest
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string GlobalID { get; set; }
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public string ContactNo { get; set; }
        public string DepartmentName { get; set; }
        public string CreditAmount { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int DepartmentID { get; set; }
        public int CreditAmountID { get; set; }
        public string PlantName { get; set; }
        public int PlantID { get; set; }
        public int RecordStatusID { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
