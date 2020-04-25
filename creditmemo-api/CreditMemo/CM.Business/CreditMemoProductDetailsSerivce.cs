using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoProductDetailsSerivce : ICreditMemoProductDetailsService
    {
        public ICreditMemoProductDetailsDBClient _CreditMemoProductDetailsDBClient { get; }
        public CreditMemoProductDetailsSerivce(ICreditMemoProductDetailsDBClient _creditMemoProductDetailsDBClient)
        {
            _CreditMemoProductDetailsDBClient = _creditMemoProductDetailsDBClient;
        }
        
        public List<CreditMemoProductDetails> GetProductDetailsByID(int CMRequestID)
        {
            var data = _CreditMemoProductDetailsDBClient.GetProductDetailsByID(CMRequestID);
            return data;
        }

        public CreditMemoProductDetails SaveProductDetails(CreditMemoProductDetails CreditMemoProductDetails)
        {
            var data = _CreditMemoProductDetailsDBClient.SaveProductDetails(CreditMemoProductDetails);
            return data;
        }

    }
}
