using System;

namespace CM.Model
{
    public class CreditMemoTracking
    {
        public int CreditMemoRequestID { get; set; }
        public string DepartmentName { get; set; }
        public string CreditReqNumber { get; set; }
        public string CreditType { get; set; }
        public string CreditReason { get; set; }
        public string InvoiceNo { get; set; }
        public decimal InvoiceAmount { get; set; }
        public DateTime CreditMemoDate { get; set; }
        public int SLAPeriod { get; set; }
        public string Status { get; set; }
        public string PlantName { get; set; }
        public int DepartmentID { get; set; }
        public int PlantID { get; set; }
    }
    //public class RootCauseInvestigation
    //{
    //    public string RootCause { get; set; }
    //    public int ID { get; set; }
    //    public int RoleID { get; set; }
    //    public string GlobalID { get; set; }
    //    public string FullName { get; set; }        
    //    public string Email { get; set; }
    //    public string ContactNo { get; set; }
    //    public int RecordStatusID { get; set; }
    //    public string CreatedBy { get; set; }
    //    public DateTime CreatedOn { get; set; }
    //    public string ModifiedBy { get; set; }
    //    public DateTime ModifiedOn { get; set; }
    //}
}
