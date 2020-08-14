using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class FormHandlerController : Controller
    {
        // GET: FormHandler
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string firstName)
        {
            string location = Request["location"];
            string city = Request.QueryString["city"];
            return Content("Hello " + firstName + "! Your location: " + location + ", You are living in: " + city);
        }

    }
}