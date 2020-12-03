using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahMarkup.Services;

namespace TanmiahMarkup.Controllers
{
    public class NuggetController : Controller
    {
        // GET: Nugget
        public ActionResult NuggetAction()
        {
            NuggetServices Card = new NuggetServices();
            var nuggetBox = Card.NuggetCard();
            return PartialView("_NuggetView",nuggetBox);
        }
    }
}