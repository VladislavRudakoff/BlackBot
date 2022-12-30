namespace FluentBot.Domain.Entities.Entities.Chats.ChatMembers;

/// <summary>
/// Владелец чата.
/// </summary>
/// <param name="User">Информация о пользователе.</param>
/// <param name="IsAnonymous">True, если пользователь скрыт в чате.</param>
/// <param name="CustomTitle">Заголовок пользователя.</param>
public record ChatMemberOwner(
    User User,
    bool IsAnonymous,
    string? CustomTitle)
    : ChatMember
{
    protected override string Status => "creator";
}