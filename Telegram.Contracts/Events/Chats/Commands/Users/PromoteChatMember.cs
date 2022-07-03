using Telegram.Contracts.DTOs.Chats;
using Telegram.Contracts.Events.Interfaces;

namespace Telegram.Contracts.Events.Chats.Commands.Users;

/// <summary>
/// Модель для повышения/понижения пользователя в супегруппе или канале.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
/// <param name="IsAnonymous">True - для скрытия администратора в чате.</param>
/// <param name="CanManageChat">True - если администратор может получить доступ к журналу событий чата, статистике чата, статистике сообщений канала,<br />
/// видеть анонимных администраторов в супергруппах и игнорировать медленный режим.</param>
/// <param name="CanPostMessages">True - если администратор может создавать сообщения канала(<b>только в каналах</b>).</param>
/// <param name="CanEditMessages">True - если администратор может редактировать сообщения других пользователей и закреплять сообщения(<b>только в каналах</b>).</param>
/// <param name="CanDeleteMessages">True - если администратор может удалять сообщения других пользователей.</param>
/// <param name="CanManageVideoChats">True - если администратор может управлять видеочатами.</param>
/// <param name="CanRestrictMembers">True - если администратор может ограничивать, банить и разбанивать участников чата.</param>
/// <param name="CanPromoteMembers">True - если администратор может добавлять новых администраторов с таким же набором привилегий или понижать в должности администраторов,<br />
/// которых он повысил прямо или косвенно (повышен администраторами, которые были им назначены).</param>
/// <param name="CanChangeInfo">True - если администратор может изменить название чата, фото и другие настройки.</param>
/// <param name="CanInviteUsers">True - если администратор может приглашать новых пользователей в чат.</param>
/// <param name="CanPinMessages">True - если администратор может закреплять сообщения(<b>только супергруппы</b>).</param>
public record PromoteChatMember(
    ChatId ChatId,
    long UserId,
    bool? IsAnonymous,
    bool? CanManageChat,
    bool? CanPostMessages,
    bool? CanEditMessages,
    bool? CanDeleteMessages,
    bool? CanManageVideoChats,
    bool? CanRestrictMembers,
    bool? CanPromoteMembers,
    bool? CanChangeInfo,
    bool? CanInviteUsers,
    bool? CanPinMessages)
    : IEventEntity;