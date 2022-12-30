namespace FluentBot.Domain.Entities.Enums;

/// <summary>
/// Scope types.
/// </summary>
public enum BotCommandScopeType
{
    /// <summary>
    /// The default scope of bot commands.
    /// </summary>
    Default = 1,

    /// <summary>
    /// The scope of bot commands, covering all private chats.
    /// </summary>
    AllPrivateChats = 2,

    /// <summary>
    /// The scope of bot commands, covering all group and supergroup chats.
    /// </summary>
    AllGroupChats = 3,

    /// <summary>
    /// The scope of bot commands, covering all group and supergroup chat administrators.
    /// </summary>
    AllChatAdministrators = 4,

    /// <summary>
    /// The scope of bot commands, covering a specific chat.
    /// </summary>
    Chat = 5,

    /// <summary>
    /// The scope of bot commands, covering all administrators of a specific group or supergroup chat.
    /// </summary>
    ChatAdministrators = 6,

    /// <summary>
    /// The scope of bot commands, covering a specific member of a group or supergroup chat.
    /// </summary>
    ChatMember = 7
}