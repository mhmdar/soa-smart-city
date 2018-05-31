using ParkingLotAtomic.Models;
using ParkingLotAtomic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using ParkingLotAPIs.Controllers;

namespace ParkingLotAtomic.Controllers
{
    public class SlotController : ApiController
    {
        private SlotService _slotservice;
        public SlotController()
        {
            _slotservice = new SlotService();
            
        }
        [HttpGet]
        [ActionName("getSlotsInRange")]
        public HttpResponseMessage getSlotsInRange(string currentLocation, int radius)
        {
            List<int> cost = _slotservice.GetAllSlotsinRange(currentLocation, radius);
            var jsonObj = new JavaScriptSerializer().Serialize(cost);

            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
        [HttpPost]
        [ActionName("GetSlotCost")]
        public HttpResponseMessage GetSlotCost(List<int> slotIds)
        {
            var cost = _slotservice.GetSlotCost(slotIds);
            var jsonObj = new JavaScriptSerializer().Serialize(cost);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
          [HttpPost]
          [ActionName("GetSlotsById")]
        public HttpResponseMessage GetSlotsById(List<int> SlotIds)
        {
            List<Slot> slots = _slotservice.GetSlotsById(SlotIds);
            var jsonObj = new JavaScriptSerializer().Serialize(slots);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }

          [HttpPost]
          [ActionName("chooseBestSlotsFromGA")]
          public HttpResponseMessage ChooseBestSlotsFromGA(GARequest req)
          {
              List<int> slots = _slotservice.ChooseBestSlotsFromGA(req.SlotIds,req.slotprices,req.driverPreference);
              var jsonObj = new JavaScriptSerializer().Serialize(slots);

              return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
          }
         
         
        [HttpGet]
        [ActionName("GetSlotDistance")]
        public HttpResponseMessage GetSlotDistance(string SlotId, string CurrentLocation)
        {
            var distance = _slotservice.GetDistanceFromSlot(SlotId, CurrentLocation);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("{ \"Distance\":\"" + distance + "\"") };
        }
        [HttpGet]
        [ActionName("GetSlotsByParkingStructure")]

        public HttpResponseMessage GetSlotsByParkingStructure(string structureId)
        {
            var slots = _slotservice.GetSlotsByParkingStructure(structureId);
            var jsonObj = new JavaScriptSerializer().Serialize(slots);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }

        [HttpPost]
        [ActionName("GetAvailableSlots")]

        public HttpResponseMessage GetAvailableSlots(List<int> SlotIds)
        {
            var slots = _slotservice.GetAvailableSlots(SlotIds);
            var jsonObj = new JavaScriptSerializer().Serialize(slots);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
        [HttpPost]
        [ActionName("ReserveSlot")]

        public HttpResponseMessage ReserveSlot(string slotid, string driverId)
        {
             _slotservice.ReserveSlot(slotid, driverId);
             return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("Reserved Successfully") };
        }

    }
}
