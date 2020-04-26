using Auxillo.Model;
using System.Collections.Generic;

namespace Auxillo.Contract.DataAccessContract
{
    public interface ITestDBClient
    {
        WidgetTypeMaster Get();
        TestUser GetName(int userId);
        List<TestUser> GetNameByList(int userId);
    }
}
