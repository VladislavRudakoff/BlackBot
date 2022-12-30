namespace FluentBot.Domain.UseCases.Events.Common.Polls;

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