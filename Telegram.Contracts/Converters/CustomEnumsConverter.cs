using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Telegram.Contracts.Enums;
using Telegram.Contracts.Enums.Abstractions;

namespace Telegram.Contracts.Converters;

public class InlineQueryResultTypeConverter : JsonConverter<InlineQueryResultType>
{
    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, InlineQueryResultType? enumeration, JsonSerializer serializer)
    {
        if (enumeration is null)
        {
            throw new ArgumentException("Enumeration must not be null.");
        }

        writer.WriteValueAsync(enumeration.Value);
    }

    /// <inheritdoc />
    public override InlineQueryResultType ReadJson(
        JsonReader reader,
        Type objectType,
        InlineQueryResultType? existingValue,
        bool hasExistingValue,
        JsonSerializer serializer)
    {
        string? value = JToken.ReadFrom(reader).ToString();

        if (value == null)
        {
            throw new NullReferenceException("Enumeration value is not be null.");
        }

        return (InlineQueryResultType)Enumeration.Instance(value);
    }
}