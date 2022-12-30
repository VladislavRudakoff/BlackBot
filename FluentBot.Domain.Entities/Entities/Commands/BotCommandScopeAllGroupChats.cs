namespace FluentBot.Domain.Entities.Entities.Commands;

/// <summary>
/// Область действия команд бота охватывающая все групповые и супергрупповые чаты.
/// </summary>
public record BotCommandScopeAllGroupChats()
    : BotCommandScope
{
    public override string Type { get; init; } = "all_group_chats";
}