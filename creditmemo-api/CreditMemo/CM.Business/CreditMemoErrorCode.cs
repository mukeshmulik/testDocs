using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoErrorCode : ICreditMemoErrorCode
    {
        public CreditMemoErrorCode(ICreditMemoErrorCodeDBClient _creditMemoErrorCodeDBClient)
        {
            _CreditMemoErrorCodeDBClient = _creditMemoErrorCodeDBClient;
        }
        public ICreditMemoErrorCodeDBClient _CreditMemoErrorCodeDBClient { get; }
        public List<ErrorCode> GetCreditErrorCodeByReasonID(int ReasonID)
        {
            var data = _CreditMemoErrorCodeDBClient.GetCreditErrorCodeByReasonID(ReasonID);
            return data;
        }
    }
}
