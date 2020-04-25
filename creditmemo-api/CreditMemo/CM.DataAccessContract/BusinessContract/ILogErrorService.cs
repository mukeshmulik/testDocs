using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.BusinessContract
{
    public interface ILogErrorService
    {
        string SaveLogError(LogError logError);
    }
}
