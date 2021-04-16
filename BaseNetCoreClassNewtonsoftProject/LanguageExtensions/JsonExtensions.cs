using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BaseNetCoreClassNewtonsoftProject.LanguageExtensions
{
    public static class JsonExtensions
    {
        /// <summary>
        /// Does json represent an array or single object
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static bool IsJsonArray(this string json) => JToken.Parse(json) is JArray;
    }
}
