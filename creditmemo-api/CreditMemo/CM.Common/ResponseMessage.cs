using CM.Model;
using System;

namespace CM.Common
{
    public class ResponseMessage
    {
        public Message GetMessage(object Data,string ReturnMessage,string ErrorMessage,bool IsSuccess)
        {
            var Obj = new Message();
            Obj.Data = Data;
            Obj.ReturnMessage = ReturnMessage;
            Obj.ErrorMessage = ErrorMessage;
            Obj.IsSuccess = IsSuccess;
            Obj.ResponseTime = DateTime.Now;
            return Obj;
        }
    }
}
