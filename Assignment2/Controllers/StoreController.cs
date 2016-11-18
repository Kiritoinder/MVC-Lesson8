using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "This is my Store Index Page";
            return View();
        }

        public ActionResult Browse(String genre)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Detsils, id= " + id);
            return View();
        }
    }
}