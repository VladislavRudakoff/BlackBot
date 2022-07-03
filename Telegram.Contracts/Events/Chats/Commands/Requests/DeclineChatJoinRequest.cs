using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Requests;

/// <summary>
/// Модель для отклонения запроса на присоединение к чату.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
public record DeclineChatJoinRequest(
    ChatId ChatId,
    long UserId)
    : IEventEntity;