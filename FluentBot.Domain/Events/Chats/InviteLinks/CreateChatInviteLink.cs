namespace FluentBot.Domain.UseCases.Events.Chats.InviteLinks;

/// <summary>
/// Модель для создания дополнительной ссылки-приглашения для чата.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Name">Имя ссылки-приглашения(0-32 символа).</param>
/// <param name="ExpireData">Момент времени, когда срок действия ссылки истечёт(Unix).</param>
/// <param name="MemberLimit">Максимальное количество пользователей, которые могут присоединиться по данной ссылке(1-99999).</param>
/// <param name="CreatesJoinRequest">True - если люди присоединившиеся по данной ссылке должны быть одобрены администратором(если указано - MemberLimit = null).</param>
public record CreateChatInviteLink(
    ChatId ChatId,
    string? Name,
    int? ExpireData,
    int? MemberLimit,
    bool? CreatesJoinRequest)
    : IEventEntity;