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
        [OutputCache(Duration = 5)]
        public ActionResult Index()
        {
            Session["Index"] = "Index View";
            TempData["Index"] = "Index View";
            return View();
        }


        //[Route("")]
        public ActionResult About(string id)
        {
            ViewBag.Message = Session["Index"];
            ViewBag.Message = TempData["Index"];
            
            return View();
        }

        [Route("ContactLess")]
        [Route("ContactLess2")]
        [Route("home/ContactLess")]
        public ActionResult Contact()
        {
            ViewBag.Message = Session["Index"];
            ViewBag.Message = TempData["Index"];

            return View();
        }

        [HttpPost]
        public ActionResult Calc(CurrencyViewModel data)
        {
            var random = new Random().Next(2, 4);
            return Json(random, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        [OutputCache(Duration =10,  VaryByParam = "country")]
        public ActionResult LoadCountryCities(string country)
        {
            var random = new Random().Next(2, 4);
            return Json(random, JsonRequestBehavior.AllowGet);
        }
    }
}