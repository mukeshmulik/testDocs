using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface IManageUser
    {
        List<ManageUserRequest> GetAllRequest();
        List<ManageUserRequest> GetAllPendingRequest();
        UserDetail SaveUserDetail(UserDetail userDetail);
        string GetUserDetailsByGlobalID(string GlobalID);
        UserDetail CheckUserDetail(UserDetail userDetail);
        UserDetail DeleteUserDetail(UserDetail userDetail);
        UserDetail ApproveUserPendingRequest(UserDetail userDetail);
        UserDetail RejectUserPendingRequest(UserDetail userDetail);
        string uspSaveUserAccessRequest_JSON(string jsondata);
        UserDetail CheckUserDetail_JSON(string jsondata);
        UserDetail SaveUserDetail_JSON(string jsondata);
        UserDetail ApproveUserPendingRequest_JSON(string jsondata);
        UserDetail RejectUserPendingRequest_JSON(string jsondata);
        UserDetail DeleteUserDetail_JSON(string jsondata);
    }
}
