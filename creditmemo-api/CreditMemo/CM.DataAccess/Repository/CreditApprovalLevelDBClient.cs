using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditApprovalLevelDBClient : ICreditApprovalLevelDBClient
    {
        public string ConnectionString { get; set; }
        public CreditApprovalLevelDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetAllCreditApprovalLevel()
        {
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetAllCreditApprovalLevel, null);
        }
    }
}
