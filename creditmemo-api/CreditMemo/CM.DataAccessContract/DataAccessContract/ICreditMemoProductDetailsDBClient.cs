using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoProductDetailsDBClient
    {
        List<CreditMemoProductDetails> GetProductDetailsByID(int CMRequestID);
        CreditMemoProductDetails SaveProductDetails(CreditMemoProductDetails CreditMemoProductDetails);
    }
}
