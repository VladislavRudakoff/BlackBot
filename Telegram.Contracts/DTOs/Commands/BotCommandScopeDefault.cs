namespace Telegram.Contracts.DTOs.Commands;

/// <summary>
/// Область действия команд бота по умолчанию. <br />
/// <i>Команды по умолчанию используются, если для пользователя не указаны команды с более узкой областью действия</i>
/// </summary>
public record BotCommandScopeDefault()
    : BotCommandScope
{
    public override string Type { get; init; } = "default";
}