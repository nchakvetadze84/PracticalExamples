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
            return View();
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

        [HttpPost]
        public ActionResult Calc(CurrencyViewModel data)
        {
            var random = new Random().Next(2, 4);
            return Json(random, JsonRequestBehavior.AllowGet);
        }
    }
}