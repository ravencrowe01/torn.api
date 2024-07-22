﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class FriendOrFoeUser {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty("name")]
    public required string Name { get; set; }

    [JsonProperty("user_id")]
    public required int UserID { get; set; }
}
