using RentExtreme2.Helpers;
using RentExtreme2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentExtreme2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var cx = ApplicationDbContext.Create())
            {
                var services = cx.Services
                    .ToList();

                return View(services);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Conditions()
        {
            return View();
        }
    }
}