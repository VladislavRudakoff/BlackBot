using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Common.Commands.Messages;

/// <summary>
/// Модель для удаления сообщения.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="MessageId">Идентификатор удаляемого сообщения.</param>
public record DeleteMessage(
    ChatId ChatId,
    int MessageId)
    : IEventEntity;