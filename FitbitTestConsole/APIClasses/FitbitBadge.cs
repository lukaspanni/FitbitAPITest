
using System;
namespace FitbitAPITestConsole
{
    public class FitbitBadge
    {
        public string badgeGradientEndColor { get; set; } //Hex Color String -> Convert to Color?
        public string badgeGradientStartColor { get; set; }
        public string badgeType { get; set; } // -> Enum values?
        public string category { get; set; }
        public object cheers { get; set; }
        public DateTime dateTime { get; set; }
        public string description { get; set; }
        public string earnedMessage { get; set; }
        public string encodedId { get; set; }
        public string image100px { get; set; }
        public string image125px { get; set; }
        public string image300px { get; set; }
        public string image50px { get; set; }
        public string image75px { get; set; }
        public string marketingDescription { get; set; }
        public string mobileDescription { get; set; }
        public string name { get; set; }
        public string shareImage640px { get; set; }
        public string shareText { get; set; }
        public string shortDescription { get; set; }
        public string shortName { get; set; }
        public int timesAchieved { get; set; }
    }
}

