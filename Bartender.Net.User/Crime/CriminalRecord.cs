using Newtonsoft.Json;

namespace Bartender.Net.User.Crime;

public class CriminalRecord {
    [JsonProperty ("criminalrecord")]
    public required CrimnalRecordCollection Crimes { get; set; }
}
