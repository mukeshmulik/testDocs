using CM.Common.Enums;
using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class UserAccessRequestDBClient : IUserAccessRequestDBClient
    {
        public string ConnectionString { get; set; }
        public UserAccessRequestDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<UserAccessRequest> GetAllUserAccessRequestList()
        {
            SqlParameter[] param = { };
            return SqlHelper.ExecuteProcedureReturnList<UserAccessRequest>(ConnectionString, SPConstants.uspGetAllAccessRequestList, param);
        }
        public UserAccessRequest SaveUserAccessRequest(UserAccessRequest UserAccessRequest)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", UserAccessRequest.ID),
                new SqlParameter("@GlobalID", UserAccessRequest.GlobalID),
                new SqlParameter("@UserName", UserAccessRequest.UserName),
                new SqlParameter("@Email", UserAccessRequest.Email),
                new SqlParameter("@ContactNo", UserAccessRequest.ContactNo),
                new SqlParameter("@CreditAmountID", null),
                new SqlParameter("@DepartmentID", UserAccessRequest.DepartmentID),
                new SqlParameter("@ApprovalStatus", null),
                new SqlParameter("@Comments", UserAccessRequest.Comments),
                new SqlParameter("@RequesterEmail", UserAccessRequest.RequesterEmail),
                new SqlParameter("@IsRequesterNotified", false),
                new SqlParameter("@IsAdminNotified", false),
                new SqlParameter("@RecordStatusId", RecordStatusEnum.Active),
                new SqlParameter("@RoleID", UserAccessRequest.RoleID),
                new SqlParameter("@PlantID", UserAccessRequest.PlantID),
                
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserAccessRequest>(ConnectionString, SPConstants.uspSaveUserAccessRequest, param);
        }
        public UserAccessRequest CheckUserAccessRequest(UserAccessRequest UserAccessRequest)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@GlobalID", UserAccessRequest.GlobalID),
                new SqlParameter("@DepartmentID", UserAccessRequest.DepartmentID)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserAccessRequest>(ConnectionString, SPConstants.uspCheckUserAccessRequest, param);
        }
        public UserAccessRequest CheckUserAccessRequest_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserAccessRequest>(ConnectionString, SPJSONConstants.uspCheckUserAccessRequest_JSON, param);
        }
        public UserAccessRequest SaveUserAccessRequest_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserAccessRequest>(ConnectionString, SPJSONConstants.uspSaveUserAccessRequest_JSON, param);
        }
    }
}
