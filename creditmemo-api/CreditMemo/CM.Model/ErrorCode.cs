using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Model
{
    public class ErrorCode
    {
        public int ErrorCodeID { get; set; }
        public string ErrorCodeName { get; set; }        
        public int ReasonID { get; set; }
        public int RecordStatusId { get; set; }
    }
}
