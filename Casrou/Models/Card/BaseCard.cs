using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casrou.Models
{
    public class BaseCard
    {
        [JsonProperty("type")]
        public CardType CardType { get; set; }
    }
}
