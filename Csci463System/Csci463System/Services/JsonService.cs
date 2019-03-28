using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csci463System.Services
{
    public class JsonService
    {
        public string Serialize(object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        public T Deserialize<T>(string JsonStrinng)
        {
            T obj =  Newtonsoft.Json.JsonConvert.DeserializeObject<T>(JsonStrinng);
            return obj;
        }
    }
}
