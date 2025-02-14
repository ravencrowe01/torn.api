﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillsRoot : BartenderEntity {
    [JsonProperty ("refills")]
    public virtual required RefillStates Refills { get; set; }
}
