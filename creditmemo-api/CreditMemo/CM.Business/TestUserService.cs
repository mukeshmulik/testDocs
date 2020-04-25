using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class TestUserService: ITestUserService
    {
        public TestUserService(ITestDBClient _testDBClient)
        {
            _TestDBClient = _testDBClient;
        }

        public ITestDBClient _TestDBClient { get; }

        public int AddUser(TestUser user)
        {
            return 0;
        }

        public TestUser GetName(int userId)
        {
            var data = _TestDBClient.GetName(userId);
            return data;
        }

        public List<TestUser> GetNameByList(int userId)
        {
            var data = _TestDBClient.GetNameByList(userId);
            return data;
        }

    }
}
