using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    class HeartActivitiesTime
    {
        public HeartActivities.HeartRateZone[] customHeartRateZones { get; set; }
        public DateTime dateTime { get; set; }
        public HeartActivities.HeartRateZone[] heartRateZones { get; set; }
        //???? why is it a string
        public string value { get; set; }

    }
}
