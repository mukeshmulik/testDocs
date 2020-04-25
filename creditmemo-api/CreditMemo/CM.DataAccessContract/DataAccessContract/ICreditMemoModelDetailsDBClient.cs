using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoModelDetailsDBClient
    {
        List<CreditMemoModelDetails> GetModelDetailsByID(int CMRequestID);
        CreditMemoModelDetails SaveModelDetails(CreditMemoModelDetails CreditMemoModelDetails);
    }
}
