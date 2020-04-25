using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface IUserAccessRequestDBClient
    {
        List<UserAccessRequest> GetAllUserAccessRequestList();
        UserAccessRequest SaveUserAccessRequest(UserAccessRequest UserAccessRequest);
        UserAccessRequest CheckUserAccessRequest(UserAccessRequest UserAccessRequest);
        UserAccessRequest CheckUserAccessRequest_JSON(string jsondata);
        UserAccessRequest SaveUserAccessRequest_JSON(string jsondata);
    }
}
