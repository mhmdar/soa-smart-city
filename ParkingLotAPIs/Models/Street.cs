using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Models
{
    public class Street
    {
        public string Id { get; set; }
        public int NumberofLanes { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int Length { get; set; }
        public int FlowRate { get; set; }
        public int CurrentCars { get; set; }
        public int MaxCars { get; set; }

    }
}