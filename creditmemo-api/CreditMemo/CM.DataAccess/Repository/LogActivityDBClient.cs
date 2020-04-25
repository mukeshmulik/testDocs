using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class LogActivityDBClient : ILogActivityDBClient
    {
        public string ConnectionString { get; set; }
        public LogActivityDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetAllLogActivityList(int UserID)
        {
            SqlParameter[] param = {
                new SqlParameter("@UserID", UserID)
            };
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetAllLogActivityListByUserID, param);
        }
        public string SaveLogActivity(LogActivity logActivity)
        {
            SqlParameter[] param= 
                {
                new SqlParameter("@Data", logActivity.Data),
                new SqlParameter("@URL", logActivity.URL),
                new SqlParameter("@CreatedBy", logActivity.GlobalID),
                new SqlParameter("@LoginGUID", logActivity.LoginGUID),
                new SqlParameter("@SourceDetails", logActivity.SourceDetails)
            };
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspLogActivityInsert, param);
        }
    }
}
