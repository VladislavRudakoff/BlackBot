namespace Telegram.Contracts.DTOs.Commands;

/// <summary>
/// Область действия команд бота охватывающая все определенный чат.
/// </summary>
/// <param name="ChatId"></param>
public record BotCommandScopeChat(
    string ChatId)
    : BotCommandScope
{
    public override string Type { get; init; } = "chat";
}