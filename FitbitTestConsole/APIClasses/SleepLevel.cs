namespace FitbitAPITestConsole
{
    public class SleepLevel
    {

        //Difference data - shortData: https://dev.fitbit.com/build/reference/web-api/sleep/ 
        //Note: shortData is only included for stages sleep logs and includes wake periods that are 3 minutes or less in duration. 
        //This distinction is to simplify graphically distinguishing short wakes from longer wakes, but they are physiologically equivalent.
        public SleepLevelData[] data { get; set; }

        public SleepLevelData[] shortData { get; set; }

        public SleepLevelSummary summary { get; set; }
    }
}