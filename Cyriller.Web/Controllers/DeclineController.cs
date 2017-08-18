using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cyriller.Model;

namespace Cyriller.Web.Controllers
{
    public class DeclineController : BaseController
    {
        [GzipFilter]
        public ActionResult Noun(string w)
        {
            ViewBag.Page = "Decline.Noun";

            if (string.IsNullOrEmpty(w))
            {
                return View();
            }

            List<string> errors = new List<string>();
            List<CyrNoun> words = new List<CyrNoun>();
            List<CyrResult> singulars = new List<CyrResult>();
            List<CyrResult> plurals = new List<CyrResult>();
            CyrNounCollection collection = this.NounCollection;

            foreach (string s in w.Split(' ').Where(val => !string.IsNullOrEmpty(val)))
            {
                CyrNoun word;

                try
                {
                    word = collection.Get(s, GetConditionsEnum.Similar);
                }
                catch (CyrWordNotFoundException)
                {
                    errors.Add(string.Format("Слово \"<strong>{0}</strong>\" не найдено в коллекции. Попбробуйте другое слово.", s));
                    continue;
                }

                words.Add(word);
                singulars.Add(word.Decline());
                plurals.Add(word.DeclinePlural());
            }

            ViewBag.Text = w;
            ViewBag.Errors = errors;
            ViewBag.Words = words;
            ViewBag.Singulars = singulars;
            ViewBag.Plurals = plurals;
            ViewBag.Cases = CyrDeclineCase.List;

            return View();
        }

        [GzipFilter]
        public ActionResult Adjective(string w)
        {
            ViewBag.Page = "Decline.Adjective";

            if (string.IsNullOrEmpty(w))
            {
                return View();
            }

            List<string> errors = new List<string>();
            List<CyrAdjective> words = new List<CyrAdjective>();
            List<CyrResult> singulars = new List<CyrResult>();
            List<CyrResult> plurals = new List<CyrResult>();
            CyrAdjectiveCollection collection = this.AdjectiveCollection;

            foreach (string s in w.Split(' ').Where(val => !string.IsNullOrEmpty(val)))
            {
                CyrAdjective word;

                try
                {
                    word = collection.Get(s, GetConditionsEnum.Similar);
                }
                catch (CyrWordNotFoundException)
                {
                    errors.Add(string.Format("Слово \"<strong>{0}</strong>\" не найдено в коллекции. Попбробуйте другое слово.", s));
                    continue;
                }

                words.Add(word);
                singulars.Add(word.Decline(AnimatesEnum.Animated));
                plurals.Add(word.DeclinePlural(AnimatesEnum.Animated));
            }

            ViewBag.Text = w;
            ViewBag.Errors = errors;
            ViewBag.Words = words;
            ViewBag.Singulars = singulars;
            ViewBag.Plurals = plurals;
            ViewBag.Cases = CyrDeclineCase.List;

            return View();
        }

        [GzipFilter]
        public ActionResult Phrase(string w)
        {
            ViewBag.Page = "Decline.Phrase";

            if (string.IsNullOrEmpty(w))
            {
                return View();
            }

            List<string> errors = new List<string>();
            CyrPhrase phrase = new CyrPhrase(this.NounCollection, this.AdjectiveCollection);
            CyrResult singular = null;
            CyrResult plural = null;

            try
            {
                singular = phrase.Decline(w, GetConditionsEnum.Similar);
                plural = phrase.DeclinePlural(w, GetConditionsEnum.Similar);
            }
            catch (CyrWordNotFoundException ex)
            {
                errors.Add(string.Format("Слово \"<strong>{0}</strong>\" не найдено в коллекции. Попбробуйте убрать слово из фразы.", ex.Word));
                return View();
            }
            
            ViewBag.Text = w;
            ViewBag.Errors = errors;
            ViewBag.Singular = singular;
            ViewBag.Plural = plural;
            ViewBag.Cases = CyrDeclineCase.List;

            return View();
        }

