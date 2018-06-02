using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public DateTime  Dob { get; set; }

        public String Address { get; set; }
        public DriverPreference Preference { get; set; }
    }
}