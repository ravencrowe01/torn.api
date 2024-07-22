﻿using Bartender.Net.User.Bars;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Profile {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("age")]
    public required int Age { get; set; }

    [JsonProperty ("awards")]
    public required int Awards { get; set; }

    [JsonProperty ("icons")]
    public required IDictionary<string, string> BasicIcons { get; set; }

    [JsonProperty ("competition")]
    public required Competition Competition { get; set; }

    [JsonProperty ("donator")]
    public required bool Donator { get; set; }

    [JsonProperty ("enemies")]
    public required int Enemies { get; set; }

    [JsonProperty ("faction")]
    public required FactionStub Faction { get; set; }

    [JsonProperty ("forum_posts")]
    public required int ForumPosts { get; set; }

    [JsonProperty ("friends")]
    public required int Friends { get; set; }

    [JsonProperty ("gender")]
    public required Gender Gender { get; set; }

    [JsonProperty ("honor")]
    public required int Honor { get; set; }

    [JsonProperty ("job")]
    public required Job Job { get; set; }

    [JsonProperty ("karma")]
    public required int Karma { get; set; }

    [JsonProperty ("last_action")]
    public required LastAction LastAction { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("life")]
    public required Bar Life { get; set; }

    [JsonProperty ("marrige")]
    public required Marriage Marriage { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("player_id")]
    public required int ProfileID { get; set; }

    [JsonProperty ("rank")]
    public required string Rank { get; set; }

    [JsonProperty ("revivable")]
    public required bool Revivable { get; set; }

    [JsonProperty ("role")]
    public required string Role { get; set; }

    [JsonProperty ("signup")]
    public required string Signup { get; set; }

    [JsonProperty ("states")]
    public required PlayerStates States { get; set; }

    [JsonProperty ("status")]
    public required Status Status { get; set; }
}
