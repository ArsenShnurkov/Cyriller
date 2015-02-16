using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using Cyriller.Model;

namespace Cyriller.Web.Controllers
{
    public class HomeController : BaseController
    {
        [GzipFilter]
        public ActionResult Index()
        {
            ViewBag.Page = "Home.Index";

            return View();
        }

        public ActionResult Decline()
        {
            return new RedirectResult("~/Decline/Phrase", true);
        }

        [GzipFilter]
        public ActionResult Download()
        {
            ViewBag.Page = "Home.Download";

            return View();
        }

        [GzipFilter]
        public ActionResult DownloadFile(string ID)
        {
            ViewBag.Page = "Home.Download";

            string path = Path.Combine(HttpRuntime.AppDomainAppPath, "Files", ID);
            FileInfo fi = new FileInfo(path);

            if (!fi.Exists)
            {
                return this.NotFound();
            }

            ViewBag.ID = ID;
            ViewBag.Url = UrlHelper.GenerateContentUrl("~/Files/" + ID, Request.RequestContext.HttpContext);

            return View();
        }

        [GzipFilter]
        public ActionResult Contacts()
        {
            ViewBag.Page = "Home.Contacts";

            return View();
        }

        [GzipFilter]
        public ActionResult Thanks()
        {
            ViewBag.Page = "Home.Thanks";

            return View();
        }

        [GzipFilter]
        public ActionResult News()
        {
            ViewBag.Page = "Home.News";

            return View();
        }
    }
}