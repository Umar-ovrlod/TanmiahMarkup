using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahMarkup.Services;

namespace TanmiahMarkup.Controllers
{
    public class BreadCrumbController : Controller
    {
        // GET: BreadCrumb
        public ActionResult BreadCrumbAction()
        {
            BreadCrumbServices crumbServices = new BreadCrumbServices();
            var crumbModel = crumbServices.Bread();
            //return View(crumbModel);
            return PartialView("_Breadcrumbs", crumbModel);

        }
    }
}