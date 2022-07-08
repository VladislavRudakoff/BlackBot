using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Keyboard;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Stickers;

/// <summary>
/// Модель для отправки стикера.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Sticker">Стикер для отправки.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendSticker(
    ChatId ChatId,
    string Sticker,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    InlineKeyboardMarkup? ReplyMarkup)
    : IEventEntity;