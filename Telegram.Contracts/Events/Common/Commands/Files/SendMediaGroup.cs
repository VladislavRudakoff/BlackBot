using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.DTOs.Files.InputMultimedia;
using Telegram.Contracts.DTOs.Interfaces;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Common.Commands.Files;

/// <summary>
/// Модель для отправки группы фотографий, видео, документов или аудио в виде альбома.<br />
/// Могут быть сгруппированы сообщения только одного типа.
/// </summary>
/// <param name="ChatId"></param>
/// <param name="Media"></param>
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