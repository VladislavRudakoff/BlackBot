﻿namespace FluentBot.Domain.UseCases.Events.Common.Files;

/// <summary>
/// Модель для отправки группы фотографий, видео, документов или аудио в виде альбома.<br />
/// Могут быть сгруппированы сообщения только одного типа.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Media">Коллекция медиа файлов.</param>
/// <param name="DisableNotification">Отключает уведомление о сообщении.</param>
/// <param name="ProtectContent">Защищает содержимое отправленного сообщения от пересылки и сохранения.</param>
/// <param name="ReplyToMessageId">Идентификатор исходного сообщения, если текущее сообщение является ответом.</param>
/// <param name="AllowSendingWithoutReply">True если сообщение всё равно должно быть отправлено, даже если не найдено связанное.</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record SendMediaGroup(
    ChatId ChatId,
    IEnumerable<InputMedia> Media,
    bool? DisableNotification,
    bool? ProtectContent,
    int? ReplyToMessageId,
    bool? AllowSendingWithoutReply,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;