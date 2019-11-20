using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    class FitbitActivityData
    {
        public Activity[] activities { get; set; }
        public ActivityGoals goals{ get; set; }
        public ActivitySummary summary { get; set; }

        public class ActivityGoals
        {
            public int activeMinutes { get; set; }
            public int caloriesOut { get; set; }
            public double distance { get; set; }
            public int floors { get; set; }
            public int steps { get; set; }
        }

        public class ActivitySummary
        {
            public int activeScore { get; set; }
            public int activityCalories { get; set; }
            public int calorieEstimationMu { get; set; }
            public int caloriesBMR { get; set; }
            public int caloriesOut { get; set; }
            public int caloriesOutUnestimated { get; set; }
            public Distance[] distances { get; set; }
            public double elevation { get; set; }
            public int fairlyActiveMinutes { get; set; }
            public int floors { get; set; }
            public int lightlyActiveMinutes { get; set; }
            public int marginalCalories { get; set; }
            public int sedentaryMinutes { get; set; }
            public int steps { get; set; }
            public bool useEstimation { get; set; }
            public int veryActiveMinutes { get; set; }

            public class Distance
            {
                public string activity { get; set; }
                public double distance { get; set; }
            }
        }
    }
}
