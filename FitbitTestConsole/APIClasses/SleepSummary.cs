namespace FitbitAPITestConsole
{
    public class SleepSummary
    {
        public SleepSummaryStages stages { get; set; }
        public int totalMinutesAsleep { get; set; }
        public int totalSleepRecords { get; set; }
        public int totalTimeInBed { get; set; }

        public class SleepSummaryStages
        {
            public int deep { get; set; }
            public int light { get; set; }
            public int rem { get; set; }
            public int wake { get; set; }
        }
    }
}