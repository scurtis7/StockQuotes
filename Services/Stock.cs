using System.Dynamic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Services
{
    public class Stock
    {
        [JsonProperty("c")]
        private double Close { get; set; }
        [JsonProperty("h")]
        private double High { get; set; }
        [JsonProperty("l")]
        private double Low { get; set; }
        [JsonProperty("o")]
        private double Open { get; set; }
        [JsonProperty("pc")]
        private double Price { get; set; }
        [JsonProperty("t")]
        private int Time { get; set; }
    }
}
