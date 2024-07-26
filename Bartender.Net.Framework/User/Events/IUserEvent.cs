﻿namespace Bartender.Net.Framework.User.Events;

public interface IUserEvent : IBartenderEntity {
    string Event { get; }
    int Timestamp { get; }
}