using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Result
    {
        [JsonProperty("search_result")]
        public SearchResultClass SearchResult { get; set; }

        [JsonProperty("search_result_common")]
        public SearchResultCommon SearchResultCommon { get; set; }

        [JsonProperty("isCommonSearch")]
        public bool IsCommonSearch { get; set; }

        [JsonProperty("active_marka")]
        public object ActiveMarka { get; set; }

        [JsonProperty("active_model")]
        public object ActiveModel { get; set; }

        [JsonProperty("active_state")]
        public object ActiveState { get; set; }

        [JsonProperty("active_city")]
        public object ActiveCity { get; set; }

        [JsonProperty("revies")]
        public object Revies { get; set; }

        [JsonProperty("additional")]
        public Additional Additional { get; set; }
    }
}
