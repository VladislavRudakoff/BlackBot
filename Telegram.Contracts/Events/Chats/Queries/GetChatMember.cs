using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Queries;

/// <summary>
/// Модель для получения информации о пользователе в чате.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
public record GetChatMember(
    ChatId ChatId,
    long UserId)
    : IEventEntity;