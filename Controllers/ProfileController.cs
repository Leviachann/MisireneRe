using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miserene.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }
        public ActionResult Friends()
        {
            return View();
        }
        public ActionResult Notifications()
        {
            return View();
        }
    }
}