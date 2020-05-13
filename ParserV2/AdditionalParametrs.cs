using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserV2
{
    public class AdditionalParametrs
    {
        [JsonProperty("additional_params")]
        public AdditionalParams AdditionalParams { get; set; }
        [JsonProperty("result")]
        public Result Result { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("search_result")]
        public SearchResult SearchResult { get; set; }
    }

    public partial class SearchResult
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }
    }

    public partial class AdditionalParams
    {
        [JsonProperty("lang_id")]
        public int LangId { get; set; }
        [JsonProperty("page")]
        public string Page { get; set; }
        [JsonProperty("view_type_id")]
        public int ViewTypeId { get; set; }
        [JsonProperty("target")]
        public string Target { get; set; }
        [JsonProperty("section")]
        public string Section { get; set; }
        [JsonProperty("catalog_name")]
        public string CatalogName { get; set; }
        [JsonProperty("elastica")]
        public bool Elastica { get; set; }
        [JsonProperty("nodejs")]
        public bool NodeJs { get; set; }
    }
}
