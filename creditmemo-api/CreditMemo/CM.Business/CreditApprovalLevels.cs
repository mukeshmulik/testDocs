using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class CreditApprovalLevels : ICreditApprovalLevel
    {
        public CreditApprovalLevels(ICreditApprovalLevelDBClient _creditApprovalLevelDBClient)
        {
            _CreditApprovalLevelDBClient = _creditApprovalLevelDBClient;
        }
        public ICreditApprovalLevelDBClient _CreditApprovalLevelDBClient { get; }

        public string GetAllCreditApprovalLevel()
        {
            var data = _CreditApprovalLevelDBClient.GetAllCreditApprovalLevel();
            return data;
        }
    }
}
