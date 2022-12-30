namespace FluentBot.Domain.UseCases.Events.Chats.Users;

/// <summary>
/// Модель для снятия бана с пользователя(НЕ ВОЗВРАЩАЕТ пользователя в группу/канал).
/// </summary>
/// <param name="ChatId">Идентификатор чата.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
/// <param name="OnlyIfBanned">Если False - кикает пользователя из чата, если True - ничего не делает(применяется к НЕзабаненным пользователям).</param>
public record UnbanChatMember(
    ChatId ChatId,
    long UserId,
    bool? OnlyIfBanned)
    : IEventEntity;