using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahMarkup.Models;

namespace TanmiahMarkup.Services
{
    public class BreadCrumbServices
    {
        public BreadCrumbModel Bread()
        {
            BreadCrumbModel Crumb = new BreadCrumbModel();
            Crumb.MainLink = "Home";
            Crumb.Link = "Products";
            Crumb.Sublink = "Chicken Nuggets";
            return Crumb;
        }
    }
}