using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoReasonDBClient
    {
        string GetCreditMemoReason();
        ReasonErrorCode SaveCreditMemoReasonAndErrorCode_JSON(string jsondata);
        ReasonErrorCode DeleteCreditMemoReasonAndErrorCode_JSON(string jsondata);
    }
}
