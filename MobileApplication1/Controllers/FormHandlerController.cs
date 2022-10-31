using Microsoft.AspNetCore.Mvc;
using MobileAplication.Model;
using MobileAplication.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace MobileAplication.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsonMobileService MobileService;
        public FormHandlerController(JsonMobileService mobileService)
        {
            this.MobileService = mobileService;
        }
        [HttpGet]
        public string Get(int id, string name, string image, int price)
        {
            Mobile obj = new Mobile();
            obj.mobile_id = id;
            obj.mobile_model = name;
            obj.mobile_img = image;

            IEnumerable<Mobile> MobileData = MobileService.getMobileRecord();
            List<Mobile> MobileList = MobileData.ToList();
            MobileList.Add(obj);

            return JsonSerializer.Serialize<List<Mobile>>(MobileList);

        }
        
    }
}

