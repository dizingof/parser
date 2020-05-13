using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
   public class All
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

        [JsonProperty("page")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Page { get; set; }

        [JsonProperty("marka_id")]
        public List<object> AllMarkaId { get; set; }

        [JsonProperty("excludeMM")]
        public List<object> ExcludeMm { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("lang_id")]
        public long LangId { get; set; }

        [JsonProperty("limit_page")]
        public object LimitPage { get; set; }

        [JsonProperty("last_id")]
        public long LastId { get; set; }

        [JsonProperty("last_search_id")]
        public long LastSearchId { get; set; }

        [JsonProperty("saledParam")]
        public long SaledParam { get; set; }

        [JsonProperty("state_id")]
        public long StateId { get; set; }

        [JsonProperty("city_id")]
        public long CityId { get; set; }

        [JsonProperty("state_from")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StateFrom { get; set; }

        [JsonProperty("city_from")]
        public long CityFrom { get; set; }

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

        [JsonProperty("useOrigAutoTable")]
        public bool UseOrigAutoTable { get; set; }

        [JsonProperty("withoutStatus")]
        public bool WithoutStatus { get; set; }

        [JsonProperty("with_video")]
        public bool WithVideo { get; set; }

        [JsonProperty("under_credit")]
        public long UnderCredit { get; set; }

        [JsonProperty("confiscated_car")]
        public long ConfiscatedCar { get; set; }

        [JsonProperty("old_only")]
        public bool OldOnly { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("person_id")]
        public long PersonId { get; set; }

        [JsonProperty("with_discount")]
        public bool WithDiscount { get; set; }

        [JsonProperty("auto_id_str")]
        public string AutoIdStr { get; set; }

        [JsonProperty("black_user_id")]
        public long BlackUserId { get; set; }

        [JsonProperty("order_by")]
        public long OrderBy { get; set; }

        [JsonProperty("is_online")]
        public bool IsOnline { get; set; }

        [JsonProperty("last_send_id")]
        public bool LastSendId { get; set; }

        [JsonProperty("withoutCache")]
        public bool WithoutCache { get; set; }

        [JsonProperty("with_last_id")]
        public bool WithLastId { get; set; }

        [JsonProperty("color")]
        public long Color { get; set; }

        [JsonProperty("color_id")]
        public long ColorId { get; set; }

        [JsonProperty("gear_id")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> GearId { get; set; }

        [JsonProperty("top")]
        public long Top { get; set; }

        [JsonProperty("drive_type")]
        public long DriveType { get; set; }

        [JsonProperty("country")]
        public long Country { get; set; }

        [JsonProperty("mm_country")]
        public List<object> MmCountry { get; set; }

        [JsonProperty("mm_country_exeption")]
        public List<object> MmCountryExeption { get; set; }

        [JsonProperty("currency_id")]
        public long CurrencyId { get; set; }

        [JsonProperty("currencies_arr")]
        public List<object> CurrenciesArr { get; set; }

        [JsonProperty("auto_repairs")]
        public long AutoRepairs { get; set; }

        [JsonProperty("hide_black_list")]
        public List<object> HideBlackList { get; set; }

        [JsonProperty("fuelRateFrom")]
        public long FuelRateFrom { get; set; }

        [JsonProperty("fuelRateTo")]
        public long FuelRateTo { get; set; }

        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("body_id")]
        public List<object> BodyId { get; set; }

        [JsonProperty("bodyStyleId")]
        public List<object> BodyStyleId { get; set; }

        [JsonProperty("metallic")]
        public long Metallic { get; set; }

        [JsonProperty("raceFrom")]
        public long RaceFrom { get; set; }

        [JsonProperty("raceTo")]
        public long RaceTo { get; set; }

        [JsonProperty("sid")]
        public long Sid { get; set; }

        [JsonProperty("star_auto")]
        public long StarAuto { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("drive_id")]
        public long DriveId { get; set; }

        [JsonProperty("door")]
        public long Door { get; set; }

        [JsonProperty("price_do")]
        public long AllPriceDo { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("auto_ids_search_position")]
        public long AutoIdsSearchPosition { get; set; }

        [JsonProperty("print_qs")]
        public long PrintQs { get; set; }

        [JsonProperty("last_auto_id")]
        public long LastAutoId { get; set; }

        [JsonProperty("is_hot")]
        public long IsHot { get; set; }

        [JsonProperty("deletedAutoSearch")]
        public long DeletedAutoSearch { get; set; }

        [JsonProperty("can_be_checked")]
        public long CanBeChecked { get; set; }

        [JsonProperty("seatsFrom")]
        public long SeatsFrom { get; set; }

        [JsonProperty("seatsTo")]
        public long SeatsTo { get; set; }

        [JsonProperty("wheelFormulaId")]
        public long WheelFormulaId { get; set; }

        [JsonProperty("axleId")]
        public long AxleId { get; set; }

        [JsonProperty("carryingTo")]
        public long CarryingTo { get; set; }

        [JsonProperty("carryingFrom")]
        public long CarryingFrom { get; set; }

        [JsonProperty("company_id")]
        public long CompanyId { get; set; }

        [JsonProperty("company_type")]
        public long CompanyType { get; set; }

        [JsonProperty("matched_country")]
        public long MatchedCountry { get; set; }

        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("sellerType")]
        public object SellerType { get; set; }

        [JsonProperty("purpose")]
        public object Purpose { get; set; }

        [JsonProperty("class")]
        public object Class { get; set; }
    }
}
