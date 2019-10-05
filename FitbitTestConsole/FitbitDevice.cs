using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    public class FitbitDevice
    {
        public string battery { get; set; }
        public int batteryLevel { get; set; }
        public string deviceVerstion { get; set; }
        public object[] features { get; set; }
        public string id { get; set; }
        public DateTime lastSyncTime { get; set; }
        public string mac { get; set; }
        public string type { get; set; }
    }
}
