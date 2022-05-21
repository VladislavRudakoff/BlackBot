namespace Bot.Data.Enums;

/// <summary>
/// Scope type
/// </summary>
public enum BotCommandScopeType
{
    /// <summary>
    /// Represents the default <see cref="BotCommandScope"/> of bot commands. Default commands are used if no
    /// commands with a narrower <see cref="BotCommandScope"/> are specified for the user.
    /// </summary>
    Default = 1,

    /// <summary>
    /// Represents the <see cref="BotCommandScope"/> of bot commands, covering all private chats.
    /// </summary>
    AllPrivateChats = 2,

    /// <summary>
    /// Represents the <see cref="BotCommandScope"/> of bot commands, covering all group and supergroup chats.
    /// </summary>
    AllGroupChats = 3,

    /// <summary>
    /// Represents the <see cref="BotCommandScope"/> of bot commands, covering all group and supergroup
    /// chat administrators.
    /// </summary>
    AllChatAdministrators = 4,

    /// <summary>
    /// Represents the <see cref="BotCommandScope"/> of bot commands, covering a specific <see cref="Chat"/>.
    /// </summary>
    Chat = 5,

    /// <summary>
    /// Represents the <see cref="BotCommandScope"/> of bot commands, covering all administrators of
    /// a specific group or supergroup <see cref="Chat"/>.
    /// </summary>
    ChatAdministrators = 6,

    /// <summary>
    /// Represents the <see cref="BotCommandScope"/> of bot commands, covering a specific member of
    /// a group or supergroup <see cref="Chat"/>.
    /// </summary>
    ChatMember = 7
}