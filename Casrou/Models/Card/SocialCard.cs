using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casrou.Models
{
    public class SocialCard : BaseCard
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("src")]
        public string ImageSrc { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
