using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System.Collections.Generic;

namespace CM.Business
{
    public class Plants : IPlant
    {
        public Plants(IPlantDBClient _plantDBClient)
        {
            _PlantDBClient = _plantDBClient;
        }
        public IPlantDBClient _PlantDBClient { get; }
        public string GetAllPlant()
        {
            var data = _PlantDBClient.GetAllPlant();
            return data;
        }
    }
}
