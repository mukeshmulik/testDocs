using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoModelDetailsService
    {
        List<CreditMemoModelDetails> GetModelDetailsByID(int CMRequestID);
        CreditMemoModelDetails SaveModelDetails(CreditMemoModelDetails CreditMemoModelDetails);
    }
}
