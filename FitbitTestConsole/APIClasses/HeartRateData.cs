using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    class HeartRateData
    {
        [JsonProperty("activities-heart-intraday")]
        public HeartActivitiesIntraday activities_heart_intraday { get; set; }
    }
}
