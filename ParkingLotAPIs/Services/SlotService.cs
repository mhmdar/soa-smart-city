using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingLotAtomic.Services
{
    public class SlotService
    {
        List<Slot> slots = new List<Slot>();
        private List<int> _slotIds;

        public SlotService()
        {
            _slotIds = new List<int>();
            for (int i = 10; i < 500; i += 6)
            {
                var rand = new Random();
                _slotIds.Add(i);
                slots.Add(new Slot() { Cost = rand.Next(100), DeviceId = rand.Next(10000).ToString(), Id = rand.Next(100).ToString(), Level = rand.Next(10).ToString(), Location = "32.1231:32.123131", NumberofLanes = rand.Next(10).ToString(), streetId = rand.Next(100).ToString() });
            }
            //initialize dummy data
        }

        public List<int> GetSlotCost(List<int> slotIds)
        {
            try
            {
                var cost = new List<int>();
                var rand =new Random();
                foreach(int slot in slotIds)
                {
                    cost.Add(rand.Next(30));
                }
                return cost;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public double GetDistanceFromSlot(string slotId, string currentLocation)
        {
            return new Random().NextDouble();
        }

        public List<Slot> GetSlotsByParkingStructure(string structureId)
        {
            return slots;
        }

        public void ReserveSlot(string slotid, string driverId)
        {
            return;
        }
        public List<Slot> GetSlotsById(List<int> slotIds)
        {
            return slots.GetRange(0, slotIds.Count);
        }
        public List<int> GetAllSlotsinRange(string currentLocation, int radius)
        {
            var limit = 50;
            if(radius<=1)
                limit=10;
            if(radius<2)
                limit=20;
            if(radius<3)
                limit =30;
            return _slotIds.GetRange(0, limit > _slotIds.Count ? _slotIds.Count : limit);
        }

        public List<int> GetAvailableSlots(List<int> SlotIds)
        {
            var firstIndx = new Random().Next(SlotIds.Count);

            return _slotIds.GetRange(firstIndx, new Random().Next(firstIndx+1, SlotIds.Count));
        }

        public List<int> ChooseBestSlotsFromGA(List<int> SlotIds, List<int> slotprices, DriverPreference driverPreference)
        {
            var firstIndx = new Random().Next(SlotIds.Count);
            return _slotIds.GetRange(firstIndx, new Random().Next(firstIndx + 1, SlotIds.Count));
        }
    }
}