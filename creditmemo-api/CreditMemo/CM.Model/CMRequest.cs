using System;
using System.Collections.Generic;

namespace CM.Model
{
    public class CMRequest
    {
        public int ID { get; set; }
        public int WorkFlowStageStatusID { get; set; }
        public string ControlNo { get; set; }
        public string FON { get; set; }
        public string SaleOrder { get; set; }
        public string InvoiceNo { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal CreditRequestAmount { get; set; }
        public string RGA { get; set; }
        public string MPCreditMemo { get; set; }
        public string MPCustomer { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string EmailNotification { get; set; }
        public string FactoryContact { get; set; }
        public string MacPacErrorCode { get; set; }
        public string OPSErrorCode { get; set; }
        public string ErrorType { get; set; }
        public string PlantCode { get; set; }
        public string RCInitials { get; set; }
        public string CreditReason { get; set; }
        public string CreditReqNumber { get; set; }
        public string CreditType { get; set; }
        public DateTime MemoDate { get; set; }
        public int SLAPeriod { get; set; }
        public int SLAThreasholdPeriod { get; set; }
        public DateTime CompletionDate { get; set; }
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentID { get; set; }
        public string YearMasterName { get; set; }
        public int YearMasterID { get; set; }
        public string ProdOrderNo { get; set; }
        public string SONo { get; set; }
        public string MailCopies { get; set; }
        public string SalesPerson { get; set; }
        public string RepNo { get; set; }
        public string RepName { get; set; } 

        //public virtual YearMaster YearMaster { get; set; }
        //public virtual Department Department { get; set; }
    }
}
