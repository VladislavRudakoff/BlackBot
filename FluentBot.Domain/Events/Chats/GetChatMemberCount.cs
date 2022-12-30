namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для получения количества участников чата.
/// </summary>
/// <param name="ChatId"></param>
public record GetChatMemberCount(
    ChatId ChatId)
    : IEventEntity;