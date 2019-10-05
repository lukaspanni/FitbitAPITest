using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    public class FitbitUser
    {
        public int age { get; set; }
        public bool ambassador { get; set; }
        public bool autoStrideEnabled { get; set; }
        public string avatar { get; set; }
        public string avatar150 { get; set; }
        public string avatar640 { get; set; }
        public int averageDailySteps { get; set; }
        public string clockTimeDisplayFormat { get; set; }
        public bool corporate { get; set; }
        public bool corporateAdmin { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string displayName { get; set; }
        public string displayNameSetting { get; set; }
        public string distanceUnit { get; set; }
        public string encodedId { get; set; }
        public bool familyGuidanceEnabled { get; set; }
        public object features { get; set; }
        public string firstName { get; set; }
        public string foodsLocale { get; set; }
        public string fullName { get; set; }
        public string fender { get; set; }
        public string glucoseUnit { get; set; }
        public double height { get; set; }
        public string heightUnit { get; set; }
        public bool isChild { get; set; }
        public string lastName { get; set; }
        public string locale { get; set; }
        public DateTime memberSince { get; set; }
        public bool mfaEnabled { get; set; }
        public long offsetFromUTCMillis { get; set; }
        public string startDayOfWeek { get; set; }
        public double strideLengthRunning { get; set; }
        public string strideLengthRunningType { get; set; }
        public double strideLengthWalking { get; set; }
        public string strideLengthWalkingType { get; set; }
        public string swimUnit { get; set; }
        public string timezone { get; set; }
        public object topBadges { get; set; }
        public string waterUnit { get; set; }
        public string waterUnitName { get; set; }
        public double weight { get; set; }
        public string weightUnit { get; set; }
    }
}
