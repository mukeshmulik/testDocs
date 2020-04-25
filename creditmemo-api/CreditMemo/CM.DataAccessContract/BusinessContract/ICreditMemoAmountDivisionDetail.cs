using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoAmountDivisionDetail
    {
        List<CreditMemoAmountDivisionDetail> GetCreditMemoAmountDivisionDetailByCMRequestID(int CMRequestID);
        CreditMemoAmountDivisionDetail SaveCreditMemoAmountDivisionDetail_JSON(string jsondata);
    }
}
