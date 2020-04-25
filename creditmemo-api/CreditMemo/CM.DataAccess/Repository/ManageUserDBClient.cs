using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class ManageUserDBClient : IManageUserDBClient
    {
        public string ConnectionString { get; set; }
        public ManageUserDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<ManageUserRequest> GetAllRequest()
        {
            //return SqlHelper.ExecuteProcedureReturnList<ManageUserRequest>(ConnectionString, SPConstants.uspGetAllAccessRequestList, null);
            return SqlHelper.ExecuteProcedureReturnList<ManageUserRequest>(ConnectionString, SPConstants.uspGetAllRequest, null);
        }
        public List<ManageUserRequest> GetAllPendingRequest()
        {
            return SqlHelper.ExecuteProcedureReturnList<ManageUserRequest>(ConnectionString, SPConstants.uspGetAllPendingRequest, null);
        }
        public UserDetail SaveUserDetail(UserDetail userDetail)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", userDetail.ID),
                new SqlParameter("@RoleID", userDetail.RoleID),
                new SqlParameter("@GlobalID", userDetail.GlobalID),
                new SqlParameter("@UserName", userDetail.UserName),
                new SqlParameter("@Email", userDetail.EmailID),
                new SqlParameter("@ContactNo", userDetail.ContactNo),
                new SqlParameter("@DepartmentID", userDetail.DepartmentID),
                new SqlParameter("@CreditAmount", userDetail.CreditAmount),
                new SqlParameter("@CreditAmountID", userDetail.CreditAmountID),
                new SqlParameter("@RecordStatusId", userDetail.RecordStatusID),
                new SqlParameter("@LoggedinGlobalID", userDetail.Loggedin_GlobalID),
                new SqlParameter("@PlantID", userDetail.PlantID)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPConstants.uspSaveUserDetail, param);
        }
        public string GetUserDetailsByGlobalID(string GlobalID)
        {
            SqlParameter[] param = {
                new SqlParameter("@GlobalID", GlobalID)
            };
            //return SqlHelper.ExecuteProcedureReturnSingleObject<User>(ConnectionString, SPConstants.uspUserDetailsByGlobalID, param);
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetLoginUserinfo, param);
        }
        public UserDetail CheckUserDetail(UserDetail userDetail)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@GlobalID", userDetail.GlobalID),
                new SqlParameter("@DepartmentID", userDetail.DepartmentID)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPConstants.uspCheckUserDetail, param);
        }
        public UserDetail DeleteUserDetail(UserDetail userDetail)
        {
            SqlParameter[] param = {
                new SqlParameter("@MapUserDepartmentID", userDetail.ID)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPConstants.uspDeleteUserDetail, param);
        }
        public UserDetail ApproveUserPendingRequest(UserDetail userDetail)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", userDetail.ID),
                new SqlParameter("@GlobalID", userDetail.GlobalID),
                new SqlParameter("@UserName", userDetail.UserName),
                new SqlParameter("@Email", userDetail.EmailID),
                new SqlParameter("@ContactNo", userDetail.ContactNo),
                new SqlParameter("@CreditAmountID", userDetail.CreditAmountID),
                new SqlParameter("@DepartmentID", userDetail.DepartmentID),
                new SqlParameter("@ApprovalStatus", true),
                new SqlParameter("@Comments", userDetail.Comments),
                new SqlParameter("@RequesterEmail", userDetail.RequesterEmail),
                new SqlParameter("@IsRequesterNotified", false),
                new SqlParameter("@IsAdminNotified", false),
                new SqlParameter("@RecordStatusId", userDetail.RecordStatusID),
                new SqlParameter("@RoleID",userDetail.RoleID),
                new SqlParameter("@CreatedBy",userDetail.Loggedin_GlobalID),
                new SqlParameter("@CreditAmount",userDetail.CreditAmount),
                new SqlParameter("@PlantID", userDetail.PlantID)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPConstants.uspSaveUserAccessRequest, param);
        }
        public UserDetail RejectUserPendingRequest(UserDetail userDetail)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", userDetail.ID),
                new SqlParameter("@GlobalID", userDetail.GlobalID),
                new SqlParameter("@UserName", userDetail.UserName),
                new SqlParameter("@Email", userDetail.EmailID),
                new SqlParameter("@ContactNo", userDetail.ContactNo),
                new SqlParameter("@CreditAmountID", userDetail.CreditAmountID),
                new SqlParameter("@DepartmentID", userDetail.DepartmentID),
                new SqlParameter("@ApprovalStatus", false),
                new SqlParameter("@Comments", userDetail.Comments),
                new SqlParameter("@RequesterEmail", userDetail.RequesterEmail),
                new SqlParameter("@IsRequesterNotified", false),
                new SqlParameter("@IsAdminNotified", false),
                new SqlParameter("@RecordStatusId", 1)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPConstants.uspSaveUserAccessRequest, param);
        }
        public string uspSaveUserAccessRequest_JSON(string userDetail)
        {
            var param = new SqlParameter("@JsonObject", userDetail);
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPJSONConstants.uspSaveUserAccessRequest_JSON, param);
        }      
        public UserDetail CheckUserDetail_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPJSONConstants.uspCheckUserDetail_JSON, param);
        }
        public UserDetail SaveUserDetail_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPJSONConstants.uspSaveUserDetail_JSON, param);
        }
        public UserDetail ApproveUserPendingRequest_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPJSONConstants.uspSaveUserAccessRequest_JSON, param);
        }
        public UserDetail RejectUserPendingRequest_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPJSONConstants.uspSaveUserAccessRequest_JSON, param);
        }
        public UserDetail DeleteUserDetail_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<UserDetail>(ConnectionString, SPJSONConstants.uspDeleteUserDetail_JSON, param);
        }
    }
}
