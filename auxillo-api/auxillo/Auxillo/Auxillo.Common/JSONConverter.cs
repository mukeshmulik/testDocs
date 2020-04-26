using Auxillo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auxillo.Common
{
    public class JSONConvert<T>
    {
        public T DeserializeObject(string Data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Data);
        }
        public string SerializeObject(T Data)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(Data);
        }
    }
}
