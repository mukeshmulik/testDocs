using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoAmountDivisionDetailDBClient : ICreditMemoAmountDivisionDetailDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoAmountDivisionDetailDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<CreditMemoAmountDivisionDetail> GetCreditMemoAmountDivisionDetailByCMRequestID(int CMRequestID)
        {
            SqlParameter[] param = {
                new SqlParameter("@CMRequestID", CMRequestID)
            };
            return SqlHelper.ExecuteProcedureReturnList<CreditMemoAmountDivisionDetail>(ConnectionString, SPConstants.uspGetCreditMemoAmountDivisionDetailByCMRequestID, param);
        }
        public CreditMemoAmountDivisionDetail SaveCreditMemoAmountDivisionDetail_JSON(string jsondata)
        {
            var param = new SqlParameter("@JsonObject", jsondata);
            return SqlHelper.ExecuteProcedureReturnSingleObject<CreditMemoAmountDivisionDetail>(ConnectionString, SPJSONConstants.uspSaveCreditMemoAmountDivisionDetail_JSON, param);
        }
    }
}
