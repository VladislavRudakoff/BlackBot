namespace Telegram.Contracts.Enums.

/// <summary>
/// ChatMember status
/// </summary>
public enum ChatMemberStatus
{
    /// <summary>
    /// Creator of the <see cref="Chat"/>
    /// </summary>
    Creator = 1,

    /// <summary>
    /// Administrator of the <see cref="Chat"/>
    /// </summary>
    Administrator = 2,

    /// <summary>
    /// Normal member of the <see cref="Chat"/>
    /// </summary>
    Member = 3,

    /// <summary>
    /// A <see cref="User"/> who left the <see cref="Chat"/>
    /// </summary>
    Left = 4,

    /// <summary>
    /// A <see cref="User"/> who was kicked from the <see cref="Chat"/>
    /// </summary>
    Kicked = 5,

    /// <summary>
    /// A <see cref="User"/> who is restricted in the <see cref="Chat"/>
    /// </summary>
    Restricted = 6
}