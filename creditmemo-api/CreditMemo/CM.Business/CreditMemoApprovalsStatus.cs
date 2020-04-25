using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditMemoApprovalsStatus : ICreditMemoApprovalStatus
    {
        public CreditMemoApprovalsStatus(ICreditMemoApprovalStatusDBClient _creditMemoApprovalStatusDBClient)
        {
            _CreditMemoApprovalStatusDBClient = _creditMemoApprovalStatusDBClient;
        }
        public ICreditMemoApprovalStatusDBClient _CreditMemoApprovalStatusDBClient { get; }
        public string GetCreditMemoApprovalStatus()
        {
            var data = _CreditMemoApprovalStatusDBClient.GetCreditMemoApprovalStatus();
            return data;
        }
    }
}
