using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamprojectPart3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult ProductCatalog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult checkout()
        {
            ViewBag.Message = "Checkout";

            return View();
        }

        public ActionResult homepage()
        {
            ViewBag.Message = "Welcome";

            return View();
        }

        public ActionResult ShoppingCart()
        {
            

            return View();
        }


        public ActionResult final()
        {


            return View();
        }
    }
}