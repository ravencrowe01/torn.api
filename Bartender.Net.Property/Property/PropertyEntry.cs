﻿using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Property.Property;

public class PropertyEntry : BartenderEntity {
    [JsonProperty ("owner_id")]
    public required int OwnerId { get; set; }

    [JsonProperty ("property_type")]
    public required int PropertyType { get; set; }

    [JsonProperty ("happy")]
    public required int Happy { get; set; }

    [JsonProperty ("upkeep")]
    public required int Upkeep { get; set; }

    [JsonProperty ("upgrades")]
    public virtual required List<string> Upgrades { get; set; }

    [JsonProperty ("staff")]
    public virtual required List<string> Staff { get; set; }

    [JsonProperty ("rented")]
    public virtual required RentEntry Rented { get; set; }

    [JsonProperty ("users_living")]
    public required string UsersLiving { get; set; }
}
