using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoAttachmentDetailsDBClient : ICreditMemoAttachmentDetailsDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoAttachmentDetailsDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<CreditMemoAttachmentDetails> GetAttachmentsByID(int CMID)
        {
            SqlParameter[] param = {
                new SqlParameter("@CMRequestID", CMID)
            };
            return SqlHelper.ExecuteProcedureReturnList<CreditMemoAttachmentDetails>(ConnectionString, SPConstants.uspGetAllAttachmentDetailsByCMRequestID, param);
        }
        public CreditMemoAttachmentDetails SaveAttachments(CreditMemoAttachmentDetails CreditMemoAttachmentDetails)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", CreditMemoAttachmentDetails.ID),
                new SqlParameter("@CMRequestID", CreditMemoAttachmentDetails.CMRequestID),
                new SqlParameter("@FileName", CreditMemoAttachmentDetails.FileName),
                new SqlParameter("@Path", CreditMemoAttachmentDetails.Path),
                new SqlParameter("@RecordStatusId", CreditMemoAttachmentDetails.RecordStatusId),
                new SqlParameter("@CreatedBy", CreditMemoAttachmentDetails.CreatedBy),
                new SqlParameter("@ModifiedBy", CreditMemoAttachmentDetails.ModifiedBy)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<CreditMemoAttachmentDetails>(ConnectionString, SPConstants.uspSaveAttachmentDetails, param);
        }
    }
}
