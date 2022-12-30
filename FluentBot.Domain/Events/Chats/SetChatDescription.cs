namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для изменения описания группы, супергруппы или канала.
/// </summary>
/// <param name="ChatId"></param>
/// <param name="Description"></param>
public record SetChatDescription(
    ChatId ChatId,
    string Description)
    : IEventEntity;