namespace Telegram.Contracts.DTOs.Chats;

/// <summary>
/// Права администратора в чате.
/// </summary>
/// <param name="IsAnonymous">True, если пользователь скрыт в чате.</param>
/// <param name="CanManageChat">True, если администратор может:<br />
/// -Получить доступ к журналу событий чата<br />
/// -К статистике чата<br />
/// -К статистике сообщений в каналах<br />
/// -Видеть участников канала<br />
/// -Видеть анонимных администраторов в супергруппах<br />
/// -Игнорировать медленный режим.</param>
/// <param name="CanDeleteMessages">True, если администратор может удалять сообщения других пользователей.</param>
/// <param name="CanManageVideoChats">True, если администратор может управлять видеочатами.</param>
/// <param name="CanRestrictMembers">True, если администратор может ограничивать, блокировать или разблокировать участников чата.</param>
/// <param name="CanPromoteMembers">True, если администратор может добавлять новых администраторов или понижать в должности администраторов, которых он прямо или косвенно повысил.</param>
/// <param name="CanChangeInfo">True, если администратору разрешено изменять название чата, фото и другие настройки.</param>
/// <param name="CanInviteUsers">True, если администратору разрешено приглашать новых пользователей в чат.</param>
/// <param name="CanPostMessages">True, если администратор может размещать сообщения в канале. <b>Только в каналах.</b></param>
/// <param name="CanEditMessages">True, если администратор может редактировать сообщения других пользователей и закреплять сообщения. <b>Только в каналах.</b></param>
/// <param name="CanPinMessages">True, если администратору разрешено закреплять сообщения. <b>Только в группах и супергруппах.</b></param>
public record ChatAdministratorRights(
    bool IsAnonymous,
    bool CanManageChat,
    bool CanDeleteMessages,
    bool CanManageVideoChats,
    bool CanRestrictMembers,
    bool CanPromoteMembers,
    bool CanChangeInfo,
    bool CanInviteUsers,
    bool? CanPostMessages,
    bool? CanEditMessages,
    bool? CanPinMessages);