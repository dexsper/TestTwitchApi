using System.Collections.Specialized;
using System.Web;

namespace TwitchAPi.Client
{
    public static class TwitchExtensions
    {
        public static string ToScopeString(this TwitchScope scopes)
        {
            var scopeValues = Enum.GetValues<TwitchScope>()
                .Where(s => scopes.HasFlag(s))
                .Select(s => s.GetAttribute<TwitchScopeAttribute>())
                .Where(attr => attr != null && !string.IsNullOrEmpty(attr.Value))
                .Select(attr => attr!.Value)
                .ToList();

            return scopeValues.Count switch
            {
                0 => string.Empty,
                1 => scopeValues[0],
                _ => string.Join(" ", scopeValues)
            };
        }
        public static string ToQueryString(this NameValueCollection nvc)
        {
            if (nvc == null || nvc.Count == 0)
                return string.Empty;

            var array = (
                from key in nvc.AllKeys
                where key != null
                from value in nvc.GetValues(key) ?? Array.Empty<string>()
                select $"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(value)}"
            ).ToArray();

            return array.Length > 0 ? "?" + string.Join("&", array) : string.Empty;
        }
        public static T? GetAttribute<T>(this Enum value) where T : Attribute
        {
            var field = value.GetType().GetField(value.ToString());
            return field?.GetCustomAttributes(typeof(T), false).FirstOrDefault() as T;
        }
    }
}
