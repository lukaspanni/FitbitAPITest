using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    public class FitbitUser
    {
        private int age;
        private bool ambassador;
        private bool autoStrideEnabled;
        private string avatar;
        private string avatar150;
        private string avatar640; 
        private int averageDailySteps;
        private string clockTimeDisplayFormat;
        private bool corporate;
        private bool corporateAdmin;
        private DateTime dateOfBirth;
        private string displayName;
        private string displayNameSetting;
        private string distanceUnit;
        private string encodedId;
        private bool familyGuidanceEnabled;
        private object features;
        private string firstName;
        private string foodsLocale;
        private string fullName;
        private string gender;
        private string glucoseUnit;
        private double height;
        private string heightUnit;
        private bool isChild;
        private string lastName;
        private string locale;
        private DateTime emberSince;
        private bool mfaEnabled;
        private long offsetFromUTCMillis;
        private string startDayOfWeek;
        private double strideLengthRunning;
        private string strideLengthRunningType;
        private double strideLengthWalking;
        private string strideLengthWalkingType;
        private string swimUnit;
        private string timezone;
        private object topBadges;
        private string waterUnit;
        private string waterUnitName;
        private double weight;
        private string weightUnit;

        public int Age { get => age; set => age = value; }
        public bool Ambassador { get => ambassador; set => ambassador = value; }
        public bool AutoStrideEnabled { get => autoStrideEnabled; set => autoStrideEnabled = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Avatar150 { get => avatar150; set => avatar150 = value; }
        public string Avatar640 { get => avatar640; set => avatar640 = value; }
        public int AverageDailySteps { get => averageDailySteps; set => averageDailySteps = value; }
        public string ClockTimeDisplayFormat { get => clockTimeDisplayFormat; set => clockTimeDisplayFormat = value; }
        public bool Corporate { get => corporate; set => corporate = value; }
        public bool CorporateAdmin { get => corporateAdmin; set => corporateAdmin = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string DisplayNameSetting { get => displayNameSetting; set => displayNameSetting = value; }
        public string DistanceUnit { get => distanceUnit; set => distanceUnit = value; }
        public string EncodedId { get => encodedId; set => encodedId = value; }
        public bool FamilyGuidanceEnabled { get => familyGuidanceEnabled; set => familyGuidanceEnabled = value; }
        public object Features { get => features; set => features = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string FoodsLocale { get => foodsLocale; set => foodsLocale = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string GlucoseUnit { get => glucoseUnit; set => glucoseUnit = value; }
        public double Height { get => height; set => height = value; }
        public string HeightUnit { get => heightUnit; set => heightUnit = value; }
        public bool IsChild { get => isChild; set => isChild = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Locale { get => locale; set => locale = value; }
        public DateTime EmberSince { get => emberSince; set => emberSince = value; }
        public bool MfaEnabled { get => mfaEnabled; set => mfaEnabled = value; }
        public long OffsetFromUTCMillis { get => offsetFromUTCMillis; set => offsetFromUTCMillis = value; }
        public string StartDayOfWeek { get => startDayOfWeek; set => startDayOfWeek = value; }
        public double StrideLengthRunning { get => strideLengthRunning; set => strideLengthRunning = value; }
        public string StrideLengthRunningType { get => strideLengthRunningType; set => strideLengthRunningType = value; }
        public double StrideLengthWalking { get => strideLengthWalking; set => strideLengthWalking = value; }
        public string StrideLengthWalkingType { get => strideLengthWalkingType; set => strideLengthWalkingType = value; }
        public string SwimUnit { get => swimUnit; set => swimUnit = value; }
        public string Timezone { get => timezone; set => timezone = value; }
        public object TopBadges { get => topBadges; set => topBadges = value; }
        public string WaterUnit { get => waterUnit; set => waterUnit = value; }
        public string WaterUnitName { get => waterUnitName; set => waterUnitName = value; }
        public double Weight { get => weight; set => weight = value; }
        public string WeightUnit { get => weightUnit; set => weightUnit = value; }
    }
}
