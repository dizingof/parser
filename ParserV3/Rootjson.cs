using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserV3
{
    class Rootjson
    {
        [JsonProperty("result")]
        public Result Result { get; set; }
    }
}
