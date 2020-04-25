using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;

namespace CM.Business
{
    public class MacPacErrorCodes : IMacPacErrorCode
    {
        public MacPacErrorCodes(IMacPacErrorCodeDBClient _macPacErrorCodeDBClient)
        {
            _MacPacErrorCodeDBClient = _macPacErrorCodeDBClient;
        }
        public IMacPacErrorCodeDBClient _MacPacErrorCodeDBClient { get; }
        public string GetMacPacErrorCodes()
        {
            var data = _MacPacErrorCodeDBClient.GetMacPacErrorCodes();
            return data;
        }
    }
}
