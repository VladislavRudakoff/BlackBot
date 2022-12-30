namespace FluentBot.Domain.UseCases.Events.Common.Messages;

/// <summary>
/// Модель для редактирования заголовков сообщений.
/// </summary>
/// <param name="ChatId">Идентификатор чата(если не указан InlineMessageId).</param>
/// <param name="MessageId">Идентификатор редактируемого сообщения(если не указан InlineMessageId).</param>
/// <param name="InlineMessageId">Идентификатор inline-сообщения(если не указаны ChatId и MessageId).</param>
/// <param name="Caption">Новый заголовок сообщения(0-1024 символа после форматирования).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="Entities">Список специальных сущностей(используются вместо ParseMode).</param>
/// <param name="DisableWebPagePreview">Отключает предварительный просмотр ссылок в сообщении.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
public record EditMessageCaption(
    ChatId? ChatId,
    int? MessageId,
    string? InlineMessageId,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? Entities,
    bool? DisableWebPagePreview,
    InlineKeyboardMarkup? ReplyMarkup)
    : IEventEntity;