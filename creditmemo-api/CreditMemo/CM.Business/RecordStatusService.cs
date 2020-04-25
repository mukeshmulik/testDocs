using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class RecordStatusService : IRecordStatusService
    {
        public RecordStatusService(IRecordStatusDBClient _recordStatusDBClient)
        {
            _RecordStatusDBClient = _recordStatusDBClient;
        }

        public IRecordStatusDBClient _RecordStatusDBClient { get; }
        
        public string GetAllList()
        {
            var data = _RecordStatusDBClient.GetAllList();
            return data;
        }

    }
}
