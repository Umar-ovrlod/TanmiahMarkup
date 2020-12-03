using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahMarkup.Models;
using TanmiahMarkup.Services;

namespace TanmiahMarkup.Controllers
{
    public class BannerDescriptionController : Controller
    {
        // Models.BannerWithDescription BannerWithDescription = new Models.BannerWithDescription();
        // GET: BannerWithDescription
        public ActionResult BannerAction()
        {
            BanneDescriptionServices bannerService = new BanneDescriptionServices();
            var bannerModel = bannerService.Banner();
            return PartialView("_SpotlightGreenView", bannerModel);
        }
    }
}