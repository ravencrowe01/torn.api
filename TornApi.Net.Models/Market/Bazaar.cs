﻿using Newtonsoft.Json;

namespace TornApi.Net.Models.Market;

public class Bazaar {
    [JsonProperty("bazaar")]
    public IEnumerable<MarketItem> Items { get; set; }
}
