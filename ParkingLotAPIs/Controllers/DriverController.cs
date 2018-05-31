using ParkingLotAPIs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace ParkingLotAtomic.Controllers
{
    public class DriverController : ApiController
    {
        private DriverService _driverserv;
        public DriverController()
        {
            _driverserv = new DriverService();
        }
        [HttpPost]
        [ActionName("Login")]
        public HttpResponseMessage  Login (string username, string password)
        {
            var resp = _driverserv.Login(username, password);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent("Login Successful") };
        }

        [HttpGet]
        [ActionName("GetDriverPreferences")]
        public HttpResponseMessage GetDriverPreferences(string driverId)
        {
            var preference = _driverserv.GetDriverReference(driverId);
            var jsonObj = new JavaScriptSerializer().Serialize(preference);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }
    }
}
