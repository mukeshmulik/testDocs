using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ITestDBClient
    {
        TestUser GetName(int userId);
        List<TestUser> GetNameByList(int userId);
    }
}
