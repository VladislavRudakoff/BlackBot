namespace FluentBot.Domain.Entities.Entities.Chats;

/// <summary>
/// Ссылка-приглашение в чат.
/// </summary>
/// <param name="InviteLink">Ссылка-приглашение.</param>
/// <param name="Creator">Создатель ссылки.</param>
/// <param name="CreatesJoinRequest">True, если пользователи, присоединяющиеся к чату по ссылке, должны быть одобрены администраторами чата.</param>
/// <param name="IsPrimary">True, если ссылка является основной.</param>
/// <param name="IsRevoked">True, если ссылка отозвана.</param>
/// <param name="Name">Имя ссылки.</param>
/// <param name="ExpireDate">Момент времени(Unix), когда срок действия ссылки истечет или истек.</param>
/// <param name="MemberLimit">Максимальное количество пользователей, которые могут быть присоединиться к чату по данной ссылке-приглашению(1-99999).</param>
/// <param name="PendingJoinRequestCount">Количество ожидающих запросов на присоединение, созданных по этой ссылке.</param>
public record ChatInviteLink(
    string InviteLink,
    User Creator,
    bool CreatesJoinRequest,
    bool IsPrimary,
    bool IsRevoked,
    string? Name,
    int? ExpireDate,
    int? MemberLimit,
    int? PendingJoinRequestCount);