using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands;

/// <summary>
/// Модель для выхода из чата.
/// </summary>
/// <param name="ChatId"></param>
public record LeaveChat(
    ChatId ChatId)
    : IEventEntity;