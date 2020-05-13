using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserV3
{
    public class SearchResult
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }
    }
}
