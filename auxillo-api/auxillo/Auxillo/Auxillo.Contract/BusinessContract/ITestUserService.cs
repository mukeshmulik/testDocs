
using Auxillo.Model;
using System.Collections.Generic;

namespace Auxillo.Contract.BusinessContract
{
    public interface ITestUserService
    {
        WidgetTypeMaster Get();
        TestUser GetName(int userId);
        List<TestUser> GetNameByList(int userId);
        int AddUser(TestUser user);
    }
}
