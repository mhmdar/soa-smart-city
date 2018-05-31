using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Models
{
    public class DriverRequirements
    {
        public string Type { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Level { get; set; }
        public double MaxCost { get; set; }
        public int  DurationInMinutes { get; set; }
        public string TargetLocation { get; set; }
    }
}