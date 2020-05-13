using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class AdditionalParams
    {
        [JsonProperty("lang_id")]
        public long LangId { get; set; }

        [JsonProperty("page")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Page { get; set; }

        [JsonProperty("view_type_id")]
        public long ViewTypeId { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("catalog_name")]
        public string CatalogName { get; set; }

        [JsonProperty("elastica")]
        public bool Elastica { get; set; }

        [JsonProperty("nodejs")]
        public bool Nodejs { get; set; }
    }
}
