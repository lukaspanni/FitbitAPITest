using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    class GetHeartRateDataHandler : GetDataHandler
    {
        //workaround! Select correct Type
        public async Task<HeartRateData> GetHeartRateDataAsync(DateTime startDate, DateTime endDate, bool withTime = true, Action<HeartRateData> action = null)
        {
            if (withTime)
            {
                return await base.GetData<HeartRateIntradayTimeSeriesTime>(APIEndpoints.HeartRatePath(startDate, endDate, withTime), action);
            }
            else
            {
                return await base.GetData<HeartRateIntradayTimeSeries>(APIEndpoints.HeartRatePath(startDate, endDate, withTime), action);
            }
        }
    }
}
