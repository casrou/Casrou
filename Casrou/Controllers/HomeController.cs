using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Casrou.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Casrou.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string cardsJson = System.IO.File.ReadAllText("wwwroot/cards.json");
            Cards cards = JsonConvert.DeserializeObject<Cards>(cardsJson);
            List<BaseCard> sortedCards = SortCards(cards);        
            return View(sortedCards);
        }

        /*
         * Sort the deserialized cards to a randomized list in the
         * order 'Social -> Image -> Social -> Quote' (if possible)
         */
        private List<BaseCard> SortCards(Cards cards)
        {
            cards.Socials = cards.Socials.OrderBy(a => Guid.NewGuid()).ToList();
            cards.Quotes = cards.Quotes.OrderBy(a => Guid.NewGuid()).ToList();
            cards.Images = cards.Images.OrderBy(a => Guid.NewGuid()).ToList();

            List<BaseCard> sortedCards = new List<BaseCard>();
            while (cards.Images.Count + cards.Quotes.Count + cards.Socials.Count > 0)
            {
                if (cards.Socials.Count > 0)
                {
                    SocialCard social = cards.Socials[0];
                    sortedCards.Add(social);
                    cards.Socials.Remove(social);
                }
                if (cards.Images.Count > 0)
                {
                    ImageCard image = cards.Images[0];
                    sortedCards.Add(image);
                    cards.Images.Remove(image);
                }
                if (cards.Socials.Count > 0)
                {
                    SocialCard social = cards.Socials[0];
                    sortedCards.Add(social);
                    cards.Socials.Remove(social);
                }
                if (cards.Quotes.Count > 0)
                {
                    QuoteCard quote = cards.Quotes[0];
                    sortedCards.Add(quote);
                    cards.Quotes.Remove(quote);
                }                
            }
            return sortedCards;
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
