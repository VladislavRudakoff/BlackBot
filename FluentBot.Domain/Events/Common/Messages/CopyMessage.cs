namespace FluentBot.Domain.UseCases.Events.Common.Messages;

/// <summary>
/// Модель для копирования сообщения.
/// </summary>
/// <param name="ChatId">Идентификатор чата в который нужно отправить копию.</param>
/// <param name="FromChatId">Идентификатор чата, в который было отправлено исходное сообщение.</param>
/// <param name="MessageId">Идентификатор сообщения.</param>
/// <param name="Caption">Новая подпись для медиа. Если null, то исходная подпись сохраняется.</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Коллекция специальных сущностей, из нового заголовка.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Запрет на пересылку и сохранение сообщения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True - если сообщение должно быть отправлено, даже если указанное сообщение с ответом не найдено.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record CopyMessage(
    ChatId ChatId,
    ChatId FromChatId,
    int MessageId,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;