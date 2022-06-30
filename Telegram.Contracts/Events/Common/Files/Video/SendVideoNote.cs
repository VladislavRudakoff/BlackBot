using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.Events.Common.Interfaces;

namespace Telegram.Contracts.Events.Common.Files.Video;

/// <summary>
/// Модель для отправки видеосообщений.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="VideoNote">Видеосообщение для отправки.</param>
/// <param name="Duration">Продолжительность видео(в секундах).</param>
/// <param name="Length">Диаметр видеосообщения.</param>
/// <param name="Thumb">Миниатюра отправленного видеофайла.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendVideoNote(
    ChatId ChatId,
    string VideoNote,
    int? Duration,
    int? Length,
    string Thumb,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;