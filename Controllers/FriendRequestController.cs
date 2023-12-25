using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miserene.Controllers
{
    public class FriendRequestController : Controller
    {
        public ActionResult SendRequest()
        {
            return View();
        }
        public ActionResult AcceptRequest()
        {
            return View();
        }
        public ActionResult RejectRequest()
        {
            return View();
        }
    }
}