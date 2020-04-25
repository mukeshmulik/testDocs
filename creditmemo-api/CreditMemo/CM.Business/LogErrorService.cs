using System;
using System.Collections.Generic;
using System.Text;
using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;

namespace CM.Business
{
    public class LogErrorService : ILogErrorService
    {
        public LogErrorService(ILogErrorDBClient logErrorService)
        {
            _LogErrorService = logErrorService;
        }

        public ILogErrorDBClient _LogErrorService { get; }

        public string SaveLogError(LogError logActivity)
        {
           return  _LogErrorService.SaveLogError(logActivity);
        }
    }
}
