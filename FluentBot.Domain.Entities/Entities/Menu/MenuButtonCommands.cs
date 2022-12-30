namespace FluentBot.Domain.Entities.Entities.Menu;

/// <summary>
/// Кнопка меню, которая открывает список команд бота.
/// </summary>
public record MenuButtonCommands()
    : MenuButton
{
    protected override string Type { get; init; } = "commands";
}