using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class CreditMemoProductDetails
    {
        public int ID { get; set; }
        public int CMRequestID { get; set; }
        public string CtrlItem { get; set; }
        public string PltItem { get; set; }
        public string Model { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public string SizeInfo { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityShipped { get; set; }
        public int QuantityRemaining { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int RecordStatusId { get; set; }

        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }

    }
}
