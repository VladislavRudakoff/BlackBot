using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands;

/// <summary>
/// Модель для установки разрешений чата по умолчанию.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Permissions">Новые разрешения по умолчанию.</param>
public record SetDefaultChatPermissions(
    ChatId ChatId,
    ChatPermissions Permissions)
    : IEventEntity;