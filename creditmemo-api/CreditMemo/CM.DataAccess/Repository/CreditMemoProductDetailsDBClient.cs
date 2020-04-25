using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static CM.Common.Constants;

namespace CM.DataAccess.Repository
{
    public class CreditMemoProductDetailsDBClient : ICreditMemoProductDetailsDBClient
    {
        public string ConnectionString { get; set; }
        public CreditMemoProductDetailsDBClient(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public List<CreditMemoProductDetails> GetProductDetailsByID(int CMID)
        {
            SqlParameter[] param = {
                new SqlParameter("@CMRequestID", CMID)
            };
            return SqlHelper.ExecuteProcedureReturnList<CreditMemoProductDetails>(ConnectionString, SPConstants.uspGetAllProductDetailsByCMRequestID, param);
        }
        public CreditMemoProductDetails SaveProductDetails(CreditMemoProductDetails CreditMemoProductDetails)
        {
            var param = new SqlParameter[]
            {
                new SqlParameter("@ID", CreditMemoProductDetails.ID),
                new SqlParameter("@CMRequestID", CreditMemoProductDetails.CMRequestID),
                new SqlParameter("@CtrlItem", CreditMemoProductDetails.CtrlItem),
                new SqlParameter("@PltItem", CreditMemoProductDetails.PltItem),
                new SqlParameter("@Model", CreditMemoProductDetails.Model),
                new SqlParameter("@Width", CreditMemoProductDetails.Width),
                new SqlParameter("@Height", CreditMemoProductDetails.Height),
                new SqlParameter("@SizeInfo", CreditMemoProductDetails.SizeInfo),
                new SqlParameter("@QuantityOrdered", CreditMemoProductDetails.QuantityOrdered),
                new SqlParameter("@QuantityShipped", CreditMemoProductDetails.QuantityShipped),
                new SqlParameter("@QuantityRemaining", CreditMemoProductDetails.QuantityRemaining),
                new SqlParameter("@Price", CreditMemoProductDetails.Price),
                new SqlParameter("@Total", CreditMemoProductDetails.Total),
                new SqlParameter("@RecordStatusId", CreditMemoProductDetails.RecordStatusId),
                new SqlParameter("@CreatedBy", CreditMemoProductDetails.CreatedBy),
                new SqlParameter("@ModifiedBy", CreditMemoProductDetails.ModifiedBy)
            };            
            return SqlHelper.ExecuteProcedureReturnSingleObject<CreditMemoProductDetails>(ConnectionString, SPConstants.uspSaveProductDetails, param);
        }
    }
}
