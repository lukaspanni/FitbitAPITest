using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FitbitTestConsole.Properties;
using System.IO;

namespace FitbitAPITestConsole
{
    class Program
    {
        private static GetDataHandler dataHandler;
        static void Main()
        {
            dataHandler = new GetDataHandler();

            GetSleepData();

            Console.ReadKey(true);
        }

        //test
        private static void GetSleepData()
        {
            DateTime startDate = DateTime.Now.AddDays(-30);
            DateTime endDate = DateTime.Now;

            dataHandler.GetData<FitbitSleepWrapper>(APIEndpoints.SleepDataPath(DateTime.Now), (sleep) =>
            {
                Array.Sort(sleep.sleep, Comparer<SleepData>.Create((x, y) => x.dateOfSleep.CompareTo(y.dateOfSleep)));
                //Use SleepLevelSummary Type to store total summary
                //Sleep Logs by Date Range returns individual summaries
                SleepLevelSummary sum = new SleepLevelSummary
                {
                    deep = new SleepLevelSummary.SleepPhaseData(),
                    wake = new SleepLevelSummary.SleepPhaseData(),
                    light = new SleepLevelSummary.SleepPhaseData(),
                    rem = new SleepLevelSummary.SleepPhaseData()
                };
                StringBuilder sb = new StringBuilder();
                foreach (SleepData sd in sleep.sleep)
                {
                    Array.Sort(sd.levels.data, Comparer<SleepLevelData>.Create((x, y) => x.level.CompareTo(y.level)));
                    foreach (SleepLevelData sld in sd.levels.data)
                    {
                        Console.WriteLine("{0,-15}{1,10}{2,10}s", sld.dateTime, sld.level, sld.seconds);
                        sb.Append(string.Format("{0,-15};{1,10};{2,10}\n", sld.dateTime, sld.level, sld.seconds));
                    }
                    sum += sd.levels.summary;
                    Console.WriteLine();
                }
                File.WriteAllText("E:\\sleep.csv", sb.ToString());
                Console.WriteLine("Summary:");
                Console.WriteLine("{0,-10}{1,5}{2,20}", "Phase", "Count", "Duration [min]");
                Console.WriteLine(new string('=', 35));
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "Deep:", sum.deep.count, sum.deep.minutes);
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "Light:", sum.light.count, sum.light.minutes);
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "REM:", sum.rem.count, sum.rem.minutes); ;
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "Wake:", sum.wake.count, sum.wake.minutes);
            });

        }


    }
}
