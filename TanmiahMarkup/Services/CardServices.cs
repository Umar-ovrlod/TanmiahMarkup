using TanmiahMarkup.Models;

namespace TanmiahMarkup.Services
{
    public class CardServices
    {
        public  CardModel cardDescription()
        {
            CardModel Description = new CardModel();
            Description.CardImg = "~/Content/Common/images/video/02.jpg";
            Description.CardTitle= "Our nuggets are made out of XYZ with lorem";
            Description.CardText = "This is a short description about the produLorem ipsum dolor sitamet, consectetur adipiscing elit.Vivamus ullamcorper purus purus, a semper tortor ullamcorper sed.Proin dictum, risus vitae rutrum ultrices, sem massa malesuadanisl,.";
            return Description;
        }
    }
}