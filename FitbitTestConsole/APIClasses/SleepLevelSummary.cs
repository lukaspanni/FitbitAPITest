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

        public static SleepLevelSummary operator +(SleepLevelSummary a, SleepLevelSummary b)
        {
            a.deep.minutes += b.deep.minutes;
            a.deep.count += b.deep.count;
            a.light.minutes += b.light.minutes;
            a.light.count += b.light.count;
            a.rem.minutes += b.rem.minutes;
            a.rem.count += b.rem.count;
            a.wake.minutes += b.wake.minutes;
            a.wake.count += b.wake.count;
            return a;
        }
    }
}