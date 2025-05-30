﻿namespace TwitchAPi.Client.Common;

[AttributeUsage(AttributeTargets.Field)]
public class TwitchScopeAttribute : Attribute
{
    public string Value { get; }
    public TwitchScopeAttribute(string value) => Value = value;
}

