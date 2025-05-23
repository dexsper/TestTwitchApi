using System.Text.Json;
using TwitchAPi.Client.Data;

namespace TwitchAPi.Client;

public class UserAuthStorage
{
    private readonly string _filename;
    private readonly static UserTwitchAuth _empty = new(null, null, null);

    public UserAuthStorage(string filename)
    {
        _filename = filename;
    }

    public UserTwitchAuth Load()
    {
        if (!File.Exists(_filename))
        {
            return _empty;
        }

        var json = File.ReadAllText(_filename);
        var userAuth = JsonSerializer.Deserialize<UserTwitchAuth>(json);

        return userAuth ?? _empty;
    }

    public void Save(UserTwitchAuth auth)
    {
        var json = JsonSerializer.Serialize(auth, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(_filename, json);
    }
}
