using Auxillo.Contract.DataAccessContract;
using Auxillo.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Auxillo.DataAccess.Repository
{
    public class TestDBClient: ITestDBClient
    {
        public string ConnectionString { get; set; }

        public TestDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public WidgetTypeMaster Get()
        {
            return SqlHelper.ExecuteProcedureReturnSingleObject<WidgetTypeMaster>(ConnectionString, "select * from widgettypemaster; ", null);
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
