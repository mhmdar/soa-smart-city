using ParkingLotAPIs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ParkingLotAPIs.Controllers
{
    public class StreetController : ApiController
    {
        private StreetService _streetService;
        public StreetController()
        {
            _streetService = new StreetService();
        }
        [HttpGet]
        [ActionName("GetStreetsByCity")]
        public HttpResponseMessage GetStreetsByCity(string cityId)
        {
            var streets = _streetService.GetStreetsByCity(cityId);
            var jsonObj = new JavaScriptSerializer().Serialize(streets);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
        [HttpGet]
        [ActionName("GetStreetByLocation")]

        public HttpResponseMessage GetStreetByLocation(string Location)
        {
            var street = _streetService.GetStreetsByCity(Location);
            var jsonObj = new JavaScriptSerializer().Serialize(street);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
        [HttpGet]
        [ActionName("GetStreetStatus")]

        public HttpResponseMessage GetStreetStatus(string streetId)
        {
            var status = _streetService.GetStreetStatus(streetId);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("{ \"Status\":\"" + status + "\"") };
        }
    }
}
