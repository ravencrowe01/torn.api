﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationStats : BartenderEntity {
    [JsonProperty ("endurance")]
    public required float Endurance { get; set; }

    [JsonProperty ("intelligence")]
    public required float Intelligence { get; set; }

    [JsonProperty ("manual_labor")]
    public required float ManualLabor { get; set; }
}
