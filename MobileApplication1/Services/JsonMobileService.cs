using Microsoft.AspNetCore.Hosting;
using MobileAplication.Model;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace MobileAplication.Services
{
    public class JsonMobileService
    {
        //private object fileStream;
        //variable for home/root address
        //generate file address
        //file handling

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        public JsonMobileService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment= webHostEnvironment;
        }

        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "mobiles.json");
            }
        }
        public IEnumerable<Mobile> getMobileRecord()
        {
            using (var fileStream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<Mobile[]>(fileStream.ReadToEnd());
            }
        }
    }
}
