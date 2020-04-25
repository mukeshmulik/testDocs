using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class UserAccessRequestService : IUserAccessRequestService
    {
        public UserAccessRequestService(IUserAccessRequestDBClient _userAccessRequestDBClient)
        {
            _UserAccessRequestDBClient = _userAccessRequestDBClient;
        }
        public IUserAccessRequestDBClient _UserAccessRequestDBClient { get; }        
        public List<UserAccessRequest> GetAllUserAccessRequestList()
        {
            var data = _UserAccessRequestDBClient.GetAllUserAccessRequestList();
            return data;
        }
        public UserAccessRequest SaveUserAccessRequest(UserAccessRequest UserAccessRequest)
        {
            var data = _UserAccessRequestDBClient.SaveUserAccessRequest(UserAccessRequest);
            return data;
        }
        public UserAccessRequest CheckUserAccessRequest(UserAccessRequest UserAccessRequest)
        {
            var data = _UserAccessRequestDBClient.CheckUserAccessRequest(UserAccessRequest);
            return data;
        }
        public UserAccessRequest CheckUserAccessRequest_JSON(string jsondata)
        {
            var data = _UserAccessRequestDBClient.CheckUserAccessRequest_JSON(jsondata);
            return data;
        }
        public UserAccessRequest SaveUserAccessRequest_JSON(string jsondata)
        {
            var data = _UserAccessRequestDBClient.SaveUserAccessRequest_JSON(jsondata);
            return data;
        }
    }
}
