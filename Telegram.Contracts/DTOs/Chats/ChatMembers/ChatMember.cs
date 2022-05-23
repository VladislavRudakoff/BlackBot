namespace Telegram.Contracts.DTOs.Chats.ChatMembers;

/// <summary>
/// Участник чата.
/// </summary>
public abstract record ChatMember
{
    /// <summary>
    /// Статус участника чата.
    /// </summary>
    protected abstract string Status { get; init; }
}