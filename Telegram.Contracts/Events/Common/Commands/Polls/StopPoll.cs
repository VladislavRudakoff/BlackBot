using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Common.Commands.Polls;

/// <summary>
/// Модель для остановки опроса, отправленного ботом.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="MessageId">Идентификатор сообщения с опросом.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
public record StopPoll(
    ChatId ChatId,
    int MessageId,
    InlineKeyboardMarkup? ReplyMarkup)
    : IEventEntity;