using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoInfoDBClient
    {
        List<CMRequest> GetAllCreditMemo();
        CMRequest GetCreditMemoDetailsByID(int CMRequestID);
        CMRequest SaveCreditMemoDetails(CMRequest CMRequest);

        //CreditMemoApprovalRequest SaveCreditMemoRequest_JSON(string jsondata);
        StoredProcedureReturnStatus SaveCreditMemoRequest_JSON(string jsondata);
        CreditMemoRejectRequest RejectCreditMemoRequest_JSON(string jsondata);
    }
}
