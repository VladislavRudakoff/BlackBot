namespace Bot.Data.Enums;

/// <summary>
/// Type of the <see cref="Chat"/>, from which the inline query was sent
/// </summary>
public enum ChatType
{
    /// <summary>
    /// Normal one to one <see cref="Chat"/>
    /// </summary>
    Private = 1,

    /// <summary>
    /// Normal group chat
    /// </summary>
    Group = 2,

    /// <summary>
    /// A channel
    /// </summary>
    Channel = 3,

    /// <summary>
    /// A supergroup
    /// </summary>
    Supergroup = 4,

    /// <summary>
    /// “sender” for a private chat with the inline query sender
    /// </summary>
    Sender = 5
}