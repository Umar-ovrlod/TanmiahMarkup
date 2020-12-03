using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahMarkup.Models;

namespace TanmiahMarkup.Services
{
    public class ListingValues
    {
        ListingModel listItems = new ListingModel();
        public ListingModel GetData()
        {
            listItems.ListProducts.Add(new ListingServices { Image = "~/Content/Common/images/listing-cards/image-5.jpg", FoodCategory = "RED MEAT", Title = "Grilled chicken breast", Text = " This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet." });
            listItems.ListProducts.Add(new ListingServices { Image = "~/Content/Common/images/listing-cards/image-6.jpg", FoodCategory = "Frozen food", Title = "Featured Product Name", Text = "This is a short description about the type of products provided by AgriculturalDevelopmentCompany.Lorem ipsum dolor sit amet." });
            listItems.ListProducts.Add(new ListingServices { Image = "~/Content/Common/images/listing-cards/image-6.jpg", FoodCategory = "Frozen food", Title = "Featured Product Name", Text = "This is a short description about the type of products provided by AgriculturalDevelopmentCompany.Lorem ipsum dolor sit amet." });
            listItems.ListProducts.Add(new ListingServices { Image = "~/Content/Common/images/listing-cards/image-6.jpg", FoodCategory = "Frozen food", Title = "Featured Product Name", Text = "This is a short description about the type of products provided by AgriculturalDevelopmentCompany.Lorem ipsum dolor sit amet." });
            return listItems;
        }
    }
}