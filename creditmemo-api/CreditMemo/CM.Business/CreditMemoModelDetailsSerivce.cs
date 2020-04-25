using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoModelDetailsSerivce : ICreditMemoModelDetailsService
    {
        public ICreditMemoModelDetailsDBClient _CreditMemoModelDetailsDBClient { get; }
        public CreditMemoModelDetailsSerivce(ICreditMemoModelDetailsDBClient _creditMemoModelDetailsDBClient)
        {
            _CreditMemoModelDetailsDBClient = _creditMemoModelDetailsDBClient;
        }
        
        public List<CreditMemoModelDetails> GetModelDetailsByID(int CMRequestID)
        {
            var data = _CreditMemoModelDetailsDBClient.GetModelDetailsByID(CMRequestID);
            return data;
        }
        public CreditMemoModelDetails SaveModelDetails(CreditMemoModelDetails CreditMemoModelDetails)
        {
            var data = _CreditMemoModelDetailsDBClient.SaveModelDetails(CreditMemoModelDetails);
            return data;
        }

    }
}
