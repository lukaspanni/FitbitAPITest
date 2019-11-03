using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    class APIEndpoints
    {
        private static readonly string apiUrl = "https://api.fitbit.com";
        private static readonly string userDataPath = "/1/user/-/profile.json";
        private static readonly string devicesPath = "/1/user/-/devices.json";
        private static readonly string sleepDataPath = "/1.2/user/-/sleep/date/";
        private static readonly string heartRatePath = "/1/user/-/activities/heart/date/";

        public static string UserDataPath() { return apiUrl + userDataPath; }

        public static string DevicesPath() { return apiUrl + devicesPath; }

        public static string SleepDataPath(DateTime startDate, DateTime? endDate = null)
        {
            if (endDate == null || endDate < startDate)
            {
                return apiUrl + sleepDataPath + startDate.ToString("yyyy-MM-dd") + ".json";
            }
            else
            {
                return apiUrl + sleepDataPath + startDate.ToString("yyyy-MM-dd") + "/" + endDate?.ToString("yyyy-MM-dd") + ".json";
            }
        }

        public static string HeartRatePath(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                return apiUrl + heartRatePath + startDate.ToString("yyyy-MM-dd") + "/" + startDate.ToString("yyyy-MM-dd") + "/1min.json";
            }
            else
            {
                return apiUrl + sleepDataPath + startDate.ToString("yyyy-MM-dd") + "/" + endDate.ToString("yyyy-MM-dd") + "/1min.json";
            }
        }
    }
}
