using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miserene.Controllers
{
    public class FeedController : Controller
    {
        public ActionResult Events()
        {
            return View();
        }
        public ActionResult Video()
        {
            return View();
        }
        public ActionResult Weather()
        {
            return View();
        }
    }
}