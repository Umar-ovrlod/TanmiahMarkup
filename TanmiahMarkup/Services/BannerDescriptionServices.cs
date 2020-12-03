using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahMarkup.Models;

namespace TanmiahMarkup.Services
{
    public class BanneDescriptionServices
    {
        public BannerDescriptionModel Banner()
        {
            BannerDescriptionModel bannerModel = new BannerDescriptionModel();
            bannerModel.FoodCategory="PROCESSED FOODS";
            bannerModel.FoodItem = "Chicken Nuggets";
            bannerModel.FoodCo = "Supreme Food processing Co";
            return bannerModel;
        }
    }
}