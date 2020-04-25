
using CM.Model;
using System.Collections.Generic;

namespace CM.Contract.BusinessContract
{
    public interface ILogActivityService
    {
        string GetAllLogActivityList(int UserID);
        string SaveLogActivity(LogActivity logActivity);
        void WriteLogActivity(string LogMessage, string RemoteIP, string DirectoryPath);

    }
}
