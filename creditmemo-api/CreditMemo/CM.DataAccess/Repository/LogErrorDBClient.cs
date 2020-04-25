using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class LogErrorDBClient : ILogErrorDBClient
    {
        public LogErrorDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }

       
        public string ConnectionString { get; }

        public string GetAllLogActivityList(int UserID)
        {
            throw new NotImplementedException();
        }
        public string SaveLogError(LogError logError)
        {
            SqlParameter[] param =
                {
                new SqlParameter("@Source", logError.Source),
                new SqlParameter("@FunctionName", logError.FunctionName),
                new SqlParameter("@ErrorMessage", logError.ErrorMessage),
                new SqlParameter("@StackTrace", logError.StackTrace),
                new SqlParameter("@InnerException", logError.InnerException),
                new SqlParameter("@RecordStatusId", logError.RecordStatusId),
                new SqlParameter("@CreatedBy", logError.CreatedBy)
            };
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspLogErrorInsert, param);
        }
    }
}
