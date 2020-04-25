using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoInfoDBClient : ICreditMemoInfoDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoInfoDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<CMRequest> GetAllCreditMemo()
        {
            return SqlHelper.ExecuteProcedureReturnList<CMRequest>(ConnectionString, SPConstants.uspGetAllCreditMemos, null);
        }
        public CMRequest GetCreditMemoDetailsByID(int ID)
        {
            SqlParameter[] param = {
                new SqlParameter("@ID", ID)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<CMRequest>(ConnectionString, SPConstants.uspGetCreditMemoDetailsByID, param);
        }
        public CMRequest SaveCreditMemoDetails(CMRequest CMRequest)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", CMRequest.ID),
                new SqlParameter("@WorkFlowStageStatusID", CMRequest.WorkFlowStageStatusID),
                new SqlParameter("@ControlNo", CMRequest.ControlNo),
                new SqlParameter("@FON", CMRequest.FON),
                new SqlParameter("@SaleOrder", CMRequest.SaleOrder),
                new SqlParameter("@InvoiceNo", CMRequest.InvoiceNo),
                new SqlParameter("@InvoiceAmount", CMRequest.InvoiceAmount),
                new SqlParameter("@CreditRequestAmount", CMRequest.CreditRequestAmount),
                new SqlParameter("@RGA", CMRequest.RGA),
                new SqlParameter("@MPCreditMemo", CMRequest.MPCreditMemo),
                new SqlParameter("@MPCustomer", CMRequest.MPCustomer),
                new SqlParameter("@CompanyName", CMRequest.CompanyName),
                new SqlParameter("@ContactName", CMRequest.ContactName),
                new SqlParameter("@EmailNotification", CMRequest.EmailNotification),
                new SqlParameter("@FactoryContact", CMRequest.FactoryContact),
                new SqlParameter("@MacPacErrorCode", CMRequest.MacPacErrorCode),
                new SqlParameter("@OPSErrorCode", CMRequest.OPSErrorCode),
                new SqlParameter("@ErrorType", CMRequest.ErrorType),
                new SqlParameter("@PlantCode", CMRequest.PlantCode),
                new SqlParameter("@RCInitials", CMRequest.RCInitials),
                new SqlParameter("@CreditReason", CMRequest.CreditReason),
                new SqlParameter("@CreditReqNumber", CMRequest.CreditReqNumber),
                new SqlParameter("@CreditType", CMRequest.CreditType),
                new SqlParameter("@MemoDate", CMRequest.MemoDate),
                new SqlParameter("@SLAPeriod", CMRequest.SLAPeriod),
                new SqlParameter("@SLAThreasholdPeriod", CMRequest.SLAThreasholdPeriod),
                new SqlParameter("@CompletionDate", CMRequest.CompletionDate),
                new SqlParameter("@RecordStatusId", CMRequest.RecordStatusId),
                new SqlParameter("@CreatedBy", CMRequest.CreatedBy),
                new SqlParameter("@ModifiedBy", CMRequest.ModifiedBy)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<CMRequest>(ConnectionString, SPConstants.uspSaveCreditMemoRequest, param);
        }

        //public CreditMemoApprovalRequest SaveCreditMemoRequest_JSON(string jsondata)
        //{
        //    var param = new SqlParameter("@JsonObject", jsondata);
        //    return SqlHelper.ExecuteProcedureReturnSingleObject<CreditMemoApprovalRequest>(ConnectionString, SPJSONConstants.uspSaveCreditMemoRequest_JSON, param);
        //}
        public StoredProcedureReturnStatus SaveCreditMemoRequest_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<StoredProcedureReturnStatus>(ConnectionString, SPJSONConstants.uspSaveCreditMemoRequest_JSON, param);
        }
        public CreditMemoRejectRequest RejectCreditMemoRequest_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<CreditMemoRejectRequest>(ConnectionString, SPJSONConstants.uspRejectCreditMemoRequest_JSON, param);
        }
    }
}
