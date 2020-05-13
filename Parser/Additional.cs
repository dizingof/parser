using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Additional
    {
        [JsonProperty("user_auto_positions")]
        public List<object> UserAutoPositions { get; set; }

        [JsonProperty("search_params")]
        public SearchParams SearchParams { get; set; }

        [JsonProperty("query_string")]
        public string QueryString { get; set; }
    }
}
