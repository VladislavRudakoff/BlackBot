namespace FluentBot.Domain.UseCases.Events.Common.Files.Video;

/// <summary>
/// Модель для отправки видео.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Video">Видео для отправки.</param>
/// <param name="Duration">Продолжительность видео(в секундах).</param>
/// <param name="Width">Ширина видео.</param>
/// <param name="Height">Высота видео.</param>
/// <param name="Thumb">Миниатюра отправленного видеофайла.</param>
/// <param name="Caption">Подпись к видео.</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Коллекция специальных сущностей.</param>
/// <param name="SupportStreaming">True - если загруженное видео подходит для потоковой передачи.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendVideo(
    ChatId ChatId,
    string Video,
    int? Duration,
    int? Width,
    int? Height,
    string? Thumb,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    bool? SupportStreaming,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;