using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoTrackingDBClient
    {
        List<CreditMemoTracking> GetCreditMemoTrackingRecord();
        List<RootCauseInvestigation> GetRootCauseInvestigationByCMRequestID(int CMRequestID);
        RootCauseInvestigation SaveRootCauseInvestigationDetail(RootCauseInvestigation rootCauseInvestigation);
        List<RootCauseDTO> GetRootCauseDetailsByCMRequestID(int CMRequestID,bool IsPlant);
        List<PlantResponseDTO> GetPlantResponseByCMRequestID(int CMRequestID, bool IsPlant);
        RootCauseInvestigation SaveRootCauseInvestigationDetail_JSON(string jsondata);
    }
}
