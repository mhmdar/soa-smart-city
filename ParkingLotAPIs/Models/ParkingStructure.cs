using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Models
{
    public class ParkingStructure
    {
        public string Id { get; set; }
        public List<Slot> Slots { get; set; }
        public string Location { get; set; }
    }
}