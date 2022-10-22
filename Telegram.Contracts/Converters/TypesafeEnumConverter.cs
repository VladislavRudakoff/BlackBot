using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Telegram.Contracts.Enums.Abstractions;

namespace Telegram.Contracts.Converters;

public class TypesafeEnumConverter<T> : JsonConverter<T>
    where T : Enumeration
{
    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, T? enumeration, JsonSerializer serializer)
    {
        if (enumeration is null)
        {
            throw new ArgumentException("Enumeration must not be null.");
        }

        writer.WriteValueAsync(enumeration.Value);
    }

    /// <inheritdoc />
    public override T ReadJson(
        JsonReader reader,
        Type objectType,
        T? existingValue,
        bool hasExistingValue,
        JsonSerializer serializer)
    {
        string? value = JToken.ReadFrom(reader).ToString();

        if (value == null)
        {
            throw new NullReferenceException("Enumeration value is not be null.");
        }

        return (T)Enumeration.GetInstanceOfEnumeration[typeof(T)](value);
    }
}