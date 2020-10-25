using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //
        // /Home/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(GuestResponse answer)
        {
            if (ModelState.IsValid) {
                Repository.AddResponse(answer);
                return View("ThankYou", answer);
            } else
            {
                return View();
            }
        }

        public IActionResult GuestList()
        {
            var guestList = Repository.Responses;

            if (guestList.Count() == 0)
            {
                return View("RegisterFirst");
            } else {
                return View(guestList);
            }
        }

        public IActionResult PeopleCommingToParty()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
