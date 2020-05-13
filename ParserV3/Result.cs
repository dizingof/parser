using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserV3
{
    public partial class Result
    {
        [JsonProperty("search_result")]
        public SearchResult SearchResult { get; set; }
    }
}
