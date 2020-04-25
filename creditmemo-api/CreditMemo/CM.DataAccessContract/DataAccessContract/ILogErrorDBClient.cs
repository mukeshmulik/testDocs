using System;
using System.Collections.Generic;
using System.Text;
using CM.Model;

namespace CM.Contract.DataAccessContract
{
    public interface ILogErrorDBClient
    {
        string GetAllLogActivityList(int UserID);

        string SaveLogError(LogError logError);
    }
}
