using System;
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ICreditMemoErrorCodeDBClient
    {
        List<ErrorCode> GetCreditErrorCodeByReasonID(int ReasonID);
    }
}
