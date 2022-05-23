namespace Telegram.Contracts.DTOs.Commands;

/// <summary>
/// Область действия команд бота охватывающая определенного члена группового или супергруппового чата.
/// </summary>
/// <param name="ChatId">Уникальный идентификатор чата или имя пользователя супергруппы.</param>
/// <param name="UserId">Идентификатор пользователя.</param>
public record BotCommandScopeChatMember(
    string ChatId,
    long UserId)
    : BotCommandScope
{
    public override string Type { get; init; } = "chat_member";
}