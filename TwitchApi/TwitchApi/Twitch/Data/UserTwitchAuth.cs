namespace TwitchApi.Twitch.Data;

public record UserTwitchAuth(
    string? AccessToken,
    string? RefreshToken,
    string? BroadcasterId
);
