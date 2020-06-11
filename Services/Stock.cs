using System.Dynamic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Services
{
    public class Stock
    {
        [JsonProperty("c")]
        public double Close { get; set; }
        [JsonProperty("h")]
        public double High { get; set; }
        [JsonProperty("l")]
        public double Low { get; set; }
        [JsonProperty("o")]
        public double Open { get; set; }
        [JsonProperty("pc")]
        public double Price { get; set; }
        [JsonProperty("t")]
        public int Time { get; set; }
    }
}
