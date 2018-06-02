using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Models
{
    public class Slot
    {
        public string Id { get; set; }
        public string streetId { get; set; }

        public string NumberofLanes { get; set; }

        public string Location { get; set; }

        public string Level { get; set; }

        public string DeviceId { get; set; }
        public double Cost { get; set; }


    }
}