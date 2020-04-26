using System;
using System.Collections.Generic;
using System.Text;

namespace Auxillo.Model
{
    public class LogError
    {
        public string Source { get; set; }
        public string FunctionName { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string InnerException { get; set; }
        public int RecordStatusId { get; set; }
        public string CreatedBy { get; set; }

    }
}
