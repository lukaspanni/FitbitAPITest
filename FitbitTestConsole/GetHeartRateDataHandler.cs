using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    class GetHeartRateDataHandler : GetDataHandler
    {
        public GetHeartRateDataHandler() : base()
        {
            
        }

        //workaround! Select correct Type
        public async Task<HeartRateData> GetHeartRateData(DateTime startDate, DateTime endDate, bool withTime = false, Action<HeartRateData> action = null)
        {
            //dates have to be same day for Time!
            if (withTime && endDate.Date == startDate.Date)
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
