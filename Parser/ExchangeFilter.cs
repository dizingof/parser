using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class ExchangeFilter
    {
        [JsonProperty("marka_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MarkaId { get; set; }

        [JsonProperty("model_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ModelId { get; set; }
    }
}
