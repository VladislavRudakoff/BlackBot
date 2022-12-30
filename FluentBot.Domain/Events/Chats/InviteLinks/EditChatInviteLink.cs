namespace FluentBot.Domain.UseCases.Events.Chats.InviteLinks;

/// <summary>
/// Модель для редактирования дополнительной ссылки-приглашения, созданной ботом.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="InviteLink">Ссылка-приглашение для редактирования.</param>
/// <param name="Name">Имя ссылки-приглашения(0-32 символа).</param>
/// <param name="ExpireData">Момент времени, когда срок действия ссылки истечёт(Unix).</param>
/// <param name="MemberLimit">Максимальное количество пользователей, которые могут присоединиться по данной ссылке(1-99999).</param>
/// <param name="CreatesJoinRequest">True - если люди присоединившиеся по данной ссылке должны быть одобрены администратором(если указано - MemberLimit = null).</param>
public record EditChatInviteLink(
    ChatId ChatId,
    string InviteLink,
    string? Name,
    int? ExpireData,
    int? MemberLimit,
    bool? CreatesJoinRequest)
    : IEventEntity;