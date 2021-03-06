﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class SearchResultCommon
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("last_id")]
        public long LastId { get; set; }
    }
}
