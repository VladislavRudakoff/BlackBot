using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Messages;

/// <summary>
/// Модель для удаления сообщения из списка закрепленных.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="MessageId">Идентификатор открепляемого сообщения(если null - открепляет последнее закрепленное сообщение).</param>
public record UnpinChatMessage(
    ChatId ChatId,
    int? MessageId)
    : IEventEntity;