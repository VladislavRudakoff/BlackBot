using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Bot.Common.Extensions.Settings;

public static class SerializerSettings
{
    /// <summary>
    /// Опции сериализации(snake_case)
    /// </summary>
    public static JsonSerializerSettings SnakeCaseSerializerOptions;

    /// <summary>
    /// Опции сериализации(camelCase)
    /// </summary>
    public static JsonSerializerSettings CamelCaseSerializerOptions;

    /// <summary>
    /// Опции сериализации(kebab-case)
    /// </summary>
    public static JsonSerializerSettings KebabCaseSerializerOptions;

    /// <summary>
    /// ctor.
    /// </summary>
    static SerializerSettings()
    {
        SnakeCaseSerializerOptions = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy { ProcessDictionaryKeys = true }
            }
        };

        CamelCaseSerializerOptions = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy { ProcessDictionaryKeys = true }
            }
        };

        KebabCaseSerializerOptions = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new KebabCaseNamingStrategy { ProcessDictionaryKeys = true }
            }
        };
    }
}