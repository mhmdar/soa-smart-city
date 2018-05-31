using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Models
{
    public class City
    {
        public string Id { get; set; }
        public List<Street> Streets { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Slot> Slots { get; set; }



    }
}