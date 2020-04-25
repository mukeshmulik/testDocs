using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoAttachmentDetailsSerivce : ICreditMemoAttachmentDetailsService
    {
        public ICreditMemoAttachmentDetailsDBClient _CreditMemoAttachmentDetailsDBClient { get; }
        public CreditMemoAttachmentDetailsSerivce(ICreditMemoAttachmentDetailsDBClient _creditMemoAttachmentDetailsDBClient)
        {
            _CreditMemoAttachmentDetailsDBClient = _creditMemoAttachmentDetailsDBClient;
        }
        
        public List<CreditMemoAttachmentDetails> GetAttachmentsByID(int CMID)
        {
            var data = _CreditMemoAttachmentDetailsDBClient.GetAttachmentsByID(CMID);
            return data;
        }
        public CreditMemoAttachmentDetails SaveAttachments(CreditMemoAttachmentDetails CreditMemoAttachmentDetails)
        {
            var data = _CreditMemoAttachmentDetailsDBClient.SaveAttachments(CreditMemoAttachmentDetails);
            return data;
        }

    }
}
