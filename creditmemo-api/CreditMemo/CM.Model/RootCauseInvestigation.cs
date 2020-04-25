using System;

namespace CM.Model
{
    public class RootCauseInvestigation
    {
        public int CMRequestID { get; set; }
        public int DepartmentID { get; set; }
        public string Department { get; set; }
        public int UserID { get; set; }
        public bool IsNotified { get; set; }
        public bool IsExtensionRequested { get; set; }
        public bool IsEscalatedWithinDept { get; set; }
        public bool IsEscalatedToSuperAdmin { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public string RootCause { get; set; }
        public string PlantResponse { get; set; }
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string GlobalID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        //public DateTime ModifiedOn { get; set; }
        public string PlantName { get; set; }
        public int PlantID { get; set; }
        public int CMWorkFlowStageTransitionID { get; set; }
        public string DepartmentName { get; set; }
        public byte[] ProfilePic { get; set; }
    }
}
