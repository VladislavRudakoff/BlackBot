namespace FluentBot.Domain.UseCases.Events.Common.Messages;

/// <summary>
/// Модель для редактирования текстовых и игровых сообщений.
/// </summary>
/// <param name="Text">Новый текст сообщения(1-4096 символов после форматирования).</param>
/// <param name="ChatId">Идентификатор чата(если не указан InlineMessageId).</param>
/// <param name="MessageId">Идентификатор редактируемого сообщения(если не указан InlineMessageId).</param>
/// <param name="InlineMessageId">Идентификатор inline-сообщения(если не указаны ChatId и MessageId).</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="Entities">Список специальных сущностей(используются вместо ParseMode).</param>
/// <param name="DisableWebPagePreview">Отключает предварительный просмотр ссылок в сообщении.</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
public record EditMessageText(
    string Text,
    ChatId? ChatId,
    int? MessageId,
    string? InlineMessageId,
    string? ParseMode,
    IEnumerable<MessageEntity>? Entities,
    bool? DisableWebPagePreview,
    InlineKeyboardMarkup? ReplyMarkup)
    : IEventEntity;