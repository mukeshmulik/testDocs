﻿using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ICreditMemoErrorCode
    {        
        List<ErrorCode> GetCreditErrorCodeByReasonID(int ReasonID);
    }
}
