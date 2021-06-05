using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppExample.Models;

namespace WebAppExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<Currency>
            {
                new Currency { Code = "GEL", Description = "ლარი" },
                new Currency { Code = "USD", Description = "დოლარი" }
            };
            return View("Currencies", model);
        }

        public ActionResult About(string id)
        {
            ViewBag.Message = "Your application description page." + id;
            return PartialView();

            //return View();
            return View("NotIndex");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}