namespace Bot.Data.Models.Commands;

/// <summary>
/// Область действия команд бота охватывающая всех администраторов группового и супергруппового чата.
/// </summary>
public record BotCommandScopeAllChatAdministrators()
    : BotCommandScope
{
    protected override string Type { get; init; } = "all_chat_administrators";
}