        [GzipFilter]
        public ActionResult Number(string w, string a, string i)
        {
            ViewBag.Page = "Decline.Number";

            if (w.IsNullOrEmpty() || a.IsNullOrEmpty())
            {
                ViewBag.Action = "Item";
                return View();
            }

            List<string> errors = new List<string>();
            CyrResult result = null;
            decimal v;

            if (decimal.TryParse(w, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out v))
            {
                CyrNumber cyr = new CyrNumber();
                CyrNumber.Item item;

                switch (a)
                {
                    case "Item":
                        CyrNoun noun;

                        try
                        {
                            noun = this.NounCollection.Get(i, GetConditionsEnum.Similar);
                        }
                        catch (CyrWordNotFoundException ex)
                        {
                            errors.Add(string.Format("Слово \"<strong>{0}</strong>\" не найдено в коллекции. Попбробуйте другое слово.", ex.Word));
                            break;
                        }

                        item = new CyrNumber.Item(noun);
                        result = cyr.Decline(v, item);

                        if ((long)v == v)
                        {
                            string[] strings = item.GetName(CasesEnum.Nominative, (long)v);
                            ViewBag.ItemText = cyr.Case((long)v, strings[0], strings[1], strings[2]);
                        }
                        else
                        {
                            string[] strings = item.GetName(CasesEnum.Nominative, 2);
                            ViewBag.ItemText = strings[1];
                        }

                        break;
                    case "Masculine":
                        result = cyr.Decline(v, Model.GendersEnum.Masculine, Model.AnimatesEnum.Inanimated);
                        break;
                    case "Feminine":
                        result = cyr.Decline(v, Model.GendersEnum.Feminine, Model.AnimatesEnum.Inanimated);
                        break;
                    case "Rub":
                        result = cyr.Decline(v, new CyrNumber.RurCurrency());
                        ViewBag.CurrencyClass = "fa-ruble";
                        ViewBag.CurrencyText = "руб.";
                        break;
                    case "Usd":
                        result = cyr.Decline(v, new CyrNumber.UsdCurrency());
                        ViewBag.CurrencyClass = "fa-usd";
                        ViewBag.CurrencyText = "$";
                        break;
                    case "Eur":
                        result = cyr.Decline(v, new CyrNumber.EurCurrency());
                        ViewBag.CurrencyClass = "fa-eur";
                        ViewBag.CurrencyText = "€";
                        break;
                    case "Yuan":
                        result = cyr.Decline(v, new CyrNumber.YuanCurrency());
                        ViewBag.CurrencyClass = "fa-yen";
                        ViewBag.CurrencyText = "¥";
                        break;
                    default:
                        errors.Add(string.Format("{0} не является правильной операцией!", a));
                        break;
                }
            }
            else
            {
                errors.Add(string.Format("{0} не является правильным числом!", w));
            }
            
            ViewBag.Item = i;
            ViewBag.Text = w;
            ViewBag.Action = a;
            ViewBag.Result = result;
            ViewBag.Errors = errors;
            ViewBag.Cases = CyrDeclineCase.List;

            return View();
        }

        protected CyrNounCollection NounCollection
        {
            get
            {
                CyrNounCollection collection = System.Runtime.Caching.MemoryCache.Default.Get("CyrNounCollection") as CyrNounCollection;

                if (collection != null)
                {
                    return collection;
                }

                collection = new CyrNounCollection();

                System.Runtime.Caching.MemoryCache.Default.Set("CyrNounCollection", collection, DateTime.Now.AddMonths(1));

                return collection;
            }
        }

        protected CyrAdjectiveCollection AdjectiveCollection
        {
            get
            {
                CyrAdjectiveCollection collection = System.Runtime.Caching.MemoryCache.Default.Get("CyrAdjectiveCollection") as CyrAdjectiveCollection;

                if (collection != null)
                {
                    return collection;
                }

                collection = new CyrAdjectiveCollection();

                System.Runtime.Caching.MemoryCache.Default.Set("CyrAdjectiveCollection", collection, DateTime.Now.AddMonths(1));

                return collection;
            }
        }
    }
}