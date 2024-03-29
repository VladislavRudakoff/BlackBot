﻿namespace FluentBot.Domain.UseCases.Events.Common.Files;

/// <summary>
/// Модель для отправки общих файлов.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Document">Файл для отправки.</param>
/// <param name="Thumb">Миниатюра отправленного файла.</param>
/// <param name="Caption">Подпись к файлу.</param>
/// <param name="ParseMode">Форматирование.</param>
/// <param name="CaptionEntities">Коллекция специальных сущностей.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendFile(
    ChatId ChatId,
    string Document,
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