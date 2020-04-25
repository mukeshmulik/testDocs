using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class DepartmentDBClient : IDepartmentDBClient
    {
        public string ConnectionString { get; set; }
        public DepartmentDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetAllDepartments()
        {
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetAllDepartments, null);
        }
    }
}
