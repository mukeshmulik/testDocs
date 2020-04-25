using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoInfoService : ICreditMemoInfoService
    {
        public CreditMemoInfoService(ICreditMemoInfoDBClient _creditMemoInfoDBClient)
        {
            _CreditMemoInfoDBClient = _creditMemoInfoDBClient;
        }
        public ICreditMemoInfoDBClient _CreditMemoInfoDBClient { get; }

        public List<CMRequest> GetAllCreditMemo()
        {
            var data = _CreditMemoInfoDBClient.GetAllCreditMemo();
            return data;
        }
        public CMRequest GetCreditMemoDetailsByID(int CMRequestID)
        {
            var data = _CreditMemoInfoDBClient.GetCreditMemoDetailsByID(CMRequestID);
            return data;
        }
        public CMRequest SaveCreditMemoDetails(CMRequest CMRequest)
        {
            var data = _CreditMemoInfoDBClient.SaveCreditMemoDetails(CMRequest);
            return data;
        }

        //public CreditMemoApprovalRequest SaveCreditMemoRequest_JSON(string jsondata)
        //{
        //    var data = _CreditMemoInfoDBClient.SaveCreditMemoRequest_JSON(jsondata);
        //    return data;
        //}
        public StoredProcedureReturnStatus SaveCreditMemoRequest_JSON(string jsondata)
        {
            var data = _CreditMemoInfoDBClient.SaveCreditMemoRequest_JSON(jsondata);
            return data;
        }

        public CreditMemoRejectRequest RejectCreditMemoRequest_JSON(string jsondata)
        {
            var data = _CreditMemoInfoDBClient.RejectCreditMemoRequest_JSON(jsondata);
            return data;
        }
    }
}
