namespace FluentBot.Domain.Entities.Entities.Chats.ChatMembers;

/// <summary>
/// Участник, который в данный момент не является участником чата, но может присоединиться к нему самостоятельно.
/// </summary>
/// <param name="User">Информация о пользователе.</param>
public record ChatMemberLeft(
    User User) 
    : ChatMember
{
    protected override string Status => "left";
}