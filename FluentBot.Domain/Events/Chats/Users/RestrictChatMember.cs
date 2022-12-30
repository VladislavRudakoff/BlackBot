namespace FluentBot.Domain.UseCases.Events.Chats.Users;

/// <summary>
/// Модель для ограничения разрешений пользователя в супергруппе.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
/// <param name="Permissions">Новые разрешения для пользователя.</param>
/// <param name="UntilDate">Дата снятия ограничений(Unix). От 30 сек до 366 дней, любая дата меньше или больше этого промежутка времени - бан навсегда.</param>
public record RestrictChatMember(
    ChatId ChatId,
    long UserId,
    ChatPermissions Permissions,
    int? UntilDate)
    : IEventEntity;