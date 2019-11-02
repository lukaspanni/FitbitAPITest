using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
   
    class SleepData
    {
        public DateTime dateOfSleep { get; set; }
        public long duration { get; set; }
        public int efficiency { get; set; }
        public DateTime endTime { get; set; }
        public int infoCode { get; set; }
        public bool isMainSleep { get; set; }
        //SleepLevel
        public object levels { get; set; }
        public long logId { get; set; }
        public int minutesAfterWakeup { get; set; }
        public int minutesAsleep { get; set; }
        public int minutesAwake { get; set; }
        public int minutesToFallAsleep { get; set; }
        public DateTime startTime { get; set; }
        public int timeInBed { get; set; }
        public string type { get; set; }


    }
}
