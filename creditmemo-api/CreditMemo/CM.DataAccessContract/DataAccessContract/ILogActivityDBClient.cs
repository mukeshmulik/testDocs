using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.DataAccessContract
{
    public interface ILogActivityDBClient
    {
        string GetAllLogActivityList(int UserID);
        
        string SaveLogActivity(LogActivity logActivity);
        
    }
}
