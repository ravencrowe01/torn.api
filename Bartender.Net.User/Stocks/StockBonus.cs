﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class StockBonus {
    [JsonProperty ("ready")]
    public required int Ready { get; set; }

    [JsonProperty ("increment")]
    public required int Increment { get; set; }

    [JsonProperty ("progress")]
    public required int Progress { get; set; }

    [JsonProperty ("frequency")]
    public required int Frequency { get; set; }
}
