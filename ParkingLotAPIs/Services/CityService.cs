using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAPIs.Services
{
    public class CityService
    {
        public City GetCity(string cityId)
        {   
            var drivers = new List<Driver>();
            var slots = new List<Slot>();
            var streets = new List<Street>();
            drivers.Add(new Driver(){ Address="test", Dob= DateTime.Now, Name="hamoudeh", Preference= null});
            slots.Add(new Slot(){ Cost=10, DeviceId="!232131",Id="45124124", Level="2", Location="12.23:24.22", NumberofLanes="2", streetId="100" });
            streets.Add(new Street(){ CurrentCars=100, EndLocation="12.23:42.12", FlowRate=50, Id="123131", Length=100, MaxCars=150, NumberofLanes=2, StartLocation ="12.23:42.13"});
            return new City(){ Drivers = drivers, Slots= slots, Streets = streets};

        }
    }
}