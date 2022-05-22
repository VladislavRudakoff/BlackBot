namespace Bot.Data.Models.Commands;

/// <summary>
/// Область действия команд бота охватывающая все групповые и супергрупповые чаты.
/// </summary>
public record BotCommandScopeAllGroupChats()
    : BotCommandScope
{
    protected override string Type { get; init; } = "all_group_chats";
}