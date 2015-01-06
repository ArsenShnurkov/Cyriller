using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cyriller.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult p404()
        {
            return View();
        }

        public ActionResult p403()
        {
            return View();
        }

        public ActionResult p500()
        {
            return View();
        }
    }
}