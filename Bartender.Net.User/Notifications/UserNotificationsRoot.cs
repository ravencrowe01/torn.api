﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Notifications;

public class UserNotificationsRoot : BartenderEntity {
    [JsonProperty ("notifications")]
    public virtual required UserNotifications Notifications { get; set; }
}