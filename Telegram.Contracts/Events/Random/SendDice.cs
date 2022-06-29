using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Random;

/// <summary>
/// Модель для отправки анимированного emoji со случайным числом.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Emoji">Emoji на котором основана анимация броска костей(по умолчанию emoji - кость).</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendDice(
    ChatId ChatId,
    string? Emoji,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;