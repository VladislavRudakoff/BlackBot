using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Common.Interfaces;

namespace Telegram.Contracts.Events.Common.Files.Audio;

/// <summary>
/// Модель для отправки голосового сообщения.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Voice">Аудиофайл для отправки.</param>
/// <param name="Caption">Подпись к голосовому сообщению.</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Коллекция специальных сущностей.</param>
/// <param name="Duration">Продолжительность голосового сообщения(в секундах).</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendVoice(
    ChatId ChatId,
    string Voice,
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    int? Duration,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;