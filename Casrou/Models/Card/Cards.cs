using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casrou.Models
{
    public class Cards
    {
        public Cards()
        {
            Socials = new List<SocialCard>();
            Quotes = new List<QuoteCard>();
            Images = new List<ImageCard>();
        }

        [JsonProperty("socials")]
        public List<SocialCard> Socials { get; set; }

        [JsonProperty("quotes")]
        public List<QuoteCard> Quotes { get; set; }

        [JsonProperty("images")]
        public List<ImageCard> Images { get; set; }
    }
}
