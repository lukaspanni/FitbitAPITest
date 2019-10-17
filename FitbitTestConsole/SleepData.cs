using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitTestConsole
{
    class SleepData
    {
        public DateTime dateOfSleep { get; set; }
        public long duration { get; set; }
        public int efficiency { get; set; }
        public DateTime endTime { get; set; }
        public int infoCode { get; set; }
        public bool isMainSleep { get; set; }

        public SleepLevel[] levels { get; set; }


    }
}
