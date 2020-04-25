using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class YearMasterDBClient : IYearMasterDBClient
    {
        public string ConnectionString { get; set; }
        public YearMasterDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetAllList()
        {
            SqlParameter[] param = { };
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetAllYearMaster, param);
            // return SqlHelper.ExecuteProcedureReturnList<YearMaster>(ConnectionString, SPConstants.uspGetAllYearMaster, param);
        }
    }
}
