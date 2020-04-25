using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoApprovalStatusDBClient : ICreditMemoApprovalStatusDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoApprovalStatusDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetCreditMemoApprovalStatus()
        {
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetCreditMemoApprovalStatus, null);
        }
    }
}
