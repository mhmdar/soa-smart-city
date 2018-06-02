using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAPIs.Services
{
    public class DriverService
    {
        public DriverPreference GetDriverReference( string driverId)
        {
            var rand = new Random();
            return new DriverPreference() { CarId = "12313", Currency = "NIS", Language = "En", Name = "Hamoudeh", CurrentLocation = "32.12312:33.123131", Date=DateTime.Now.Date.ToShortDateString(), Time = DateTime.Now.TimeOfDay.ToString(), Duration= rand.Next(180).ToString(), Level = rand.Next(10).ToString(), maxCost= rand.Next(30).ToString(), ParkingType="N" };
        }

        public bool Login(string username, string password)
        {
            return true;
        }
    }
}