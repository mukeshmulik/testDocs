using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace CM.Business
{
    public class LogActivityService : ILogActivityService
    {
        public LogActivityService(ILogActivityDBClient _logActivityDBClient)
        {
            _LogActivityDBClient = _logActivityDBClient;
        }

        public ILogActivityDBClient _LogActivityDBClient { get; }
        
        public string GetAllLogActivityList(int UserID)
        {
            var data = _LogActivityDBClient.GetAllLogActivityList(UserID);
            return data;
        }
        public string SaveLogActivity(LogActivity logActivity)
        {
            var data = _LogActivityDBClient.SaveLogActivity(logActivity);
            return data;
        }

        public void WriteLogActivity(string LogMessage, string RemoteIP, string DirectoryPath)
        {
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
            FileStream fs = new FileStream(DirectoryPath + "\\" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt", FileMode.Append, FileAccess.Write);
            StreamWriter writter = new StreamWriter(fs);
            writter.WriteLine("[" + DateTime.Now.ToString() + "][" + RemoteIP + "]" + LogMessage);
            writter.Close();
        }
    }
}
