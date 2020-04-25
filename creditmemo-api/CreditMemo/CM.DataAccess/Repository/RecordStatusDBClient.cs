using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class RecordStatusDBClient : IRecordStatusDBClient
    {
        public string ConnectionString { get; set; }
        public RecordStatusDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetAllList()
        {
            SqlParameter[] param = { };
            //return SqlHelper.ExecuteProcedureReturnList<RecordStatus>(ConnectionString, SPConstants.uspGetAllRecordStatusMaster, param);
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetAllRecordStatusMaster, param);
        }
    }
}
