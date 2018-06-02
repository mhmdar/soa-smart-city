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
    public class ParkingStructureController : ApiController
    {
         private ParkingStructureService _parkingserv;
         public ParkingStructureController()
        {
            _parkingserv = new ParkingStructureService();
        }
         [HttpGet]
         [ActionName("GetParkingStructuresByStreet")]

        public HttpResponseMessage GetParkingStructuresByStreet(string streetId)
        {
            var ParkingStructures = _parkingserv.GetParkingStructures(streetId);
            var jsonObj = new JavaScriptSerializer().Serialize(ParkingStructures);
            return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK, Content = new StringContent(jsonObj) };
        }

    }
}
