using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MobileAplication.Model;
using MobileAplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileAplication.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Mobile> Mobiles { get; private set; }

        public JsonMobileService MobileService;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonMobileService mobileService)
        {
            _logger = logger;
            MobileService = mobileService;

        }

        public void OnGet()
        {
           
        }
    }
}
