using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class SearchParams
    {
        [JsonProperty("all")]
        public All All { get; set; }

        [JsonProperty("cleaned")]
        public Cleaned Cleaned { get; set; }
    }
}
