using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahMarkup.Models;

namespace TanmiahMarkup.Services
{
    public class NuggetServices
    {
        public NuggetModel NuggetCard()
        {
            NuggetModel nuggetDescription = new NuggetModel();
            nuggetDescription.NuggetTitle = "What’s in a Nugget?";
            nuggetDescription.NuggetText = " Maltodextrin, potato starch, salt, sugar, flavourings, yeast extract,vegetables (onion powder, tomato puree powder), caramel syrup, palm fat, thickener(guar gum), sunflower oil, sage.";
            nuggetDescription.NuggetTextMore = "No Allergens to Declare - this product does not contain allergenic ingredients which require declaration under EU regulation 1169/2011 (Annex II).";
            nuggetDescription.NutritionPack = "Nutrition per pack (500g)";
            nuggetDescription.Energy = "Energy";
            nuggetDescription.Carbohydrates = "Carbohydrates";
            nuggetDescription.Protiens = "Protiens";
            nuggetDescription.Fat = "Fat";
            nuggetDescription.Protiensdual = "Protiens";
            nuggetDescription.Fatdual = "Fat";
            nuggetDescription.Order = "Want to order in bulk?";
            return nuggetDescription;
                }
    }
}