namespace FluentBot.Domain.Entities.Entities.Chats;

/// <summary>
/// Разрешения участников чата.
/// </summary>
/// <param name="CanSendMessages">True, если пользователю разрешено отправлять текстовые сообщения, контакты, местоположения и места.</param>
/// <param name="CanSendMediaMessages">True, если пользователю разрешено отправлять аудио, документы, фотографии, видео, видеозаметки и голосовые сообщения.</param>
/// <param name="CanSendPolls">True, если пользователю разрешено отправлять опросы.</param>
/// <param name="CanSendOtherMessages">True, если пользователю разрешено отправлять gif, игры, стикеры и использовать встроенных ботов.</param>
/// <param name="CanAddWebPagePreviews">True, если пользователю разрешено добавлять веб-страницы к своим сообщениям.</param>
/// <param name="CanChangeInfo">True, если пользователю разрешено изменять название чата, фото и другие настройки. <b>Игнорируется в публичных супергруппах.</b></param>
/// <param name="CanInviteUsers">True, если пользователю разрешено приглашать новых пользователей в чат.</param>
/// <param name="CanPinMessages">True, если пользователю разрешено закреплять сообщения. <b>Игнорируется в публичных супергруппах.</b></param>
public record ChatPermissions(
    bool CanSendMessages,
    bool CanSendMediaMessages,
    bool CanSendPolls,
    bool CanSendOtherMessages,
    bool CanAddWebPagePreviews,
    bool CanChangeInfo,
    bool CanInviteUsers,
    bool CanPinMessages);