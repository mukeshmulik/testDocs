using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoTrackingRecord
    {
        List<CreditMemoTracking> GetCreditMemoTrackingRecord();
        List<RootCauseInvestigation> GetRootCauseInvestigationByCMRequestID(int CMRequestID);
        RootCauseInvestigation SaveRootCauseInvestigationDetail(RootCauseInvestigation rootCauseInvestigation);
        List<RootCauseDTO> GetRootCauseDetailsByCMRequestID(int CMRequestID,bool IsPlant);
        List<PlantResponseDTO> GetPlantResponseByCMRequestID(int CMRequestID, bool IsPlant);
        RootCauseInvestigation SaveRootCauseInvestigationDetail_JSON(string jsondata);
    }
}
