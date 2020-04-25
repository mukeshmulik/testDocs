using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoReasonDBClient : ICreditMemoReasonDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoReasonDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetCreditMemoReason()
        {
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetCreditMemoReason, null);
        }
        public ReasonErrorCode SaveCreditMemoReasonAndErrorCode_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<ReasonErrorCode>(ConnectionString, SPJSONConstants.uspSaveCreditMemoReasonAndErrorCode_JSON, param);
        }
        public ReasonErrorCode DeleteCreditMemoReasonAndErrorCode_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<ReasonErrorCode>(ConnectionString, SPJSONConstants.uspDeleteCreditMemoReasonAndErrorCode_JSON, param);
        }
    }
}
