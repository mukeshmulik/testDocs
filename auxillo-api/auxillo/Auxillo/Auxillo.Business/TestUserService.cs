using Auxillo.Contract.BusinessContract;
using Auxillo.Contract.DataAccessContract;
using Auxillo.Model;
using System.Collections.Generic;

namespace Auxillo.Business
{
    public class TestUserService: ITestUserService
    {
        public TestUserService(ITestDBClient _testDBClient)
        {
            _TestDBClient = _testDBClient;
        }

        public ITestDBClient _TestDBClient { get; }

        public WidgetTypeMaster Get()
        {
            return _TestDBClient.Get();
        }
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
