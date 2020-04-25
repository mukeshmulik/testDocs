using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class CreditApprovalLevel
    {
        public int ID { get; set; }
        public string CreditLevelName { get; set; }
        public decimal CreditRangeTo { get; set; }
        public decimal CreditRangeFrom { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RecordStatusId { get; set; }

        //public string CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public string ModifiedBy { get; set; }
        //public DateTime ModifiedOn { get; set; }
    }
}
