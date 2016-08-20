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
            

            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }

        public ActionResult ProductCatalog()
        {
            

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