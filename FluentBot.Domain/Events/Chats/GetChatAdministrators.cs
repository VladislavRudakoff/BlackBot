namespace FluentBot.Domain.UseCases.Events.Chats;

/// <summary>
/// Модель для получения списка администраторов чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
public record GetChatAdministrators(
    ChatId ChatId)
    : IEventEntity;