namespace FluentBot.Domain.Entities.Entities.Commands;

/// <summary>
/// The scope to which the bot commands apply.
/// </summary>
public abstract record BotCommandScope
{
    /// <summary>
    /// Scope type.
    /// </summary>
    public abstract BotCommandScopeType Type { get; }
}

/// <summary>
/// The scope of bot commands, covering a specific chat.
/// </summary>
/// <typeparam name="TChatId"></typeparam>
/// <param name="ChatId"></param>
public abstract record BotCommandScopeChat<TChatId>(TChatId ChatId) : BotCommandScope
{
    public override BotCommandScopeType Type => BotCommandScopeType.Chat;
}

public abstract record BotCommandScopeChatAdministrators<TChatId>(TChatId ChatId) : BotCommandScope
{
    public override BotCommandScopeType Type => BotCommandScopeType.ChatAdministrators;
}

public abstract record BotCommandScopeChatMember<TChatId>(TChatId ChatId, long UserId) : BotCommandScope
{
    public override BotCommandScopeType Type => BotCommandScopeType.ChatMember;
}