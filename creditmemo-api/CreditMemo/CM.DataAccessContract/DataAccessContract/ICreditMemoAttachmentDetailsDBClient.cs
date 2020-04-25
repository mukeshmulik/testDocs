using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoAttachmentDetailsDBClient
    {
        List<CreditMemoAttachmentDetails> GetAttachmentsByID(int CMID);

        CreditMemoAttachmentDetails SaveAttachments(CreditMemoAttachmentDetails CreditMemoAttachmentDetails);

    }
}
