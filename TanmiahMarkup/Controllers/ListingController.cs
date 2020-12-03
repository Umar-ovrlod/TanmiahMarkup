using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahMarkup.Services;

namespace TanmiahMarkup.Controllers
{
    public class ListingController : Controller
    {
        // GET: Listing
        public ActionResult ListAction()
        {
            ListingValues listing = new ListingValues();
            var listItems = listing.GetData();
            return PartialView("_listingView",listItems);
        }
    }
}