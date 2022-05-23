using Telegram.Contracts.DTOs.Messages;

namespace Telegram.Contracts.DTOs.Chats;

/// <summary>
/// Чат.
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="Type">Тип чата.</param>
/// <param name="Title">Название.</param>
/// <param name="Username">Имя пользователя, для приватных чатов, супергрупп и каналов.</param>
/// <param name="FirstName">Имя собеседника в приватном чате.</param>
/// <param name="LastName">Фамилия собеседника в приватном чате.</param>
/// <param name="Photo"><see cref="ChatPhoto"/>.</param>
/// <param name="Bio">Биография собеседника, в приватном чате.</param>
/// <param name="HasPrivate">---Потом разберусь, сейчас не хочу.---</param>
/// <param name="Description">Описание, для групп, супергрупп и чатов каналов.</param>
/// <param name="InviteLink">Ссылка-приглашение для групп, супергрупп и чатов канала.</param>
/// <param name="PinnedMessage">Самое последнее закрепленное сообщение (по дате отправки).</param>
/// <param name="Permissions">Разрешения участников чата по умолчанию для групп и супергрупп.</param>
/// <param name="SlowModeDelay">Для супергрупп — минимальная допустимая задержка между сообщениями, отправляемыми каждым непривилегированным пользователем; <b>В секундах.</b></param>
/// <param name="MessageAutoDeleteTime">Время, по истечении которого все отправленные в чат сообщения будут автоматически удаляться; <b>В секундах.</b></param>
/// <param name="HasProtectedContent">True, если сообщения из чата нельзя пересылать в другие чаты.</param>
public record Chat(
    long ChatId, 
    string Type, 
    string? Title, 
    string? Username, 
    string? FirstName,
    string? LastName,
    ChatPhoto? Photo,
    string? Bio,
    bool? HasPrivate,
    string? Description,
    string? InviteLink,
    Message? PinnedMessage,
    ChatPermissions? Permissions,
    int? SlowModeDelay,
    int? MessageAutoDeleteTime,
    bool? HasProtectedContent);