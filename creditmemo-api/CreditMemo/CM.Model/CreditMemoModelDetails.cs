using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class CreditMemoModelDetails
    {
        public int ID { get; set; }
        public int CMRequestID { get; set; }
        public string Model { get; set; }
        public string DIV { get; set; }
        public string GLAccount { get; set; }
        public decimal Amount { get; set; }
        public bool Approved { get; set; }
        public int RecordStatusId { get; set; }
        public string ModifiedBy { get; set; }
        public string CreatedBy { get; set; }
        public int CMModelDetailID { get; set; }

        //public int CMModelDetailID { get; set; }
        //public string Model { get; set; }
        //public string DIV { get; set; }
        //public string GLAccount { get; set; }
        //public decimal Amount { get; set; }
        //public bool Approved { get; set; }

    }
}
