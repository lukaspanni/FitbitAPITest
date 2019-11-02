using System;

namespace FitbitAPITestConsole
{
    public class HeartActivities
    {
        public DateTime dateTime { get; set; }
        public HeartActivityValue value { get; set; }

        public class HeartActivityValue
        {
            public HeartRateZone[] customHeartRateZones { get; set; }
            public HeartRateZone[] heartRateZones { get; set; }
            public int restingHeartRate { get; set; }

        }
        public class HeartRateZone
        {
            public double caloriesOut { get; set; }
            public int max { get; set; }
            public int min { get; set; }
            public int minutes { get; set; }
            public string name { get; set; }

        }
    }
}