using System;

namespace FitbitAPITestConsole
{
    public class HeartActivitiesIntraday
    {
        public DataSetEntry[] dataset { get; set; }
        public int datasetInterval { get; set; }
        public string datasetType { get; set; }

        public class DataSetEntry
        {
            public DateTime time { get; set; }
            public int value { get; set; }
        }
    }
}