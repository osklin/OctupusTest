using System;
using System.Web.Configuration;
using System.Web.Mvc;

namespace OctupusTest.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.Message = ReadConfiguredString("message");
            ViewBag.Version = ReadConfiguredString("version");
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

        private static String ReadConfiguredString(String key) {
            var configuredString = WebConfigurationManager.AppSettings[key];
            return String.IsNullOrWhiteSpace(configuredString)
                ? "N/A"
                : configuredString;
        }

    }

}