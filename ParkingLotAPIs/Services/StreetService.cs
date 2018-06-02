using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAPIs.Services
{
    public class StreetService
    {
  
        public List<Street> GetStreetsByCity(string CityId)
        {
            var streets = new List<Street>();
            streets.Add (new Street() { CurrentCars = 100, EndLocation = "12.23:42.12", FlowRate = 50, Id = "123131", Length = 100, MaxCars = 150, NumberofLanes = 2, StartLocation = "12.23:42.13" });
            return streets;
        }

        public Street GetStreetByLocation(string Location)
        {
            return new Street() { CurrentCars = 100, EndLocation = "12.23:42.12", FlowRate = 50, Id = "123131", Length = 100, MaxCars = 150, NumberofLanes = 2, StartLocation = "12.23:42.13" };
        }

        public int GetStreetStatus(string streetId)
        {
            var street = this.GetStreetById(streetId);
            //return percentage of empty slots
            return 100-street.CurrentCars/street.MaxCars*100;
        }

        private Street GetStreetById(string streetId)
        {
          return new Street() { CurrentCars = 100, EndLocation = "12.23:42.12", FlowRate = 50, Id = "123131", Length = 100, MaxCars = 150, NumberofLanes = 2, StartLocation = "12.23:42.13" };

        }
    }
}