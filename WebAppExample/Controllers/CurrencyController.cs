using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppExample.Models;

namespace WebAppExample.Controllers
{
    public class CurrencyController : Controller
    {
        // GET: Currency
        public ActionResult Index()
        {
            var model = new List<Currency>
            {
                new Currency { Code = "GEL", Description = "ლარი" },
                new Currency { Code = "USD", Description = "დოლარი" }
            };
            return View("Index", model);
        }


        public ActionResult Calculate()
        {
            var model = new CurrencyViewModel
            {
                Curnecies = new  List<SelectListItem>()
            };
            model.Curnecies.Add(new SelectListItem { Text = "ლარი", Value ="GEL" });
            model.Curnecies.Add(new SelectListItem { Text = "დოლარი", Value = "USD" });

            //new List<Currency>
            //{
            //    new Currency { Code = "GEL", Description = "ლარი" },
            //    new Currency { Code = "USD", Description = "დოლარი" }
            //}
            return View("Calculate", model);
        }

        // GET: Currency/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Currency/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Currency/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
             

            return View(new Currency { Code = "GEL", Description = "ლარი" } );
        }

        // POST: Genres/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Currency currency)
        {
            if (ModelState.IsValid)
            {
                // Update 


                return RedirectToAction("Index");
            }
            return View(currency);
        }

        // GET: Currency/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Currency/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
