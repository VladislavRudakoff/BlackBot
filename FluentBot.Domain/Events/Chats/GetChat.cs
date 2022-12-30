namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для получения информации о чате.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record GetChat(
    ChatId ChatId)
    : IEventEntity;