namespace FluentBot.Domain.UseCases.Events.Chats.Users;

/// <summary>
/// Модель для того, чтобы забанить пользователя группе, супергруппе или канале.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
/// <param name="UntilDate">Дата, когда пользователь будет разбанен(Unix). От 30 сек до 366 дней, любая дата меньше или больше этого промежутка времени - бан навсегда.</param>
/// <param name="RevokeMessages">True - если нужно стереть все сообщения для забаненного пользователя, иначе все сообщения до момента блокировки сохранятся.</param>
public record BanChatMember(
    ChatId ChatId,
    long UserId,
    int? UntilDate,
    bool? RevokeMessages)
    : IEventEntity;