using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miserene.Controllers
{
    public class MessagesController : Controller
    {
        public ActionResult Messages()
        {
            return View();
        }
        public ActionResult LiveChat()
        {
            return View();
        }
    }
}