namespace Telegram.Contracts.DTOs.Chats.ChatMembers;

/// <summary>
/// Участник, который был заблокирован в чате и не может вернуться или посмотреть сообщения чата.
/// </summary>
/// <param name="User">Информация о пользователе.</param>
/// <param name="UntilDate">Дата снятия ограничения с пользователя(Unix). Если 0, то пользователь забанен навсегда.</param>
public record ChatMemberBanned(
    User User,
    int UntilDate)
    : ChatMember
{
    protected override string Status => "kicked";
}