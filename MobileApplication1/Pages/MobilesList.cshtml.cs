using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MobileAplication.Model;
using MobileAplication.Services;
using System.Collections.Generic;

namespace MobileAplication.Pages
{
    public class MobilesListModel : PageModel
    {
        public IEnumerable<Mobile> Mobiles;
        JsonMobileService MobileService;

        public MobilesListModel(JsonMobileService mobileService)
        {
            this.MobileService = mobileService;
        }
        public void OnGet()
        {
            Mobiles = MobileService.getMobileRecord();
        }
    }
}
