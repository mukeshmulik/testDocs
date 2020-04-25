using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CM.DataAccess.Repository
{
    public class TestDBClient: ITestDBClient
    {
        public string ConnectionString { get; set; }

        public TestDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public TestUser GetName(int userId)
        {
            SqlParameter[] param = {new SqlParameter("@UserID",userId)};

            return SqlHelper.ExecuteProcedureReturnSingleObject<TestUser>(ConnectionString,"spTestGetUser", param);
        }
        public List<TestUser> GetNameByList(int userId)
        {
            SqlParameter[] param = { new SqlParameter("@UserID", userId) };

            return SqlHelper.ExecuteProcedureReturnList<TestUser>(ConnectionString, "spTestGetALlUser", param);
        }
    }
}
