using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class SearchResult
    {
        [JsonProperty("additional_params")]
        public AdditionalParams AdditionalParams { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }
}
