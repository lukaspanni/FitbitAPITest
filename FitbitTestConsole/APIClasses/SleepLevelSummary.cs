namespace FitbitAPITestConsole
{
    public class SleepLevelSummary
    {
        public SleepPhaseData deep { get; set; }
        public SleepPhaseData light { get; set; }
        public SleepPhaseData rem { get; set; }
        public SleepPhaseData wake { get; set; }

        public class SleepPhaseData
        {
            public int count { get; set; }
            public int minutes { get; set; }
            public int thirtyDayAvgMinutes { get; set; }
        }
    }
}