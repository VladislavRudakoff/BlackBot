namespace Bot.Data.Models.Chats.ChatMembers;

/// <summary>
/// Участник чата с определенными ограничениями. <b>Только в супергруппах.</b>
/// </summary>
/// <param name="User">Информация о пользователе.</param>
/// <param name="CanChangeInfo" > True, если пользователю разрешено изменять название чата, фото и другие настройки.</param>
/// <param name="CanInviteUsers">True, если пользователю разрешено приглашать новых пользователей в чат.</param>
/// <param name="CanPinMessages">True, если администратору разрешено закреплять сообщения.</param>
/// <param name="CanSendMessages">True, если пользователю разрешено отправлять текстовые сообщения, контакты, местоположения и места проведения.</param>
/// <param name="CanSendMediaMessages">True, если пользователю разрешено отправлять аудио, документы, фотографии, видео, аудио- и видеосообщения.</param>
/// <param name="CanSendPools">True, если пользователю разрешено отправлять опросы.</param>
/// <param name="CanSendOtherMessages">True, если пользователю разрешено отправлять анимации, игры, стикеры и использовать встроенных ботов.</param>
/// <param name="CanAddWebPagePreviews">True, если пользователю разрешено добавлять превью веб-страницы к своим сообщениям.</param>
/// <param name="UntilDate">Дата снятия ограничений для пользователя(Unix). Если 0, то пользователь ограничен навсегда.</param>
public record ChatMemberRestricted(
    User User,
    bool CanChangeInfo,
    bool CanInviteUsers,
    bool? CanPinMessages,
    bool? CanSendMessages,
    bool? CanSendMediaMessages,
    bool? CanSendPools,
    bool? CanSendOtherMessages,
    bool? CanAddWebPagePreviews, 
    int UntilDate) : ChatMember
{
    protected override string Status { get; init; } = "restricted";
}