namespace FluentBot.Domain.Entities.Entities.Commands;

/// <summary>
/// Область действия команд бота охватывающая все приватные чаты.
/// </summary>
public record BotCommandScopeAllPrivateChats()
    : BotCommandScope
{
    public override string Type { get; init; } = "all_private_chats";
}