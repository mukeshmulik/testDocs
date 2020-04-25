using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoTrackingRecord : ICreditMemoTrackingRecord
    {
        public CreditMemoTrackingRecord(ICreditMemoTrackingDBClient _creditMemoTrackingDBClient)
        {
            _CreditMemoTrackingDBClient = _creditMemoTrackingDBClient;
        }
        public ICreditMemoTrackingDBClient _CreditMemoTrackingDBClient { get; }
        public List<CreditMemoTracking> GetCreditMemoTrackingRecord()
        {
            var data = _CreditMemoTrackingDBClient.GetCreditMemoTrackingRecord();
            return data;
        }
        public List<RootCauseInvestigation> GetRootCauseInvestigationByCMRequestID(int CMRequestID)
        {
            var data = _CreditMemoTrackingDBClient.GetRootCauseInvestigationByCMRequestID(CMRequestID);
            return data;
        }
        public RootCauseInvestigation SaveRootCauseInvestigationDetail(RootCauseInvestigation rootCauseInvestigation)
        {
            var data = _CreditMemoTrackingDBClient.SaveRootCauseInvestigationDetail(rootCauseInvestigation);
            return data;
        }
        public List<RootCauseDTO> GetRootCauseDetailsByCMRequestID(int CMRequestID,bool IsPlant)
        {
            var data = _CreditMemoTrackingDBClient.GetRootCauseDetailsByCMRequestID(CMRequestID,IsPlant);
            return data;
        }
        public List<PlantResponseDTO> GetPlantResponseByCMRequestID(int CMRequestID, bool IsPlant)
        {
            var data = _CreditMemoTrackingDBClient.GetPlantResponseByCMRequestID(CMRequestID, IsPlant);
            return data;
        }
        public RootCauseInvestigation SaveRootCauseInvestigationDetail_JSON(string jsondata)
        {
            var data = _CreditMemoTrackingDBClient.SaveRootCauseInvestigationDetail_JSON(jsondata);
            return data;
        }
    }
}
