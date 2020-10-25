using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public string Index()
        {
            return "Hello World";
        }

        //
        // GET: /HelloWorld/Welcome
        public ActionResult Welcome()
        {
            int hour = DateTime.Now.Hour;

            string message;
            if (hour >= 7 && hour < 12)
            {
                message = "Good morning";
            } 
            else if (hour >= 12 && hour < 20)
            {
                message = "Good afternoon";
            } 
            else
            {
                message = "Good evening";
            }

            ViewBag.Message = message;
            return View();
        }
    }
}
