using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoReason
    {
        string GetCreditMemoReason();
        ReasonErrorCode SaveCreditMemoReasonAndErrorCode_JSON(string jsondata);
        ReasonErrorCode DeleteCreditMemoReasonAndErrorCode_JSON(string jsondata);
    }
}
