using Newtonsoft.Json;

namespace FitbitAPITestConsole
{
    class HeartRateIntradayTimeSeries
    {
        [JsonProperty("activities-heart")]
        public HeartActivities[] activities_heart { get; set; }
        //large object!
        [JsonProperty("activities-heart-intraday")]
        public HeartActivitiesIntraday activities_heart_intraday { get; set; }
    }
}
