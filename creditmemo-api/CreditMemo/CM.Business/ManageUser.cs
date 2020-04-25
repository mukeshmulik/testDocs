using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class ManageUser : IManageUser
    {
        public ManageUser(IManageUserDBClient _manageUserDBClient)
        {
            _ManageUserDBClient = _manageUserDBClient;
        }
        public IManageUserDBClient _ManageUserDBClient { get; }
        public List<ManageUserRequest> GetAllRequest()
        {
            var data = _ManageUserDBClient.GetAllRequest();
            return data;
        }
        public List<ManageUserRequest> GetAllPendingRequest()
        {
            var data = _ManageUserDBClient.GetAllPendingRequest();
            return data;
        }
        public UserDetail SaveUserDetail(UserDetail userDetail)
        {
            var data = _ManageUserDBClient.SaveUserDetail(userDetail);
            return data;
        }
        public UserDetail CheckUserDetail(UserDetail userDetail)
        {
            var data = _ManageUserDBClient.CheckUserDetail(userDetail);
            return data;
        }
        public UserDetail DeleteUserDetail(UserDetail userDetail)
        {
            var data = _ManageUserDBClient.DeleteUserDetail(userDetail);
            return data;
        }
        public UserDetail ApproveUserPendingRequest(UserDetail userDetail)
        {
            var data = _ManageUserDBClient.ApproveUserPendingRequest(userDetail);
            return data;
        }
        public UserDetail RejectUserPendingRequest(UserDetail userDetail)
        {
            var data = _ManageUserDBClient.RejectUserPendingRequest(userDetail);
            return data;
        }
        public string GetUserDetailsByGlobalID(string GlobalID)
        {
            var data = _ManageUserDBClient.GetUserDetailsByGlobalID(GlobalID);
            return data;
        }
        public string uspSaveUserAccessRequest_JSON(string jsondata)
        {
            var data = _ManageUserDBClient.uspSaveUserAccessRequest_JSON(jsondata);
            return data;
        }
        public UserDetail CheckUserDetail_JSON(string jsondata)
        {
            var data = _ManageUserDBClient.CheckUserDetail_JSON(jsondata);
            return data;
        }
        public UserDetail SaveUserDetail_JSON(string jsondata)
        {
            var data = _ManageUserDBClient.SaveUserDetail_JSON(jsondata);
            return data;
        }
        public UserDetail ApproveUserPendingRequest_JSON(string jsondata)
        {
            var data = _ManageUserDBClient.ApproveUserPendingRequest_JSON(jsondata);
            return data;
        }
        public UserDetail RejectUserPendingRequest_JSON(string jsondata)
        {
            var data = _ManageUserDBClient.RejectUserPendingRequest_JSON(jsondata);
            return data;
        }
        public UserDetail DeleteUserDetail_JSON(string jsondata)
        {
            var data = _ManageUserDBClient.DeleteUserDetail_JSON(jsondata);
            return data;
        }
    }
}
