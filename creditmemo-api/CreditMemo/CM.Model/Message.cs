using System;

namespace CM.Model
{
    public class Message
    {
        public bool IsSuccess { get; set; }

        public string ReturnMessage { get; set; }

        public string ErrorMessage { get; set; }

        public object Data { get; set; }
        public DateTime ResponseTime { get; set; }
    }
}

