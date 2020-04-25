using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoProductDetailsService
    {
        List<CreditMemoProductDetails> GetProductDetailsByID(int CMRequestID);
        CreditMemoProductDetails SaveProductDetails(CreditMemoProductDetails CreditMemoProductDetails);
    }
}
