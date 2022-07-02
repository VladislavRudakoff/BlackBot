using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Queries;

/// <summary>
/// Модель для получения количества участников чата.
/// </summary>
/// <param name="ChatId"></param>
public record GetChatMemberCount(
    ChatId ChatId)
    : IEventEntity;