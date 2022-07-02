using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands;

/// <summary>
/// Модель для изменения описания группы, супергруппы или канала.
/// </summary>
/// <param name="ChatId"></param>
/// <param name="Description"></param>
public record SetChatDescription(
    ChatId ChatId,
    string Description)
    : IEventEntity;