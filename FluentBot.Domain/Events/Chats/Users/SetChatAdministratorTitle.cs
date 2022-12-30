namespace FluentBot.Domain.UseCases.Events.Chats.Users;

/// <summary>
/// Модель для создания "титула" для администратора в супергруппе.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
/// <param name="CustomTitle">Новый "титул" для администратора(0-16 символов, <b>без emoji</b>).</param>
public record SetChatAdministratorTitle(
    ChatId ChatId,
    long UserId,
    string CustomTitle)
    : IEventEntity;