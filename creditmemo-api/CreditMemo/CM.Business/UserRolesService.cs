using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class UserRolesService : IUserRolesService
    {
        public UserRolesService(IUserRolesDBClient _userRolesDBClient)
        {
            _UserRolesDBClient = _userRolesDBClient;
        }

        public IUserRolesDBClient _UserRolesDBClient { get; }
        
        public string GetAllList()
        {
            var data = _UserRolesDBClient.GetAllList();
            return data;
        }

    }
}
