using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Queries;

/// <summary>
/// Модель для получения списка администраторов чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record GetChatAdministrators(
    ChatId ChatId)
    : IEventEntity;