using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLotAPIs.Controllers
{
  public  class GARequest
    {
        public List<int> SlotIds{ get; set; }
        public List<int> slotprices { get; set; }
        public DriverPreference driverPreference { get; set; }
    }
}
