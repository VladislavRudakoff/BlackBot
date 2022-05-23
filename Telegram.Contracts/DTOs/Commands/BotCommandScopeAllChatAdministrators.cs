namespace Telegram.Contracts.DTOs.Commands;

/// <summary>
/// Область действия команд бота охватывающая всех администраторов группового и супергруппового чата.
/// </summary>
public record BotCommandScopeAllChatAdministrators()
    : BotCommandScope
{
    public override string Type { get; init; } = "all_chat_administrators";
}