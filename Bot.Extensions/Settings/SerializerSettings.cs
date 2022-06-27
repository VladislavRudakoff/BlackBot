using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Bot.Common.Extensions.Settings;

public static class SerializerSettings
{
    /// <summary>
    /// Опции сериализации(snake_case)
    /// </summary>
    public static JsonSerializerSettings SnakeCaseSerializerOptions =>
        new()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy { ProcessDictionaryKeys = true }
            },
            NullValueHandling = NullValueHandling.Ignore
        };

    /// <summary>
    /// Опции сериализации(camelCase)
    /// </summary>
    public static JsonSerializerSettings CamelCaseSerializerOptions =>
        new()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy { ProcessDictionaryKeys = true }
            },
            NullValueHandling = NullValueHandling.Ignore
        };

    /// <summary>
    /// Опции сериализации(kebab-case)
    /// </summary>
    public static JsonSerializerSettings KebabCaseSerializerOptions =>
        new()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new KebabCaseNamingStrategy { ProcessDictionaryKeys = true }
            },
            NullValueHandling = NullValueHandling.Ignore
        };
}