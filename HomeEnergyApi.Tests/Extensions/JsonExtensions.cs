using Newtonsoft.Json.Linq;

namespace HomeEnergyApi.Tests.Extensions
{
    public static class JsonExtensions
{
    public static bool IsNullOrEmpty(this JToken? token)
    {
        return (token == null) ||
               (token.Type == JTokenType.Array && !token.HasValues) ||
               (token.Type == JTokenType.Object && !token.HasValues) ||
               (token.Type == JTokenType.String && token.ToString() == String.Empty) ||
               (token.Type == JTokenType.Null) ||
               (token.Type == JTokenType.Undefined);
    }
}
}