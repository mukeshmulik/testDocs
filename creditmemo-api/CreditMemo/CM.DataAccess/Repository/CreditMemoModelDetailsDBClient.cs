using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoModelDetailsDBClient : ICreditMemoModelDetailsDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoModelDetailsDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<CreditMemoModelDetails> GetModelDetailsByID(int CMID)
        {
            SqlParameter[] param = {
                new SqlParameter("@CMRequestID", CMID)
            };
            return SqlHelper.ExecuteProcedureReturnList<CreditMemoModelDetails>(ConnectionString, SPConstants.uspGetAllModelDetailsByCMRequestID, param);
        }
        public CreditMemoModelDetails SaveModelDetails(CreditMemoModelDetails CreditMemoModelDetails)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", CreditMemoModelDetails.ID),
                new SqlParameter("@CMRequestID", CreditMemoModelDetails.CMRequestID),
                new SqlParameter("@Model", CreditMemoModelDetails.Model),
                new SqlParameter("@DIV", CreditMemoModelDetails.DIV),
                new SqlParameter("@GLAccount", CreditMemoModelDetails.GLAccount),
                new SqlParameter("@Amount", CreditMemoModelDetails.Amount),
                new SqlParameter("@Approved", CreditMemoModelDetails.Approved),
                new SqlParameter("@RecordStatusId", CreditMemoModelDetails.RecordStatusId),
                new SqlParameter("@CreatedBy", CreditMemoModelDetails.CreatedBy),
                new SqlParameter("@ModifiedBy", CreditMemoModelDetails.ModifiedBy)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<CreditMemoModelDetails>(ConnectionString, SPConstants.uspSaveModelDetails, param);
        }
    }
}
