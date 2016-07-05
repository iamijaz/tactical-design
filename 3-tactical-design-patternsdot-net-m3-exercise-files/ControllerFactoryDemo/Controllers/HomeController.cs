using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllerFactoryDemo.Models;

namespace ControllerFactoryDemo.Controllers
{
    public class HomeController : Controller
    {

        private AppSignature Signature { get; }

        public HomeController(AppSignature signature)
        {
            if (signature == null)
                throw new ArgumentNullException(nameof(signature));
            this.Signature = signature;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = $"Welcome to {this.Signature.ApplicationName} application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}