namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для установки разрешений чата по умолчанию.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Permissions">Новые разрешения по умолчанию.</param>
public record SetDefaultChatPermissions(
    ChatId ChatId,
    ChatPermissions Permissions)
    : IEventEntity;