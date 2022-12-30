namespace FluentBot.Domain.Entities.Entities.Chats;

/// <summary>
/// Модель идентификатора чата. Может являться как Int64(ChatId), так и string(Username).
/// </summary>
[JsonConverter(typeof(ChatIdConverter))]
public class ChatId
{
    /// <summary>
    /// ctor. 
    /// </summary>
    /// <param name="identifier">Идентификатор чата.</param>
    public ChatId(object? identifier)
    {
        switch (identifier)
        {
            case null:
                throw new ArgumentNullException(nameof(identifier));
            case string { Length: > 1 } username 
                when username.StartsWith("@", StringComparison.InvariantCulture):
                Username = username;
                break;
            case long id:
                Id = id;
                break;
            default:
                throw new ArgumentException("Идентификатор должен быть либо числом(Int64), либо юзернеймом, начинающимся на @");
        }
    }

    /// <summary>
    /// Идентификатор чата.
    /// </summary>
    public long? Id { get; }

    /// <summary>
    /// Юзернейм.
    /// </summary>
    public string? Username { get; }
}