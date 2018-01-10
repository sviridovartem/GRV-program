using System;
using Newtonsoft.Json;

namespace Grv.Web.Models.Extensions
{
    public static class JsonHelper
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //return serializer.Serialize(obj);
        }

        public static string ToJson(this object obj, int recursionDepth)
        {
            throw new NotImplementedException();
        }
    }

}