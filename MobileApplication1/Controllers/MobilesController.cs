using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileAplication.Model;
using MobileAplication.Services;
using System.Collections.Generic;

namespace MobileAplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MobilesController : ControllerBase
    {
        JsonMobileService Mobileservice { get; }
        public MobilesController(JsonMobileService mobileservice)
        {
            this.Mobileservice = mobileservice;
        }
        [HttpGet]
        public IEnumerable<Mobile> Get()
        {
            return Mobileservice.getMobileRecord();

        }
    }
}
