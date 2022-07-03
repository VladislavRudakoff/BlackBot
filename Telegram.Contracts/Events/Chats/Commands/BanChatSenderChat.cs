using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands;

/// <summary>
/// Модель для того, чтобы забанить чат канала в супергруппе или на канале.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="SenderChatId">Идентификатор целевого чата отправителя.</param>
public record BanChatSenderChat(
    ChatId ChatId,
    int SenderChatId)
    : IEventEntity;