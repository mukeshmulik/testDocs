
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.BusinessContract
{
    public interface ITestUserService
    {
        TestUser GetName(int userId);
        List<TestUser> GetNameByList(int userId);
        int AddUser(TestUser user);
    }
}
