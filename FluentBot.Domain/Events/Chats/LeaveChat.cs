namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для выхода из чата.
/// </summary>
/// <param name="ChatId"></param>
public record LeaveChat(
    ChatId ChatId)
    : IEventEntity;