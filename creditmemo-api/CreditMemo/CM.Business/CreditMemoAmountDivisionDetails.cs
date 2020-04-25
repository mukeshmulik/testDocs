using System;
using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoAmountDivisionDetails : ICreditMemoAmountDivisionDetail
    {
        public CreditMemoAmountDivisionDetails(ICreditMemoAmountDivisionDetailDBClient _creditMemoAmountDivisionDetailDBClient)
        {
            _CreditMemoAmountDivisionDetailDBClient = _creditMemoAmountDivisionDetailDBClient;
        }
        public ICreditMemoAmountDivisionDetailDBClient _CreditMemoAmountDivisionDetailDBClient { get; }
        public List<CreditMemoAmountDivisionDetail> GetCreditMemoAmountDivisionDetailByCMRequestID(int CMRequestID)
        {
            var data = _CreditMemoAmountDivisionDetailDBClient.GetCreditMemoAmountDivisionDetailByCMRequestID(CMRequestID);
            return data;
        }
        public CreditMemoAmountDivisionDetail SaveCreditMemoAmountDivisionDetail_JSON(string jsondata)
        {
            var data = _CreditMemoAmountDivisionDetailDBClient.SaveCreditMemoAmountDivisionDetail_JSON(jsondata);
            return data;
        }
    }
}
