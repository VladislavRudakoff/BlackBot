using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Telegram.Contracts.Converters;

/// <summary>
/// Конвертер идентификатора чата.
/// </summary>
public class ChatIdConverter : JsonConverter<ChatId>
{
    /// <inheritdoc />
    public override void WriteJson(JsonWriter writer, ChatId? identifier, JsonSerializer serializer)
    {
        if (identifier is null )
        {
            throw new ArgumentException("ID must not be null.");
        }

        if (identifier.Username is not null)
        {
            writer.WriteValueAsync(identifier.Username);
        }
        else
        {
            writer.WriteValueAsync(identifier.Id);
        }
    }

    /// <inheritdoc />
    public override ChatId ReadJson(
        JsonReader reader, 
        Type objectType, 
        ChatId? existingValue, 
        bool hasExistingValue,
        JsonSerializer serializer)
    {
        object? value = JToken.ReadFrom(reader).Value<object>();
        return new ChatId(value);
    }
}