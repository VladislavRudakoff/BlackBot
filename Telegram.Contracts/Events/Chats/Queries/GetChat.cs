using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Queries;

/// <summary>
/// Модель для получения информации о чате.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record GetChat(
    ChatId ChatId)
    : IEventEntity;