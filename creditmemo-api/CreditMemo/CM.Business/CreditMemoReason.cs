using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoReason : ICreditMemoReason
    {
        public CreditMemoReason(ICreditMemoReasonDBClient _creditMemoReasonDBClient)
        {
            _CreditMemoReasonDBClient = _creditMemoReasonDBClient;
        }
        public ICreditMemoReasonDBClient _CreditMemoReasonDBClient { get; }
        public string GetCreditMemoReason()
        {
            var data = _CreditMemoReasonDBClient.GetCreditMemoReason();
            return data;
        }
        public ReasonErrorCode SaveCreditMemoReasonAndErrorCode_JSON(string jsondata)
        {
            var data = _CreditMemoReasonDBClient.SaveCreditMemoReasonAndErrorCode_JSON(jsondata);
            return data;
        }
        public ReasonErrorCode DeleteCreditMemoReasonAndErrorCode_JSON(string jsondata)
        {
            var data = _CreditMemoReasonDBClient.DeleteCreditMemoReasonAndErrorCode_JSON(jsondata);
            return data;
        }
    }
}
