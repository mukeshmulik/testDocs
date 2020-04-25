using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoErrorCodeDBClient : ICreditMemoErrorCodeDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoErrorCodeDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<ErrorCode> GetCreditErrorCodeByReasonID(int ReasonID)
        {
            SqlParameter[] param = {
                new SqlParameter("@ReasonID", ReasonID)
            };
            return SqlHelper.ExecuteProcedureReturnList<ErrorCode>(ConnectionString, SPConstants.uspGetCreditErrorCodeByReasonID, param);
        }
    }
}
