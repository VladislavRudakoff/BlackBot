using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.DTOs.Messages;
using Telegram.Contracts.Events.Commands.Common.Interfaces;

namespace Telegram.Contracts.Events.Commands.Common.Files.Animations;

/// <summary>
/// Модель для отправки анимации.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Animation">Анимация для отправки.</param>
/// <param name="Duration">Продолжительность анимации(в секундах).</param>
/// <param name="Width">Ширина анимации.</param>
/// <param name="Height">Высота анимации.</param>
/// <param name="Thumb">Миниатюра отправленной анимации.</param>
/// <param name="Caption">Подпись к анимации.</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Коллекция специальных сущностей.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendAnimation(
    ChatId ChatId,
    string Animation,
    int? Duration,
    int? Width,
    int? Height,
    string? Thumb, 
    string? Caption,
    string? ParseMode,
    IEnumerable<MessageEntity>? CaptionEntities,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;