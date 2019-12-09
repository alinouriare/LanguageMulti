using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LangMulti.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using Microsoft.Extensions.Localization;

namespace LangMulti.Controllers
{
    public class HomeController : Controller
    {

        private MyCMSContext _context;
        private IStringLocalizer<HomeController> _localizer;

        public HomeController(MyCMSContext context, IStringLocalizer<HomeController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        public IActionResult Index()
        {


            string lang = CultureInfo.CurrentCulture.Name;


            return View(_context.Newses.Where(p=>p.Language.LanguageTitle==lang));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public PartialViewResult Languages()
        {

            return PartialView(_context.Languages);
        }


        public IActionResult ChangeLanguage(string id)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(id)),
                
                new CookieOptions() {

                    Expires=DateTimeOffset.UtcNow.AddYears(1),
                });


            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
