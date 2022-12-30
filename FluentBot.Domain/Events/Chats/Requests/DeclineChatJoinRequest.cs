namespace FluentBot.Domain.UseCases.Events.Chats.Requests;

/// <summary>
/// Модель для отклонения запроса на присоединение к чату.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
public record DeclineChatJoinRequest(
    ChatId ChatId,
    long UserId)
    : IEventEntity;