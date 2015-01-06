using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

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

        [GzipFilter]
        public ActionResult Decline(string w)
        {
            ViewBag.Page = "Home.Decline";

            if (string.IsNullOrEmpty(w))
            {
                return View();
            }

            List<string> errors = new List<string>();
            List<CyrWord> words = new List<CyrWord>();
            List<CyrResult> results = new List<CyrResult>();
            CyrCollection collection = new CyrCollection();

            foreach (string s in w.Split(' ').Where(val => !string.IsNullOrEmpty(val)))
            {
                CyrWord word;

                try
                {
                    word = collection.Get(s);
                }
                catch (CyrWordNotFoundException)
                {
                    errors.Add(string.Format("Слово \"<strong>{0}</strong>\" не найдено в коллекции. Попбробуйте другое слово.", s));
                    continue;
                }

                words.Add(word);
                results.Add(word.Decline());
            }

            ViewBag.Text = w;
            ViewBag.Errors = errors;
            ViewBag.Words = words;
            ViewBag.Results = results;

            return View();
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
    }
}