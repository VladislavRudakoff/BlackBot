namespace Telegram.Contracts.DTOs.Chats.ChatMembers;

/// <summary>
/// Участник чата без дополнительных привилегий.
/// </summary>
/// <param name="User">Информация о пользователе.</param>
public record ChatMemberRegular(
    User User)
    : ChatMember
{
    protected override string Status => "member";
}