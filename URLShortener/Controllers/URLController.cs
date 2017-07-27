using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using URLShortener.Models;

namespace URLShortener.Controllers
{
    public class URLController : Controller
    {
        // GET: URL
        [HttpGet]
        public ActionResult Index()
        {
            Url url = new Url();
            return View(url);
        }

        public ActionResult Index(Url url)
        {
            if (ModelState.IsValid)
            {
                url.ShortURL = "http://www.google.com";
            }
            return View(url);
        }
    }
}