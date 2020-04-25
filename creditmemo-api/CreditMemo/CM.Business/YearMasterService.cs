using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class YearMasterService : IYearMasterService
    {
        public YearMasterService(IYearMasterDBClient _yearMasterDBClient)
        {
            _YearMasterDBClient = _yearMasterDBClient;
        }

        public IYearMasterDBClient _YearMasterDBClient { get; }
        
        public string GetAllList()
        {
            var data = _YearMasterDBClient.GetAllList();
            return data;
        }

    }
}
