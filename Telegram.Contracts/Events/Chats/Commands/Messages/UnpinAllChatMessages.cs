using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Messages;

/// <summary>
/// Модель для удаления всех сообщений из списка закрепленных.
/// </summary>
/// <param name="ChatId"></param>
public record UnpinAllChatMessages(
    ChatId ChatId)
    : IEventEntity;