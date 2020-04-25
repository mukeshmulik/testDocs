using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoAttachmentDetailsService
    {
        List<CreditMemoAttachmentDetails> GetAttachmentsByID(int CMRequestID);
        CreditMemoAttachmentDetails SaveAttachments(CreditMemoAttachmentDetails CreditMemoAttachmentDetails);
    }
}
