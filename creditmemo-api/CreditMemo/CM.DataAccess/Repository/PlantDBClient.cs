using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class PlantDBClient : IPlantDBClient
    {
        public string ConnectionString { get; set; }
        public PlantDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public string GetAllPlant()
        {
            return SqlHelper.ExecuteProcedureReturnString(ConnectionString, SPConstants.uspGetAllPlant, null);
            //return SqlHelper.ExecuteProcedureReturnList<Plant>(ConnectionString, SPConstants.uspGetAllPlant, null);
        }
    }
}
