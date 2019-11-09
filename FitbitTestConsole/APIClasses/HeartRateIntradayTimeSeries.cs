using Newtonsoft.Json;

namespace FitbitAPITestConsole
{
    class HeartRateIntradayTimeSeries : HeartRateData
    {
        [JsonProperty("activities-heart")]
        public HeartActivities[] activities_heart { get; set; }
        
    }
}
