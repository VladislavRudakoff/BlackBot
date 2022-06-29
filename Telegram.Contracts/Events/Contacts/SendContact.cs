using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Contacts;

/// <summary>
/// Модель для отправки контакта.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="PhoneNumber">Телефонный номер контакта.</param>
/// <param name="FirstName">Имя контакта.</param>
/// <param name="LastName">Фамилия контакта.</param>
/// <param name="Vcard">Дополнительные данные о контакте в виде vCard(0-2048байт).</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendContact(
    ChatId ChatId,
    string PhoneNumber,
    string FirstName,
    string? LastName,
    string? Vcard,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;