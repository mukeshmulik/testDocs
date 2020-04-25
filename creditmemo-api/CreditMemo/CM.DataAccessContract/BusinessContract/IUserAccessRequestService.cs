
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.BusinessContract
{
    public interface IUserAccessRequestService
    {
        List<UserAccessRequest> GetAllUserAccessRequestList();
        UserAccessRequest SaveUserAccessRequest(UserAccessRequest userAccessRequest);
        UserAccessRequest CheckUserAccessRequest(UserAccessRequest userAccessRequest);
        UserAccessRequest CheckUserAccessRequest_JSON(string jsondata);
        UserAccessRequest SaveUserAccessRequest_JSON(string jsondata);
    }
}
