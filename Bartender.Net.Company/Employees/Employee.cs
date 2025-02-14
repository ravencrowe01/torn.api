﻿using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class Employee : BartenderEntity {
    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public required int DaysInCompany { get; set; }

    [JsonProperty ("manual_labor")]
    public required int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public required int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public required int Endurance { get; set; }

    [JsonProperty ("effectiveness")]
    public virtual required Effectiveness Effectiveness { get; set; }

    [JsonProperty ("last_action")]
    public virtual required LastAction LastAction { get; set; }

    [JsonProperty ("status")]
    public virtual required Status Status { get; set; }
}
