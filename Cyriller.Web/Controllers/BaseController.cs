using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cyriller.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;

            return View("~/Views/Error/p404.cshtml");
        }
    }
}