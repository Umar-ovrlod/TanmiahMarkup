using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahMarkup.Services;

namespace TanmiahMarkup.Controllers
{
    public class CardController : Controller
    {
        // GET: Section
        public ActionResult CardAction()
        {
            CardServices cardControl = new CardServices();
            var card = cardControl.cardDescription();
            return PartialView("_CardView",card);
        }
    }
}