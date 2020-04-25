using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoTrackingDBClient : ICreditMemoTrackingDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoTrackingDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<CreditMemoTracking> GetCreditMemoTrackingRecord()
        {
            return SqlHelper.ExecuteProcedureReturnList<CreditMemoTracking>(ConnectionString, SPConstants.uspGetCreditMemoTrackingRecords, null);
        }
        public List<RootCauseInvestigation> GetRootCauseInvestigationByCMRequestID(int CMRequestID)
        {
            SqlParameter[] param = {
                new SqlParameter("@CMRequestID", CMRequestID)
            };
            return SqlHelper.ExecuteProcedureReturnList<RootCauseInvestigation>(ConnectionString, SPConstants.uspGetRootCauseInvestigationByCMRequestID, param);
        }
        public RootCauseInvestigation SaveRootCauseInvestigationDetail(RootCauseInvestigation rootCauseInvestigation)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", rootCauseInvestigation.ID),
                new SqlParameter("@CMRequestID", rootCauseInvestigation.CMRequestID),
                new SqlParameter("@DepartmentID", rootCauseInvestigation.DepartmentID),
                new SqlParameter("@UserID", rootCauseInvestigation.UserID),
                new SqlParameter("@IsNotified", rootCauseInvestigation.IsNotified),
                new SqlParameter("@IsExtensionRequested", rootCauseInvestigation.IsExtensionRequested),
                new SqlParameter("@IsEscalatedWithinDept", rootCauseInvestigation.IsEscalatedWithinDept),
                new SqlParameter("@IsEscalatedToSuperAdmin", rootCauseInvestigation.IsEscalatedToSuperAdmin),
                new SqlParameter("@RecordStatusId", rootCauseInvestigation.RecordStatusId),
                new SqlParameter("@CreatedBy", rootCauseInvestigation.CreatedBy),
                new SqlParameter("@ModifiedBy", rootCauseInvestigation.ModifiedBy),
                new SqlParameter("@RootCause", rootCauseInvestigation.RootCause),
                new SqlParameter("@PlantResponse", rootCauseInvestigation.PlantResponse),
                new SqlParameter("@PlantID", rootCauseInvestigation.PlantID)
            };
            return SqlHelper.ExecuteProcedureReturnSingleObject<RootCauseInvestigation>(ConnectionString, SPConstants.uspSaveRootCauseInvestigationDetail, param);
        }
        public List<RootCauseDTO> GetRootCauseDetailsByCMRequestID(int CMRequestID,bool IsPlant)
        {
            SqlParameter[] param = {
                new SqlParameter("@CMRequestID", CMRequestID),
               new SqlParameter("@IsPlant", IsPlant),
            };
            return SqlHelper.ExecuteProcedureReturnList<RootCauseDTO>(ConnectionString, SPConstants.uspGetRootCauseandPlantResponseByCMRequestID, param);
        }
        public List<PlantResponseDTO> GetPlantResponseByCMRequestID(int CMRequestID, bool IsPlant)
        {
            SqlParameter[] param = {
                new SqlParameter("@CMRequestID", CMRequestID),
               new SqlParameter("@IsPlant", IsPlant),
            };
            return SqlHelper.ExecuteProcedureReturnList<PlantResponseDTO>(ConnectionString, SPConstants.uspGetRootCauseandPlantResponseByCMRequestID, param);
        }
        public RootCauseInvestigation SaveRootCauseInvestigationDetail_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<RootCauseInvestigation>(ConnectionString, SPJSONConstants.uspSaveRootCauseInvestigationDetail_JSON, param);
        }
    }
}
