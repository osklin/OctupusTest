using System;
using System.Web.Configuration;
using System.Web.Mvc;

namespace OctupusTest.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.Message = ReadConfiguredMessage();
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private static String ReadConfiguredMessage() {
            var message = WebConfigurationManager.AppSettings["message"];
            return String.IsNullOrWhiteSpace(message)
                ? "No message."
                : message;
        }

    }

}