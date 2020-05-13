using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserV2
{
    public class SearchResultClass
    {
        [JsonProperty("ids")]
        public List<int> Ids { get; set; }
    }
}
