using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Models
{
    public class DriverPreference
    {
        public string Language { get; set; }
        public string Currency { get; set; }
        public string Name { get; set; }
        public String CarId { get; set; }

        public string CurrentLocation { get; set; }
        public string ParkingType { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Level { get; set; }
        public string maxCost { get; set; }
        public string Duration { get; set; }


    }
}