﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEvent : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("event")]
    public required string Event { get; set; }

    [JsonProperty ("seen")]
    public bool Seen { get; set; }
}
