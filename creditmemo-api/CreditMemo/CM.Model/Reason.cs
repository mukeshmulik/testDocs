using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class Reason
    {  
        public int ReasonID { get; set; }
        public string ReasonName { get; set; }
        public int RecordStatusId { get; set; }
    }
    public class ReasonErrorCode
    {
        public int ReasonID { get; set; }
        public string ReasonName { get; set; }
        public int ErrorCodeID { get; set; }
        public string ErrorCodeName { get; set; }
        public int RecordStatusId { get; set; }
    }
}
