namespace FluentBot.Domain.UseCases.Events.Common.Files.Location;

/// <summary>
/// Модель для остановки обновления сообщения о текущем местоположении.
/// </summary>
/// <param name="ChatId">Идентификатор чата(требуется, если не указан InlineMessageId).</param>
/// <param name="MessageId">Идентификатор сообщения для редактирования(требуется, если не указан InlineMessageId).</param>
/// <param name="InlineMessageId">Идентификатор встроенного сообщения(требуется, если не указаны ChatId и MessageId).</param>
/// <param name="ReplyMarkup">Дополнительные возможности интерфейса.</param>
public record StopMessageLiveLocation(
    ChatId? ChatId,
    MessageIdentifier? MessageId,
    string? InlineMessageId,
    IInterfaceOptions? ReplyMarkup)
    : IEventEntity;