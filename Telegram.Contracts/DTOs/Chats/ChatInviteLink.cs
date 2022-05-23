namespace Telegram.Contracts.DTOs.Chats;

/// <summary>
/// Ссылка-приглашение в чат.
/// </summary>
/// <param name="InviteLink">Ссылка-приглашение.</param>
/// <param name="Creator">Создатель ссылки.</param>
/// <param name="CreatesJoinRequest">True, если пользователи, присоединяющиеся к чату по ссылке, должны быть одобрены администраторами чата.</param>
/// TODO Уточнить описание свойства.
/// <param name="IsPrimary">True, если ссылка является первичной.????????????????????</param>
/// <param name="IsRevoked">True, если ссылка отозвана.</param>
/// <param name="Name">Имя ссылки.</param>
/// <param name="ExpireDate">Момент времени(Unix), когда срок действия ссылки истечет или истек.</param>
/// TODO Уточнить описание свойства.
/// <param name="MemberLimit">Максимальное количество пользователей, которые могут быть участниками чата одновременно после присоединения к чату по данной ссылке-приглашению(от 1 до 99999).?????????</param>
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