using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoAmountDivisionDetailDBClient
    {
        List<CreditMemoAmountDivisionDetail> GetCreditMemoAmountDivisionDetailByCMRequestID(int CMRequestID);
        CreditMemoAmountDivisionDetail SaveCreditMemoAmountDivisionDetail_JSON(string jsondata);
    }
}
