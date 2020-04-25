using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
   public class CreditMemoInfoDetails
    {
        public virtual CMRequest CMRequest { set; get; }
        public virtual ICollection<CreditMemoModelDetails> ModelDetails { get; set; }
        public virtual ICollection<CreditMemoProductDetails> ProductDetails { get; set; }
        public virtual ICollection<CreditMemoAttachmentDetails> AttachmentDetails { get; set; }
    }

    public class CreditMemoApprovalRequest
    {
        public CreditMemoApprovalRequest()
        {
            ModelDetails = new List<CreditMemoModelDetails>();
            AttachmentDetails = new List<CreditMemoAttachmentDetails>();
            RootCauseInvestigations = new List<RootCauseInvestigation>();
            CreditMemoAmountDivisionDetails = new List<CreditMemoAmountDivisionDetail>();
            CreditMemoApprovalTransitions = new List<CreditMemoApprovalTransition>();
            //CreditMemoApprovalHistories = new List<CreditMemoApprovalHistory>();
        }
            
        public int CMRequestID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
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

        //public virtual ICollection<CreditMemoModelDetails> ModelDetails { get; set; }
        public List<CreditMemoModelDetails> ModelDetails { get; set; }

        //public int CMModelDetailID { get; set; }
        //public string Model { get; set; }
        //public string DIV { get; set; }
        //public string GLAccount { get; set; }
        //public decimal Amount { get; set; }
        //public bool Approved { get; set; }
        //public int CMProductDetailID { get; set; }
        //public string CtrlItem { get; set; }
        //public string PltItem { get; set; }
        //public string ProductModel { get; set; }
        //public decimal Width { get; set; }
        //public decimal Height { get; set; }
        //public string SizeInfo { get; set; }
        //public int QuantityOrdered { get; set; }
        //public int QuantityShipped { get; set; }
        //public int QuantityRemaining { get; set; }
        //public decimal Price { get; set; }
        //public decimal Total { get; set; }

        //public virtual ICollection<CreditMemoAttachmentDetails> AttachmentDetails { get; set; }
        public List<CreditMemoAttachmentDetails> AttachmentDetails { get; set; }

        //public virtual ICollection<RootCauseInvestigation> RootCauseInvestigations { get; set; }
        public List<RootCauseInvestigation> RootCauseInvestigations { get; set; }

        //public virtual ICollection<CreditMemoAmountDivisionDetail> CreditMemoAmountDivisionDetails { get; set; }
        public List<CreditMemoAmountDivisionDetail> CreditMemoAmountDivisionDetails { get; set; }

        //public virtual ICollection<CreditMemoApprovalTransition> CreditMemoApprovalTransitions { get; set; }
        public List<CreditMemoApprovalTransition> CreditMemoApprovalTransitions { get; set; }

        //public virtual ICollection<CreditMemoApprovalHistory> CreditMemoApprovalHistories { get; set; }

        //public List<CreditMemoApprovalHistory> CreditMemoApprovalHistories { get; set; }

        //public int CMAttachmentDetailID { get; set; }
        //public string FileName { get; set; }
        //public string Path { get; set; }
        //public bool IsFromCreditMemo { get; set; }
        //public string Type { get; set; }
        //public string Size { get; set; }

    }

    public class CreditMemoRejectRequest
    {
        public int CMRequestID { get; set; }
    }

}
