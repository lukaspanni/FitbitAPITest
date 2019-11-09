using FitbitAPITestConsole;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    /// <summary>
    /// Class is almost HeartRateIntradayTimeSeries, but important because API Response Objects
    /// for requests with specific start and end time are different!
    /// </summary>
    class HeartRateIntradayTimeSeriesTime : HeartRateData
    {
        [JsonProperty("activities-heart")]
        public HeartActivitiesTime[] activities_heart { get; set; }

    }
}
