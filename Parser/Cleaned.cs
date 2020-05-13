using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class Cleaned
    {
        [JsonProperty("category_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CategoryId { get; set; }

        [JsonProperty("bodystyle")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Bodystyle { get; set; }

        [JsonProperty(";marka_id")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> MarkaId { get; set; }

        [JsonProperty("model_id")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> ModelId { get; set; }

        [JsonProperty("s_yers")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> SYers { get; set; }

        [JsonProperty("po_yers")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> PoYers { get; set; }

        [JsonProperty("brandOrigin")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> BrandOrigin { get; set; }

        [JsonProperty("price_ot")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PriceOt { get; set; }

        [JsonProperty(";price_do")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PriceDo { get; set; }

        [JsonProperty("currency")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Currency { get; set; }

        [JsonProperty("auctionPossible")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AuctionPossible { get; set; }

        [JsonProperty("with_real_exchange")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long WithRealExchange { get; set; }

        [JsonProperty("with_exchange")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long WithExchange { get; set; }

        [JsonProperty("exchange_filter")]
        public ExchangeFilter ExchangeFilter { get; set; }

        [JsonProperty("state")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> State { get; set; }

        [JsonProperty("city")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> City { get; set; }

        [JsonProperty("abroad")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Abroad { get; set; }

        [JsonProperty("custom")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Custom { get; set; }

        [JsonProperty("auto_options")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> AutoOptions { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Type { get; set; }

        [JsonProperty("gearbox")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Gearbox { get; set; }

        [JsonProperty("engineVolumeFrom")]
        public double EngineVolumeFrom { get; set; }

        [JsonProperty("engineVolumeTo")]
        public double EngineVolumeTo { get; set; }

        [JsonProperty("powerFrom")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PowerFrom { get; set; }

        [JsonProperty("powerTo")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PowerTo { get; set; }

        [JsonProperty("power_name")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PowerName { get; set; }

        [JsonProperty("countpage")]
        public long Countpage { get; set; }

        [JsonProperty("with_photo")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long WithPhoto { get; set; }

        [JsonProperty("marka_id")]
        public List<object> CleanedMarkaId { get; set; }

        [JsonProperty("excludeMM")]
        public List<object> ExcludeMm { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("lang_id")]
        public long LangId { get; set; }

        [JsonProperty("state_from")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StateFrom { get; set; }

        [JsonProperty("m_state")]
        public List<object> MState { get; set; }

        [JsonProperty("m_city")]
        public List<object> MCity { get; set; }

        [JsonProperty("marka")]
        public List<object> Marka { get; set; }

        [JsonProperty("model")]
        public List<object> Model { get; set; }

        [JsonProperty("mm_marka")]
        public List<object> MmMarka { get; set; }

        [JsonProperty("mm_model")]
        public List<object> MmModel { get; set; }

        [JsonProperty("mm_marka_filtr")]
        public List<object> MmMarkaFiltr { get; set; }

        [JsonProperty("mm_model_filtr")]
        public List<object> MmModelFiltr { get; set; }

        [JsonProperty("gear_id")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> GearId { get; set; }

        [JsonProperty("mm_country")]
        public List<object> MmCountry { get; set; }

        [JsonProperty("mm_country_exeption")]
        public List<object> MmCountryExeption { get; set; }

        [JsonProperty("currencies_arr")]
        public List<object> CurrenciesArr { get; set; }

        [JsonProperty("hide_black_list")]
        public List<object> HideBlackList { get; set; }

        [JsonProperty("body_id")]
        public List<object> BodyId { get; set; }

        [JsonProperty("bodyStyleId")]
        public List<object> BodyStyleId { get; set; }

        [JsonProperty("matched_country")]
        public long MatchedCountry { get; set; }
    }
}
