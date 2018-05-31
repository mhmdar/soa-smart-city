using ParkingLotAPIs.Services;
using ParkingLotAtomic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ParkingLotAPIs.Controllers
{
    public class CityController : ApiController
    {
        private CityService _cityserv;

        public CityController()
        {
            _cityserv = new CityService();
        }
    [HttpGet]
    [ActionName("GetCityInformation")]
        public HttpResponseMessage  GetCityInformation(string cityId)
        {
            var city = _cityserv.GetCity(cityId);
            var jsonObj = new JavaScriptSerializer().Serialize(city);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
    }
}
