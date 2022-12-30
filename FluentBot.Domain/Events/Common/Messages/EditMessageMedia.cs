namespace FluentBot.Domain.UseCases.Events.Common.Messages;

/// <summary>
/// Модель для редактирования мультимедийного сообщения.
/// </summary>
/// <param name="Media">Новое мультимедийное содержание сообщения.</param>
/// <param name="ChatId">Идентификатор чата(если не указан InlineMessageId).</param>
/// <param name="MessageId">Идентификатор редактируемого сообщения(если не указан InlineMessageId).</param>
/// <param name="InlineMessageId">Идентификатор inline-сообщения(если не указаны ChatId и MessageId).</param>
/// <param name="ReplyMarkup">Встроенная клавиатура.</param>
public record EditMessageMedia(
    InputMedia Media,
    ChatId? ChatId,
    int? MessageId,
    string? InlineMessageId,
    InlineKeyboardMarkup? ReplyMarkup)
    : IEventEntity;