using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        // GET: Products/Details?type=[value}
        public ActionResult Details(String type)
        {
            // check for an empty type
            if (type== null)
            {
                //return View("error");
                return RedirectToAction("Index");
            }
            ViewBag.Type = type;
            return View();
        }
    }
}