namespace Bot.Data.Models.Commands;

/// <summary>
/// Область действия команд бота охватывающая все приватные чаты.
/// </summary>
public record BotCommandScopeAllPrivateChats()
    : BotCommandScope
{
    protected override string Type { get; init; } = "all_private_chats";
}