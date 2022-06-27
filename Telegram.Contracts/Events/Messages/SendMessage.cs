using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Messages;

/// <summary>
/// Модель для отправки сообщения.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Text">Текст сообщения.</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="Entities">Коллекция <see cref="MessageEntity"/>.</param>
/// <param name="DisableWebPagePreview">Отключает предварительный просмотр ссылок в этом сообщении.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendMessage(
    ChatId ChatId,
    string Text,
    string? ParseMode,
    IEnumerable<MessageEntity>? Entities,
    bool? DisableWebPagePreview,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : ISendingEntity;