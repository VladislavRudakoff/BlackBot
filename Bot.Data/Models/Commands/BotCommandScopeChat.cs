namespace Bot.Data.Models.Commands;

/// <summary>
/// Область действия команд бота охватывающая все определенный чат.
/// </summary>
/// <param name="ChatId"></param>
public record BotCommandScopeChat(
    string ChatId)
    : BotCommandScope
{
    protected override string Type { get; init; } = "chat";
}