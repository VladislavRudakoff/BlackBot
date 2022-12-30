namespace FluentBot.Domain.Entities.Entities.Commands;

/// <summary>
/// Область действия команд бота охватывающая всех администраторов определенной группы или супергруппового чата.
/// </summary>
/// <param name="ChatId">Уникальный идентификатор чата или имя пользователя супергруппы.</param>
public record BotCommandScopeChatAdministrators(
    string ChatId)
    : BotCommandScope
{
    public override string Type { get; init; } = "chat_administrators";
}