using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoInfoService
    {
        List<CMRequest> GetAllCreditMemo();
        CMRequest GetCreditMemoDetailsByID(int CMRequestID);
        CMRequest SaveCreditMemoDetails(CMRequest CMRequest);

        //CreditMemoApprovalRequest SaveCreditMemoRequest_JSON(string jsondata);
        StoredProcedureReturnStatus SaveCreditMemoRequest_JSON(string jsondata);
        CreditMemoRejectRequest RejectCreditMemoRequest_JSON(string jsondata);
    }
}
