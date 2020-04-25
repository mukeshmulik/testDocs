using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class MacPacErrorCodeDBClient : IMacPacErrorCodeDBClient
    {
        public string ConnectionString { get; set; }
        public MacPacErrorCodeDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetMacPacErrorCodes()
        {
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetMacPacErrorCode, null);
        }
    }
}
