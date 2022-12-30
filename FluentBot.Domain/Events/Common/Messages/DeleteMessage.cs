namespace FluentBot.Domain.UseCases.Events.Common.Messages;

/// <summary>
/// Модель для удаления сообщения.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="MessageId">Идентификатор удаляемого сообщения.</param>
public record DeleteMessage(
    ChatId ChatId,
    int MessageId)
    : IEventEntity;