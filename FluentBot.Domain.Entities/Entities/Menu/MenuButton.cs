namespace FluentBot.Domain.Entities.Entities.Menu;

/// <summary>
/// Кнопка меню бота в приватном чате.
/// </summary>
public abstract record MenuButton()
{
    protected abstract string Type { get; init; }
}