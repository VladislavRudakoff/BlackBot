using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Files.Audio;

/// <summary>
/// Модель для отправки аудиофайлов.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Audio"></param>
/// <param name="Caption">Подпись к аудио.</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Коллекция специальных сущностей.</param>
/// <param name="Duration">Продолжительность(в секундах).</param>
/// <param name="Performer">Исполнитель.</param>
/// <param name="Title">Название трека.</param>
/// <param name="Thumb">Миниатюра отправленного файла.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendAudio(
    ChatId ChatId,
    string Audio,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    int? Duration,
    string? Performer,
    string? Title,
    string? Thumb,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : ISendingEntity;