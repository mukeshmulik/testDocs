using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class UserRolesDBClient : IUserRolesDBClient
    {
        public string ConnectionString { get; set; }
        public UserRolesDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetAllList()
        {
            SqlParameter[] param = { };
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetAllUserRoleMaster, param);
          //  return SqlHelper.ExecuteProcedureReturnList<UserRoles>(ConnectionString, SPConstants.uspGetAllUserRoleMaster, param);
        }
    }
}
