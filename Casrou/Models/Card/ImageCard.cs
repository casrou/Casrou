using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casrou.Models
{
    public class ImageCard : BaseCard
    {
        [JsonProperty("src")]
        public string ImageSrc { get; set; }
    }
}
